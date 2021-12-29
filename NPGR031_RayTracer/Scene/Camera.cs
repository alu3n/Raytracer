using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;

namespace NPGR031_RayTracer.Scene
{
    class Camera
    {
        public Vector<double> Position;
        public Vector<double> Rotation;
        public Matrix<double> Basis;
        public double ProjectionDistance;
        public double Angle;

        public Camera()
        {
            Position = Vector<double>.Build.DenseOfArray(new double[] { 0, 0, 0 });
            Rotation = Vector<double>.Build.DenseOfArray(new double[] { 0, 0, 0 });
            Basis = Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } });
            //How far from the camera will be projection plane generated
            ProjectionDistance = 1;
            Angle = 120;
        }
    }
}
