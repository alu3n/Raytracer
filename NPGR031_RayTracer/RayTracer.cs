using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPGR031_RayTracer.Render;

namespace NPGR031_RayTracer
{
    class RayTracer
    {
        public Scene.Scene scene = new Scene.Scene();
        public Bitmap image;

        public RayTracer()
        {
            image = new Bitmap(scene.ResolutionX, scene.ResolutionY);
        }

        public Bitmap Render()
        {
            image = Simulation.Render(scene);
            return image;
        }

        public string LoadPrimitive()
        {
            return scene.Geo.LoadPrimitive();
        }

        public void ExportImage()
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Title = "Save Image";
            dlgSave.Filter = "Bitmap Images (*.bmp)|*.bmp|All Files (*.*)|*.*";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                image.Save(dlgSave.FileName);
            }
        }
    }
}
