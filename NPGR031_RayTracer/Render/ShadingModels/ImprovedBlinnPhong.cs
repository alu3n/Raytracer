using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;

namespace NPGR031_RayTracer.Render.ShadingModels
{
    /*
     * Purpouse of this class is to shade pixel based on attributes gathered during previous stages of raytracing
     * Output of this class is an pixel color represented as an byte array
     */

    static class ImprovedBlinnPhong
    {
        public static byte[] shade(Matrix<double> Intersection, Vector<double> Ray, Scene.Scene scene, int depth)
        {
            byte[] color = new byte[] { 0, 0, 0 };
            Vector<double> color_unclamped = Intersection.Column(3)/25;

            Vector<double> IntersectionPosition = Intersection.Column(0);
            Vector<double> IntersectionNormal = Intersection.Column(1);
            Vector<double> IntersectionColor = Intersection.Column(3);

            foreach (Scene.Light L in scene.Lights)
            {
                double ColorMultiplier;
                double SpecularMultiplier;

                Vector<double> LightDirection = L.Position - IntersectionPosition;
                Vector<double> h;

                h = (LightDirection.Normalize(2) + Ray.Normalize(2));
                h = h.Normalize(2);

                Matrix<double> ShadowComputation1 = SphereIntersection.ComputeIntersection(scene, LightDirection, IntersectionPosition + IntersectionNormal * 0.01);
                Matrix<double> ShadowComputation2 = TriangleIntersection.ComputeIntersection(scene, LightDirection, IntersectionPosition + IntersectionNormal * 0.01);

                if ((ShadowComputation1.Storage[0, 2] <= 0 | ShadowComputation1.Storage[0, 2] > 1) && (ShadowComputation2.Storage[0,2] <= 0 | ShadowComputation2.Storage[0,2] > 1))
                {
                    ColorMultiplier = L.Intensity * Math.Max(0, IntersectionNormal.Normalize(2) * LightDirection.Normalize(2));
                    SpecularMultiplier = L.Intensity * Math.Pow(Math.Max(0, IntersectionNormal.Normalize(2) * h), scene.PhongExponent);

                    color_unclamped += ColorMultiplier * IntersectionColor + SpecularMultiplier * Vector<double>.Build.DenseOfArray(new double[] { L.SpecularColor[0], L.SpecularColor[1], L.SpecularColor[2] });
                }

            }

            if (depth > 1)
            {
                Vector<double> r = Ray.Normalize(2) - 2 * (Ray.Normalize(2) * IntersectionNormal) * IntersectionNormal;
                Matrix<double> intersection = SphereIntersection.ComputeIntersection(scene, r, IntersectionPosition + IntersectionNormal * 0.01);
                Matrix<double> intersection2 = TriangleIntersection.ComputeIntersection(scene, r, IntersectionPosition + IntersectionNormal * 0.01);

                if (intersection.Storage[0, 2] != 0 && intersection2.Storage[0, 2] != 0)
                {
                    if (intersection.Storage[0, 2] > intersection2.Storage[0, 2])
                    {
                        intersection = intersection2;
                    }
                }
                else if (intersection2.Storage[0, 2] != 0)
                {
                    intersection = intersection2;
                }

                byte[] clr = shade(intersection, r.Normalize(2), scene, depth - 1);
                color_unclamped[0] += clr[0] * scene.reflection_intensity;
                color_unclamped[1] += clr[1] * scene.reflection_intensity;
                color_unclamped[2] += clr[2] * scene.reflection_intensity;
            }

            color[0] = Convert.ToByte(Math.Max(0, Math.Min(color_unclamped[0], 255)));
            color[1] = Convert.ToByte(Math.Max(0, Math.Min(color_unclamped[1], 255)));
            color[2] = Convert.ToByte(Math.Max(0, Math.Min(color_unclamped[2], 255)));

            return color;
        }
    }
}
