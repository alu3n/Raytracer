using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;

namespace NPGR031_RayTracer.Utilities.GeometryRepresentation
{
    class Mesh
    {
        public int[,] TriangleData;

        public Vector<double>[] VertexData;
        public Vector<double>[] VertexNormalData;
        public Vector<double>[] TriangleNormalData;

        public Mesh(double PosX, double PosY, double PosZ, double SizeX, double SizeY, double SizeZ)
        {
            //Constructor that creates cube as a mesh

            //Cube has 8 verticies
            SizeX /= 2;
            SizeY /= 2;
            SizeZ /= 2;

            Vector<double> center = Vector<double>.Build.DenseOfArray(new double[] { PosX, PosY, PosZ });
            Vector<double> DirX = Vector<double>.Build.DenseOfArray(new double[] { 1, 0, 0 });
            Vector<double> DirY = Vector<double>.Build.DenseOfArray(new double[] { 0, 1, 0 });
            Vector<double> DirZ = Vector<double>.Build.DenseOfArray(new double[] { 0, 0, 1 });
            

            VertexData = new Vector<double>[8];
            TriangleData = new int[12,3];
            TriangleNormalData = new Vector<double>[12];

            //EIGHT CUBE VERTICIES, THERE IS ONE FOR EACH CORNER
            VertexData[0] = center + SizeX * DirX + SizeY * DirY + SizeZ * DirZ;
            VertexData[1] = center - SizeX * DirX + SizeY * DirY + SizeZ * DirZ;
            VertexData[2] = center - SizeX * DirX + SizeY * DirY - SizeZ * DirZ;
            VertexData[3] = center + SizeX * DirX + SizeY * DirY - SizeZ * DirZ;
            VertexData[4] = center + SizeX * DirX - SizeY * DirY + SizeZ * DirZ;
            VertexData[5] = center - SizeX * DirX - SizeY * DirY + SizeZ * DirZ;
            VertexData[6] = center - SizeX * DirX - SizeY * DirY - SizeZ * DirZ;
            VertexData[7] = center + SizeX * DirX - SizeY * DirY - SizeZ * DirZ;

            //TOP FACE
            TriangleData[0, 0] = 0;
            TriangleData[0, 1] = 1;
            TriangleData[0, 2] = 2;

            TriangleData[1, 0] = 0;
            TriangleData[1, 1] = 2;
            TriangleData[1, 2] = 3;

            TriangleNormalData[0] = DirY;
            TriangleNormalData[1] = DirY;

            //FRONT FACE
            TriangleData[2, 0] = 0;
            TriangleData[2, 1] = 1;
            TriangleData[2, 2] = 5;

            TriangleData[3, 0] = 0;
            TriangleData[3, 1] = 5;
            TriangleData[3, 2] = 4;

            TriangleNormalData[2] = DirZ;
            TriangleNormalData[3] = DirZ;

            //RIGHT FACE
            TriangleData[4, 0] = 0;
            TriangleData[4, 1] = 3;
            TriangleData[4, 2] = 4;

            TriangleData[5, 0] = 4;
            TriangleData[5, 1] = 7;
            TriangleData[5, 2] = 3;

            TriangleNormalData[4] = DirX;
            TriangleNormalData[5] = DirX;

            //BACK FACE
            TriangleData[6, 0] = 3;
            TriangleData[6, 1] = 7;
            TriangleData[6, 2] = 6;

            TriangleData[7, 0] = 3;
            TriangleData[7, 1] = 2;
            TriangleData[7, 2] = 6;

            TriangleNormalData[6] = -DirZ;
            TriangleNormalData[7] = -DirZ;

            //LEFT FACE
            TriangleData[8, 0] = 2;
            TriangleData[8, 1] = 6;
            TriangleData[8, 2] = 5;

            TriangleData[9, 0] = 1;
            TriangleData[9, 1] = 2;
            TriangleData[9, 2] = 5;

            TriangleNormalData[8] = -DirX;
            TriangleNormalData[9] = -DirX;


            //BOTTOM FACE
            TriangleData[10, 0] = 6;
            TriangleData[10, 1] = 5;
            TriangleData[10, 2] = 4;

            TriangleData[11, 0] = 7;
            TriangleData[11, 1] = 6;
            TriangleData[11, 2] = 4;

            TriangleNormalData[10] = -DirY;
            TriangleNormalData[11] = -DirY;

        }
    }
}