using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;

namespace NPGR031_RayTracer.Scene
{
    class Light
    {
        public byte[] SpecularColor;
        public Vector<double> Position;
        public double Intensity;

        public Light()
        {
            SpecularColor = new byte[] { 255, 255, 255 };
            Position = Vector<double>.Build.DenseOfArray(new double[] { 0, 0, 0 });
            Intensity = 1;
        }
    }
}
