using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPGR031_RayTracer.Scene
{
    /*
     * This class is a container for scene objects that are used during simulation.
     */

    class Scene
    {
        public Geometry Geo;
        public Camera Cam;
        public List<Light> Lights;
        public int ResolutionX = 750;
        public int ResolutionY = 750;
        public double PhongExponent;
        public int RayDepth;
        public int SampleSize;
        public double reflection_intensity;

        public Scene()
        {
            Geo = new Geometry();
            Cam = new Camera();
            Lights = new List<Light>();
            Lights.Add(new Light());
            Lights.Add(new Light());
            Lights.Add(new Light());
            ResolutionX = 1;
            ResolutionY = 1;
            RayDepth = 1;
            SampleSize = 1;
            reflection_intensity = 1;
        }

    }
}
