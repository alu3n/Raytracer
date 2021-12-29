using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NPGR031_RayTracer.Scene;
using MathNet.Numerics.LinearAlgebra;

namespace NPGR031_RayTracer.Utilities.Interface
{
    class SceneSettings
    {
        //CAMERA SETTINGS
        public Vector<double> CameraPosition = Vector<double>.Build.DenseOfArray(new double[]{0, 0, -5});
        public Vector<double> CameraRotation = Vector<double>.Build.DenseOfArray(new double[]{0, 0, 0});
        public double LensAngle = 90;
        public double ProjectionDistance = 1;

        //LIGHT 1 SETTINGS
        public Vector<double> Light1Position = Vector<double>.Build.DenseOfArray(new double[] {-1234,234,-123});
        public byte[] Light1Specular = new byte[] {255,255,255};
        public double Light1Intensity = 0.4;

        //LIGHT 2 SETTINGS
        public Vector<double> Light2Position = Vector<double>.Build.DenseOfArray(new double[] { 1000, 3000, -1234 });
        public byte[] Light2Specular = new byte[] { 255, 255, 255 };
        public double Light2Intensity = 0.4;

        //LIGHT 3 SETTINGS
        public Vector<double> Light3Position = Vector<double>.Build.DenseOfArray(new double[] { 100, -100, 111 });
        public byte[] Light3Specular = new byte[] { 255, 255, 255 };
        public double Light3Intensity = 0.3;

        //RENDER SETTINGS
        public int ResolutionX = 500;
        public int ResolutionY = 500;
        public double PhongExponent = 20;
        public byte[] DiffuseColor = new byte[] { 255, 255, 255 };
        public int sample_size = 1;
        public int ray_depth = 1;
        public double reflection_intensity = 0.5;


        public void PushSettings(Scene.Scene scene)
        {
            scene.Cam.Position = CameraPosition;
            scene.Cam.Rotation = CameraRotation;
            scene.Cam.Angle = LensAngle;
            scene.Cam.ProjectionDistance = ProjectionDistance;

            scene.Lights[0].Position = Light1Position;
            scene.Lights[0].SpecularColor = Light1Specular;
            scene.Lights[0].Intensity = Light1Intensity;

            scene.Lights[1].Position = Light2Position;
            scene.Lights[1].SpecularColor = Light2Specular;
            scene.Lights[1].Intensity = Light2Intensity;

            scene.Lights[2].Position = Light3Position;
            scene.Lights[2].SpecularColor = Light3Specular;
            scene.Lights[2].Intensity = Light3Intensity;

            scene.ResolutionX = ResolutionX;
            scene.ResolutionY = ResolutionY;
            scene.PhongExponent = PhongExponent;
            scene.Geo.DiffuseColor = DiffuseColor;

            scene.RayDepth = ray_depth;
            scene.SampleSize = sample_size;
            scene.reflection_intensity = this.reflection_intensity;
        }
    }
}
