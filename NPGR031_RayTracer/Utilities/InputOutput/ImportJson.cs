using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPGR031_RayTracer.Utilities.GeometryRepresentation;
using NPGR031_RayTracer.Utilities.GeometryRepresentation.PrimitiveTypes;

using Newtonsoft.Json;
using System.Diagnostics;

namespace NPGR031_RayTracer.Utilities.InputOutput
{
    static class ImportJson
    {
        public static string LoadJsonDialog(PrimitiveMesh PrimMesh)
        {
            string fileContent;
            string filePath;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Json files (*.json) | *.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    LoadMesh(PrimMesh, fileContent);
                    return filePath;
                }
                else
                {
                    return "FAIL";
                }
            }
        }

        private static void LoadMesh(PrimitiveMesh PrimMesh, string FileContnet)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(FileContnet));

            string type = "";
            double pos_x = 0;
            double pos_y = 0;
            double pos_z = 0;
            double radius = 0;
            byte r = 0;
            byte g = 0;
            byte b = 0;
            double size_x = 0;
            double size_y = 0;
            double size_z = 0;

            while (reader.Read())
            {
                if(reader.Value != null)
                {
                    if(reader.TokenType == JsonToken.PropertyName)
                    {
                        if ((string)reader.Value == "Type")
                        {
                            reader.Read();
                            type = Convert.ToString(reader.Value);
                        }
                        else if((string)reader.Value == "PosX")
                        {
                            reader.Read();
                            pos_x = Convert.ToDouble(reader.Value);
                        }
                        else if ((string)reader.Value == "PosY")
                        {
                            reader.Read();
                            pos_y = Convert.ToDouble(reader.Value);
                        }
                        else if ((string)reader.Value == "PosZ")
                        {
                            reader.Read();
                            pos_z = Convert.ToDouble(reader.Value);
                        }
                        else if ((string)reader.Value == "Radius")
                        {
                            reader.Read();
                            radius = Convert.ToDouble(reader.Value);
                        }
                        else if ((string)reader.Value == "Red")
                        {
                            reader.Read();
                            r = Convert.ToByte(reader.Value);
                        }
                        else if ((string)reader.Value == "Green")
                        {
                            reader.Read();
                            g = Convert.ToByte(reader.Value);
                        }
                        else if ((string)reader.Value == "Blue")
                        {
                            reader.Read();
                            b = Convert.ToByte(reader.Value);
                        }
                        else if ((string)reader.Value == "SizeX")
                        {
                            reader.Read();
                            size_x = Convert.ToDouble(reader.Value);
                        }
                        else if ((string)reader.Value == "SizeY")
                        {
                            reader.Read();
                            size_y = Convert.ToDouble(reader.Value);
                        }
                        else if ((string)reader.Value == "SizeZ")
                        {
                            reader.Read();
                            size_z = Convert.ToDouble(reader.Value);
                        }
                    }

                }
                else
                {
                    if (reader.TokenType == JsonToken.EndObject)
                    {
                        if(type == "Sphere")
                        {
                            PrimMesh.Spheres.Add(new Sphere(pos_x, pos_y, pos_z, radius, r, g, b));
                        }
                        else if(type == "Cube")
                        {
                            PrimMesh.Cubes.Add(new Cube(pos_x, pos_y, pos_z, size_x, size_y, size_z, r, g, b));
                        }
                    }
                    else if(reader.TokenType == JsonToken.StartObject)
                    {
                        type = "";
                        pos_x = 0;
                        pos_y = 0;
                        pos_z = 0;
                        radius = 0;
                        size_x = 0;
                        size_y = 0;
                        size_z = 0;
                        r = 0;
                        g = 0;
                        b = 0;
                    }
                }
            }

        }

    }
}
