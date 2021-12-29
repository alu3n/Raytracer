using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;

namespace NPGR031_RayTracer.Utilities.GeometryRepresentation.PrimitiveTypes
{
    class Sphere
    {
        public Vector<double> position;
        public double radius;
        public byte[] surface_color;

        public Sphere(double PosX, double PosY, double PosZ, double Radius, byte R, byte G, byte B)
        {
            surface_color = new byte[] { R, G, B };
            radius = Radius;
            position = Vector<double>.Build.DenseOfArray(new double[] { PosX, PosY, PosZ });
        }

        public Vector<double> GetColor()
        {
            return Vector<double>.Build.DenseOfArray(new double[]{surface_color[0],surface_color[1],surface_color[2]});
        }
    }
}
