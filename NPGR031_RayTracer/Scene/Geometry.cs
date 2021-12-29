using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;
using NPGR031_RayTracer.Utilities.InputOutput;
using NPGR031_RayTracer.Utilities.GeometryRepresentation;

using NPGR031_RayTracer.Utilities.GeometryRepresentation.PrimitiveTypes;

namespace NPGR031_RayTracer.Scene
{
    public enum GeoType{
        Empty = 0,
        Primitive = 1,
    }

    /*
     * Purpouse of this class is to hold geometry data
     */

    class Geometry
    {
        public byte[] DiffuseColor = new byte[] { 255, 255, 255 };
        
        public PrimitiveMesh PrimitiveMeshData;

        public GeoType type = GeoType.Empty;

        public string LoadPrimitive()
        {
            PrimitiveMeshData = new PrimitiveMesh();
            
            type = GeoType.Primitive;
            return ImportJson.LoadJsonDialog(PrimitiveMeshData);
        }

    }
        
}
