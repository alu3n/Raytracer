using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;

namespace NPGR031_RayTracer.Utilities.GeometryRepresentation.PrimitiveTypes
{

    class Cube
    {
        public byte[] surface_color;

        public Mesh MeshData;

        public Cube(double PosX, double PosY, double PosZ, double SizeX, double SizeY, double SizeZ, byte R, byte G, byte B)
        {
            surface_color = new byte[] { R,G,B};
            MeshData = new Mesh(PosX, PosY, PosZ, SizeX, SizeY, SizeZ);
        }

        public Vector<double> GetColor()
        {
            return Vector<double>.Build.DenseOfArray(new double[] { surface_color[0], surface_color[1], surface_color[2] });
        }
    }
}
