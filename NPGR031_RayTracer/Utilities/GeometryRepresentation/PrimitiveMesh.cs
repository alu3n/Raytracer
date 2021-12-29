using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NPGR031_RayTracer.Utilities.GeometryRepresentation.PrimitiveTypes;

namespace NPGR031_RayTracer.Utilities.GeometryRepresentation
{
    class PrimitiveMesh
    {
        public List<Sphere> Spheres;
        public List<Cube> Cubes;

        public PrimitiveMesh()
        {
            Spheres = new List<Sphere>();
            Cubes = new List<Cube>();
        }
    }
}
