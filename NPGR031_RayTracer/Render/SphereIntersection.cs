using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;
using NPGR031_RayTracer.Scene;

using NPGR031_RayTracer.Utilities.GeometryRepresentation.PrimitiveTypes;

namespace NPGR031_RayTracer.Render
{
    /*
     * Purpouse of this static class is to compute Ray-Sphere intersections
     * For more information Introduction to Computer Graphics page 76-77
     * 
     * Sphere in space can be described by equation as well as the ray, this class is solving their intersection numericaly
     * 
     * Output format of the matrix
     * Column 0: Intersection position 
     * Column 1: Intersection normal
     * Column 2, Row 0: Distance betweein intersection position and camera
     * Column 3: Intersection geometry color
     */

    static class SphereIntersection
    {
        public static Matrix<double> ComputeIntersection(Scene.Scene scene, Vector<double> ray, Vector<double> ray_origin)
        {
            double min_distance = 0;

            Matrix<double> result = Matrix<double>.Build.DenseOfArray(new double[3, 4]);

            double A = ray*ray;

            foreach(Sphere S in scene.Geo.PrimitiveMeshData.Spheres)
            {
                double B = 2 * ray * (ray_origin - S.position);
                double C = (ray_origin - S.position) * (ray_origin - S.position) - Math.Pow(S.radius, 2);
                double Diskriminant = B*B - 4 * A * C;

                if(Diskriminant == 0)
                {
                    double x1 = -B / (2 * A);
                    if (x1 > min_distance && (result.Storage[0, 2] == 0 | x1 < result.Storage[0, 2]))
                    {
                        result.Storage[0, 2] = x1;
                        result.SetColumn(0, ray_origin + result.Storage[0, 2] * ray);
                        result.SetColumn(1, ray_origin + result.Storage[0, 2] * ray - S.position);
                        result.SetColumn(3, S.GetColor());
                    }
                }
                else if(Diskriminant > 0)
                {
                    double x1 = (-B + Math.Sqrt(Diskriminant)) / (2 * A);
                    double x2 = (-B - Math.Sqrt(Diskriminant)) / (2 * A);

                    if(x1 > min_distance && x2 > min_distance)
                    {
                        double root = Math.Min(x1, x2);
                        if(root < result.Storage[0, 2] | (result.Storage[0,2] == 0 & root > min_distance))
                        {
                            result.Storage[0, 2] = root;
                            result.SetColumn(0, ray_origin + result.Storage[0, 2] * ray);
                            result.SetColumn(1, ray_origin + result.Storage[0, 2] * ray - S.position);
                            result.SetColumn(3, S.GetColor());
                        }
                    }
                    else if(x1 > min_distance)
                    {
                        if(x1 < result.Storage[0, 2] | (result.Storage[0, 2] == 0 & x1 > min_distance))
                        {
                            result.Storage[0, 2] = x1;
                            result.SetColumn(0, ray_origin + result.Storage[0, 2] * ray);
                            result.SetColumn(1, ray_origin + result.Storage[0, 2] * ray - S.position);
                            result.SetColumn(3, S.GetColor());
                        }
                    }
                    else if(x2 > min_distance)
                    {
                        if (x2 < result.Storage[0, 2] | (result.Storage[0, 2] == 0 & x2 > min_distance))
                        {
                            result.Storage[0, 2] = x2;
                            result.SetColumn(0, ray_origin + result.Storage[0, 2] * ray);
                            result.SetColumn(1, ray_origin + result.Storage[0, 2] * ray - S.position);
                            result.SetColumn(3, S.GetColor());
                        }
                    }

                }
            }

            return result;
        }
    }
}
