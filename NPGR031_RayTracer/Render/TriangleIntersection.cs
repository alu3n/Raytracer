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
    static class TriangleIntersection
    {

        /*
         * Purpouse of this static class is to compute Ray-Triangle intersections
         * For more information Introduction to Computer Graphics page 78-79
         * 
         * Triangle is described by three points in space. We're solving Ray-Plane intersection, where the plane
         * is described by points of the triangle. We can determine if is the plane intersection point inside triangle by using barycentric coordinates.
         * 
         * Output format of the matrix
         * Column 0: Intersection position 
         * Column 1: Intersection normal
         * Column 2, Row 0: Distance betweein intersection position and camera
         * Column 3: Intersection geometry color
         */


        public static Matrix<double> ComputeIntersection(Scene.Scene scene, Vector<double> ray, Vector<double> ray_origin) {
            double MinimumIntersectionDistance = 0.01;
            double MaximumIntersectionDistance = 10000;

            Matrix<double> result = Matrix<double>.Build.DenseOfArray(new double[3, 4]);

            foreach(Cube C in scene.Geo.PrimitiveMeshData.Cubes)
            {
                for (int i = 0; i < C.MeshData.TriangleData.GetLength(0); i++)
                {
                    Vector<double> p_a = C.MeshData.VertexData[C.MeshData.TriangleData[i, 0]];
                    Vector<double> p_b = C.MeshData.VertexData[C.MeshData.TriangleData[i, 1]];
                    Vector<double> p_c = C.MeshData.VertexData[C.MeshData.TriangleData[i, 2]];

                    Matrix<double> A = Matrix<double>.Build.DenseOfColumnVectors(p_a - p_b, p_a - p_c, ray);
                    Vector<double> b = p_a - ray_origin;

                    Vector<double> x = A.Solve(b);

                    if (x.Storage[2] < MinimumIntersectionDistance | x.Storage[2] > MaximumIntersectionDistance)
                    {
                        continue;
                    }
                    else if (x.Storage[1] < 0 | x.Storage[0] > 1)
                    {
                        continue;
                    }
                    else if (x.Storage[0] < 0 | x.Storage[0] > 1 - x.Storage[1])
                    {
                        continue;
                    }
                    else
                    {
                        if (result.Storage[0,2] == 0 | x.Storage[2] < result.Storage[0,2])
                        {
                            result.Storage[0, 2] = x.Storage[2];
                            result.SetColumn(0, result.Storage[0, 2] * ray + ray_origin);
                            result.SetColumn(1, C.MeshData.TriangleNormalData[i]);
                            result.SetColumn(3, C.GetColor());
                        }
                    }
                }
            }

            return result;
        }
    }
}
