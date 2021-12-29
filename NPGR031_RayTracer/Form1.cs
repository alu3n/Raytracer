using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPGR031_RayTracer.Utilities.Interface;

namespace NPGR031_RayTracer
{
    public partial class Main : Form
    {
        RayTracer MainRayTracer = new RayTracer();
        SceneSettings settings = new SceneSettings();
        double zoom = 1;

        public Main()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            //Camera
            CamPosX.Text = settings.CameraPosition.Storage[0].ToString();
            CamPosY.Text = settings.CameraPosition.Storage[1].ToString();
            CamPosZ.Text = settings.CameraPosition.Storage[2].ToString();

            CamRotX.Text = settings.CameraRotation.Storage[0].ToString();
            CamRotY.Text = settings.CameraRotation.Storage[1].ToString();
            CamRotZ.Text = settings.CameraRotation.Storage[2].ToString();

            LensAngle.Text = settings.LensAngle.ToString();
            ProjectionDistance.Text = settings.ProjectionDistance.ToString();

            //Light 1 Settings
            Light1PosX.Text = settings.Light1Position.Storage[0].ToString();
            Light1PosY.Text = settings.Light1Position.Storage[1].ToString();
            Light1PosZ.Text = settings.Light1Position.Storage[2].ToString();

            Light1SpecRed.Text = settings.Light1Specular[0].ToString();
            Light1SpecGreen.Text = settings.Light1Specular[1].ToString();
            Light1SpecBlue.Text = settings.Light1Specular[2].ToString();

            Light1Intensity.Text = settings.Light1Intensity.ToString();

            //Light 2 Settings
            Light2PosX.Text = settings.Light2Position.Storage[0].ToString();
            Light2PosY.Text = settings.Light2Position.Storage[1].ToString();
            Light2PosZ.Text = settings.Light2Position.Storage[2].ToString();

            Light2SpecRed.Text = settings.Light2Specular[0].ToString();
            Light2SpecGreen.Text = settings.Light2Specular[1].ToString();
            Light2SpecBlue.Text = settings.Light2Specular[2].ToString();

            Light2Intensity.Text = settings.Light2Intensity.ToString();

            //Light 3 Settings
            Light3PosX.Text = settings.Light3Position.Storage[0].ToString();
            Light3PosY.Text = settings.Light3Position.Storage[1].ToString();
            Light3PosZ.Text = settings.Light3Position.Storage[2].ToString();

            Light3SpecRed.Text = settings.Light3Specular[0].ToString();
            Light3SpecGreen.Text = settings.Light3Specular[1].ToString();
            Light3SpecBlue.Text = settings.Light3Specular[2].ToString();

            Light3Intensity.Text = settings.Light3Intensity.ToString();

            //Render Settings
            ResolutionX.Text = settings.ResolutionX.ToString();
            ResolutionY.Text = settings.ResolutionY.ToString();

            PhongExponent.Text = settings.PhongExponent.ToString();

            DiffuseRed.Text = settings.DiffuseColor[0].ToString();
            DiffuseGreen.Text = settings.DiffuseColor[1].ToString();
            DiffuseBlue.Text = settings.DiffuseColor[2].ToString();

            textBox1.Text = settings.sample_size.ToString();
            textBox2.Text = settings.ray_depth.ToString();
            textBox3.Text = settings.reflection_intensity.ToString();
        }

        private void PushSettings()
        {
            //Camera
            settings.CameraPosition.Storage[0] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(CamPosX.Text, 0));
            settings.CameraPosition.Storage[1] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(CamPosY.Text, 0));
            settings.CameraPosition.Storage[2] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(CamPosZ.Text, 0));

            settings.CameraRotation.Storage[0] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(CamRotX.Text, 0));
            settings.CameraRotation.Storage[1] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(CamRotY.Text, 0));
            settings.CameraRotation.Storage[2] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(CamRotZ.Text, 0));

            settings.LensAngle = Convert.ToDouble(FormatingCheck.ValidateMinimalValue(LensAngle.Text, 10));
            settings.ProjectionDistance = Convert.ToDouble(FormatingCheck.ValidateMinimalValue(ProjectionDistance.Text, 0.1));

            //Light 1 settings
            settings.Light1Position.Storage[0] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light1PosX.Text, 0));
            settings.Light1Position.Storage[1] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light1PosY.Text, 0));
            settings.Light1Position.Storage[2] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light1PosZ.Text, 0));

            settings.Light1Specular[0] = Convert.ToByte(FormatingCheck.ValidateStringNumber(Light1SpecRed.Text, 0));
            settings.Light1Specular[1] = Convert.ToByte(FormatingCheck.ValidateStringNumber(Light1SpecGreen.Text, 0));
            settings.Light1Specular[2] = Convert.ToByte(FormatingCheck.ValidateStringNumber(Light1SpecBlue.Text, 0));

            settings.Light1Intensity = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light1Intensity.Text, 0));

            //Light 2 settings
            settings.Light2Position.Storage[0] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light2PosX.Text, 0));
            settings.Light2Position.Storage[1] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light2PosY.Text, 0));
            settings.Light2Position.Storage[2] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light2PosZ.Text, 0));

            settings.Light2Specular[0] = Convert.ToByte(FormatingCheck.ValidateStringNumber(Light2SpecRed.Text, 0));
            settings.Light2Specular[1] = Convert.ToByte(FormatingCheck.ValidateStringNumber(Light2SpecGreen.Text, 0));
            settings.Light2Specular[2] = Convert.ToByte(FormatingCheck.ValidateStringNumber(Light2SpecBlue.Text, 0));

            settings.Light2Intensity = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light2Intensity.Text, 0));

            //Light 3 settings
            settings.Light3Position.Storage[0] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light3PosX.Text, 0));
            settings.Light3Position.Storage[1] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light3PosY.Text, 0));
            settings.Light3Position.Storage[2] = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light3PosZ.Text, 0));

            settings.Light3Specular[0] = Convert.ToByte(FormatingCheck.ValidateStringNumber(Light3SpecRed.Text, 0));
            settings.Light3Specular[1] = Convert.ToByte(FormatingCheck.ValidateStringNumber(Light3SpecGreen.Text, 0));
            settings.Light3Specular[2] = Convert.ToByte(FormatingCheck.ValidateStringNumber(Light3SpecBlue.Text, 0));

            settings.Light3Intensity = Convert.ToDouble(FormatingCheck.ValidateStringNumber(Light3Intensity.Text, 0));

            //Render settings
            settings.ResolutionX = Convert.ToInt32(FormatingCheck.ValidateMinimalValue(ResolutionX.Text, 50));
            settings.ResolutionY = Convert.ToInt32(FormatingCheck.ValidateMinimalValue(ResolutionY.Text, 50));

            settings.sample_size = Convert.ToInt32(FormatingCheck.ValidateMinimalValue(textBox1.Text, 1));
            settings.ray_depth = Convert.ToInt32(FormatingCheck.ValidateMinimalValue(textBox2.Text, 1));

            settings.PhongExponent = Convert.ToDouble(FormatingCheck.ValidateStringNumber(PhongExponent.Text, 1));

            settings.DiffuseColor[0] = Convert.ToByte(FormatingCheck.ValidateMinimalValue(DiffuseRed.Text, 0));
            settings.DiffuseColor[1] = Convert.ToByte(FormatingCheck.ValidateMinimalValue(DiffuseGreen.Text, 0));
            settings.DiffuseColor[2] = Convert.ToByte(FormatingCheck.ValidateMinimalValue(DiffuseBlue.Text, 0));

            settings.reflection_intensity = Convert.ToDouble(FormatingCheck.ValidateStringNumber(textBox3.Text, 0));
            LoadSettings();
        }


        #region Textbox handlers
        private void Light1SpecRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(Light1SpecRed.Text, e);
        }

        private void Light1SpecGreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(Light1SpecGreen.Text, e);
        }

        private void Light1SpecBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(Light1SpecBlue.Text, e);
        }

        private void Light2SpecRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(Light2SpecRed.Text, e);
        }

        private void Light2SpecGreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(Light2SpecGreen.Text, e);
        }

        private void Light2SpecBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(Light2SpecBlue.Text, e);
        }

        private void Light3SpecRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(Light3SpecRed.Text, e);
        }

        private void Light3SpecGreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(Light3SpecGreen.Text, e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Angle textbox
            InputHandler.AngleInput(LensAngle.Text, e);
        }

        private void CamPosX_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(CamPosX.Text, e);
        }

        private void CamPosY_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(CamPosY.Text, e);
        }

        private void CamPosZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(CamPosZ.Text, e);
        }

        private void CamRotX_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(CamRotX.Text, e);
        }

        private void CamRotY_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(CamRotY.Text, e);
        }

        private void CamRotZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(CamRotZ.Text, e);
        }

        private void ProjectionDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInputNonNegative(ProjectionDistance.Text, e);
        }

        private void Light1PosX_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(Light1PosX.Text, e);
        }

        private void Light1PosY_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(Light1PosY.Text, e);
        }

        private void Light1PosZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(Light1PosZ.Text, e);
        }

        private void Light1Intensity_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInputNonNegative(Light1Intensity.Text, e);
        }

        private void Light2PosX_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(Light2PosX.Text, e);
        }

        private void Light2PosY_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(Light2PosY.Text, e);
        }

        private void Light2PosZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(Light2PosZ.Text, e);
        }

        private void Light2Intensity_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInputNonNegative(Light2Intensity.Text, e);
        }

        private void Light3PosX_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(Light3PosX.Text, e);
        }

        private void Light3PosY_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(Light3PosY.Text, e);
        }

        private void Light3PosZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInput(Light3PosZ.Text, e);
        }

        private void Light3Intensity_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInputNonNegative(Light3Intensity.Text, e);
        }

        private void ResolutionX_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ResolutionInput(ResolutionX.Text, e);
        }

        private void ResolutionY_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ResolutionInput(ResolutionY.Text, e);
        }

        private void PhongExponent_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInputNonNegative(PhongExponent.Text, e);
        }

        private void DiffuseRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(DiffuseRed.Text, e);
        }

        private void DiffuseGreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(DiffuseGreen.Text, e);
        }

        private void DiffuseBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(DiffuseBlue.Text, e);
        }
        #endregion

        #region Settings update handlers
        private void CamPosX_Leave(object sender, EventArgs e)
        {
            PushSettings();
        }
        #endregion

        private void CamPosY_Leave(object sender, EventArgs e)
        {
            PushSettings();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            MainRayTracer.ExportImage();
        }

        private void RenderButton_Click(object sender, EventArgs e)
        {
            settings.PushSettings(MainRayTracer.scene);
            MainRayTracer.Render();
            display_render();
        }

        private void display_render(){
            RenderWindow.Image = new Bitmap(MainRayTracer.image, new Size(Convert.ToInt32(Math.Max(MainRayTracer.image.Width * zoom,10)), Convert.ToInt32(Math.Max(MainRayTracer.image.Height * zoom,10))));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = MainRayTracer.LoadPrimitive();
            GeoInfo.Text = status;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.SampleInput(textBox2.Text, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.SampleInput(textBox1.Text, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.DoubleInputNonNegative(textBox3.Text, e);
        }

        private void Light3SpecBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputHandler.ColorInput(Light3SpecRed.Text, e);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value < 100)
            {
                trackBar1.Value = 100;
            }
            zoom = trackBar1.Value / 100;
            display_render();
        }
    }
}
