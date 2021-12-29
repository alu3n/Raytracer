using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Spatial.Euclidean;
using MathNet.Spatial.Units;



namespace NPGR031_RayTracer.Render
{
    static class Simulation
    {
        /*
         * Purpouse of this class is to gather all parts of the raytracing projects and merge the together to create output image
         * For more information about raytracing checkout Introduction to Computer Graphics chapter 4, 13
         */

        public static Bitmap Render(Scene.Scene scene)
        {
            //Size of the pixel grid that will be averaged into single pixel
            int sample_size = scene.SampleSize;

            byte[,,] color = new byte[scene.ResolutionX,scene.ResolutionY,3];

            //Creating rotation matricies for the camera rotation
            Angle RotX = Angle.FromDegrees(scene.Cam.Rotation.Storage[0]);
            Angle RotY = Angle.FromDegrees(scene.Cam.Rotation.Storage[1]);
            Angle RotZ = Angle.FromDegrees(scene.Cam.Rotation.Storage[2]);

            //Rotating basis for the ray projection 
            Matrix<double> rotated_basis = scene.Cam.Basis * Matrix3D.RotationAroundXAxis(RotX) * Matrix3D.RotationAroundYAxis(RotY) * Matrix3D.RotationAroundZAxis(RotZ);

            //Compute projection plane width
            double width = 2 * Math.Tan((scene.Cam.Angle * Math.PI / 180) / 2) * scene.Cam.ProjectionDistance;
            double pixel_size = width / Math.Max(scene.ResolutionX, scene.ResolutionY);

            //In case the geometry is not loaded yet return empty image
            if (scene.Geo.type == Scene.GeoType.Empty)
            {
                return new Bitmap(scene.ResolutionX, scene.ResolutionY);
            }

            //Main simulation loop, computation happens for each pixel
            Parallel.For(0, scene.ResolutionX, x =>
            {
                for (int y = 0; y < scene.ResolutionY; y++)
                {
                    int[] sample_color = new int[] { 0, 0, 0 };

                    //intersection is used for Ray-Sphere intersection, intersection2 is used for Ray-Triangle intersection
                    Matrix<double> intersection2;
                    Matrix<double> intersection;
                    Vector<double> ray;

                    //this loop computes samples, it serves as an counterwight to battle aliasing
                    for (int i = 0; i < sample_size; i++)
                    {
                        for (int j = 0; j < sample_size; j++)
                        {
                            double x_sample = x - 1.0 / 2.0 + 1.0 / (2.0 * sample_size) + i / Convert.ToDouble(sample_size);
                            double y_sample = y - 1.0 / 2.0 + 1.0 / (2.0 * sample_size) + j / Convert.ToDouble(sample_size);

                            ray = RayGeneration.GenerateRay(scene, x_sample, y_sample, rotated_basis, pixel_size);


                            //chose intersection based on with one was closer to the camera
                            if (scene.Geo.type == Scene.GeoType.Primitive)
                            {
                                intersection = SphereIntersection.ComputeIntersection(scene, ray, scene.Cam.Position);
                                intersection2 = TriangleIntersection.ComputeIntersection(scene, ray, scene.Cam.Position);

                                if (intersection.Storage[0, 2] != 0 && intersection2.Storage[0, 2] != 0)
                                {
                                    if (intersection.Storage[0, 2] > intersection2.Storage[0, 2])
                                    {
                                        intersection = intersection2;
                                    }
                                }
                                else if(intersection2.Storage[0,2] != 0)
                                {
                                    intersection = intersection2;
                                }
                            }
                            else
                            {
                                continue;
                            }


                            //shades the pixel its ray hit some object, uses background color otherwise
                            if (intersection.Storage[0, 2] != 0)
                            {
                                if (scene.Geo.type == Scene.GeoType.Primitive)
                                {
                                    byte[] PixelColor = ShadingModels.ImprovedBlinnPhong.shade(intersection, ray.Normalize(2), scene, scene.RayDepth);
     
                                    sample_color[0] += PixelColor[0];
                                    sample_color[1] += PixelColor[1];
                                    sample_color[2] += PixelColor[2];
                                }
                            }
                            else
                            {
                                sample_color[0] += scene.Geo.DiffuseColor[0];
                                sample_color[1] += scene.Geo.DiffuseColor[1];
                                sample_color[2] += scene.Geo.DiffuseColor[2];
                            }
                        }
                    }

                    //Computes the final color from the samples
                    color[x, y, 0] = Convert.ToByte(sample_color[0] / (sample_size * sample_size));
                    color[x, y, 1] = Convert.ToByte(sample_color[1] / (sample_size * sample_size));
                    color[x, y, 2] = Convert.ToByte(sample_color[2] / (sample_size * sample_size));
                }
            });

            return PaintBitmap(color);
        }

        //This is responsible for outputing bitmap from an color array
        public static Bitmap PaintBitmap(byte[,,] color)
        {
            Bitmap image = new Bitmap(color.GetLength(0), color.GetLength(1));

            for (int x = 0; x < color.GetLength(0); x++)
            {
                for (int y = 0; y < color.GetLength(1); y++)
                {
                    image.SetPixel(x, y, Color.FromArgb(color[x, y, 0], color[x, y, 1], color[x, y, 2]));
                }
            }

            return image;
        }
    }
}
