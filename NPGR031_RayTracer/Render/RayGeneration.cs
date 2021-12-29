using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NPGR031_RayTracer.Scene;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Spatial.Euclidean;
using MathNet.Spatial.Units;
using System.Diagnostics;

namespace NPGR031_RayTracer.Render
{
    /*
     * Purpouse of this class is to generate ray based on x and y coordinates of an finall image
     * For more info about the ray generation process check out Introduction to Computer Graphics page 73-75
     */
    static class RayGeneration
    {
        public static Vector<double> GenerateRay(Scene.Scene scene, double x, double y, Matrix<double> camera_basis, double pixel_size)
        {
            Vector<double> result = camera_basis.Column(2);

            result += ((-scene.ResolutionX + 1) / 2 + x) * pixel_size * camera_basis.Column(0);
            result += ((-scene.ResolutionY + 1) / 2 + y) * pixel_size * camera_basis.Column(1);

            return result.Normalize(2);
        }
        
    }
}
