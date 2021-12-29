using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPGR031_RayTracer
{
    static class Program
    {
        /* 
         * Program: RAYTRACER
         * Autor: Vojtech Proschl
         * Predmet: NPGR030
         * Popis: Zapoctovy program LS 2021
         * 
         */


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
