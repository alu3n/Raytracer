
namespace NPGR031_RayTracer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RenderButton = new System.Windows.Forms.Button();
            this.GeoInfo = new System.Windows.Forms.TextBox();
            this.CamPosX = new System.Windows.Forms.TextBox();
            this.CamPosY = new System.Windows.Forms.TextBox();
            this.CamPosZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CamRotZ = new System.Windows.Forms.TextBox();
            this.CamRotY = new System.Windows.Forms.TextBox();
            this.CamRotX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Light1Intensity = new System.Windows.Forms.TextBox();
            this.ProjectionDistance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LensAngle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Light1PosZ = new System.Windows.Forms.TextBox();
            this.Light1PosY = new System.Windows.Forms.TextBox();
            this.Light1PosX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Light1SpecBlue = new System.Windows.Forms.TextBox();
            this.Light1SpecGreen = new System.Windows.Forms.TextBox();
            this.Light1SpecRed = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Light2SpecBlue = new System.Windows.Forms.TextBox();
            this.Light2SpecGreen = new System.Windows.Forms.TextBox();
            this.Light2SpecRed = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Light2PosZ = new System.Windows.Forms.TextBox();
            this.Light2PosY = new System.Windows.Forms.TextBox();
            this.Light2PosX = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Light2Intensity = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.Light3SpecBlue = new System.Windows.Forms.TextBox();
            this.Light3SpecGreen = new System.Windows.Forms.TextBox();
            this.Light3SpecRed = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.Light3PosZ = new System.Windows.Forms.TextBox();
            this.Light3PosY = new System.Windows.Forms.TextBox();
            this.Light3PosX = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.Light3Intensity = new System.Windows.Forms.TextBox();
            this.ResolutionX = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.ResolutionY = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.DiffuseBlue = new System.Windows.Forms.TextBox();
            this.DiffuseGreen = new System.Windows.Forms.TextBox();
            this.DiffuseRed = new System.Windows.Forms.TextBox();
            this.PhongExponent = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.RenderWindow = new System.Windows.Forms.PictureBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.RenderWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // RenderButton
            // 
            this.RenderButton.Location = new System.Drawing.Point(21, 1544);
            this.RenderButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(255, 104);
            this.RenderButton.TabIndex = 0;
            this.RenderButton.Text = "Render";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // GeoInfo
            // 
            this.GeoInfo.Location = new System.Drawing.Point(1317, 1602);
            this.GeoInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GeoInfo.Name = "GeoInfo";
            this.GeoInfo.ReadOnly = true;
            this.GeoInfo.Size = new System.Drawing.Size(532, 35);
            this.GeoInfo.TabIndex = 3;
            // 
            // CamPosX
            // 
            this.CamPosX.Location = new System.Drawing.Point(1317, 88);
            this.CamPosX.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CamPosX.Name = "CamPosX";
            this.CamPosX.Size = new System.Drawing.Size(169, 35);
            this.CamPosX.TabIndex = 4;
            this.CamPosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamPosX_KeyPress);
            this.CamPosX.Leave += new System.EventHandler(this.CamPosX_Leave);
            // 
            // CamPosY
            // 
            this.CamPosY.Location = new System.Drawing.Point(1498, 88);
            this.CamPosY.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CamPosY.Name = "CamPosY";
            this.CamPosY.Size = new System.Drawing.Size(169, 35);
            this.CamPosY.TabIndex = 5;
            this.CamPosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamPosY_KeyPress);
            this.CamPosY.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // CamPosZ
            // 
            this.CamPosZ.Location = new System.Drawing.Point(1680, 88);
            this.CamPosZ.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CamPosZ.Name = "CamPosZ";
            this.CamPosZ.Size = new System.Drawing.Size(169, 35);
            this.CamPosZ.TabIndex = 6;
            this.CamPosZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamPosZ_KeyPress);
            this.CamPosZ.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1344, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Position X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1349, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rotation X";
            // 
            // CamRotZ
            // 
            this.CamRotZ.Location = new System.Drawing.Point(1680, 176);
            this.CamRotZ.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CamRotZ.Name = "CamRotZ";
            this.CamRotZ.Size = new System.Drawing.Size(169, 35);
            this.CamRotZ.TabIndex = 10;
            this.CamRotZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamRotZ_KeyPress);
            this.CamRotZ.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // CamRotY
            // 
            this.CamRotY.Location = new System.Drawing.Point(1498, 176);
            this.CamRotY.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CamRotY.Name = "CamRotY";
            this.CamRotY.Size = new System.Drawing.Size(169, 35);
            this.CamRotY.TabIndex = 9;
            this.CamRotY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamRotY_KeyPress);
            this.CamRotY.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // CamRotX
            // 
            this.CamRotX.Location = new System.Drawing.Point(1317, 176);
            this.CamRotX.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CamRotX.Name = "CamRotX";
            this.CamRotX.Size = new System.Drawing.Size(169, 35);
            this.CamRotX.TabIndex = 8;
            this.CamRotX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamRotX_KeyPress);
            this.CamRotX.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1392, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lens Angle";
            // 
            // Light1Intensity
            // 
            this.Light1Intensity.Location = new System.Drawing.Point(1317, 590);
            this.Light1Intensity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light1Intensity.Name = "Light1Intensity";
            this.Light1Intensity.Size = new System.Drawing.Size(169, 35);
            this.Light1Intensity.TabIndex = 14;
            this.Light1Intensity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light1Intensity_KeyPress);
            this.Light1Intensity.Leave += new System.EventHandler(this.CamPosX_Leave);
            // 
            // ProjectionDistance
            // 
            this.ProjectionDistance.Location = new System.Drawing.Point(1594, 266);
            this.ProjectionDistance.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ProjectionDistance.Name = "ProjectionDistance";
            this.ProjectionDistance.Size = new System.Drawing.Size(254, 35);
            this.ProjectionDistance.TabIndex = 13;
            this.ProjectionDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProjectionDistance_KeyPress);
            this.ProjectionDistance.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1627, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Projection Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1526, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Position Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1707, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Position Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1527, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rotation Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1709, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 30);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rotation Z";
            // 
            // LensAngle
            // 
            this.LensAngle.Location = new System.Drawing.Point(1317, 266);
            this.LensAngle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LensAngle.Name = "LensAngle";
            this.LensAngle.Size = new System.Drawing.Size(254, 35);
            this.LensAngle.TabIndex = 21;
            this.LensAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            this.LensAngle.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1464, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 38);
            this.label9.TabIndex = 22;
            this.label9.Text = "Camera Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1476, 318);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 38);
            this.label10.TabIndex = 23;
            this.label10.Text = "Light 1 Settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1707, 372);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 30);
            this.label11.TabIndex = 29;
            this.label11.Text = "Position Z";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1526, 372);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 30);
            this.label12.TabIndex = 28;
            this.label12.Text = "Position Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1344, 372);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 30);
            this.label13.TabIndex = 27;
            this.label13.Text = "Position X";
            // 
            // Light1PosZ
            // 
            this.Light1PosZ.Location = new System.Drawing.Point(1680, 408);
            this.Light1PosZ.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light1PosZ.Name = "Light1PosZ";
            this.Light1PosZ.Size = new System.Drawing.Size(169, 35);
            this.Light1PosZ.TabIndex = 26;
            this.Light1PosZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light1PosZ_KeyPress);
            this.Light1PosZ.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light1PosY
            // 
            this.Light1PosY.Location = new System.Drawing.Point(1498, 408);
            this.Light1PosY.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light1PosY.Name = "Light1PosY";
            this.Light1PosY.Size = new System.Drawing.Size(169, 35);
            this.Light1PosY.TabIndex = 25;
            this.Light1PosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light1PosY_KeyPress);
            this.Light1PosY.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light1PosX
            // 
            this.Light1PosX.Location = new System.Drawing.Point(1317, 408);
            this.Light1PosX.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light1PosX.Name = "Light1PosX";
            this.Light1PosX.Size = new System.Drawing.Size(169, 35);
            this.Light1PosX.TabIndex = 24;
            this.Light1PosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light1PosX_KeyPress);
            this.Light1PosX.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1697, 462);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 30);
            this.label14.TabIndex = 35;
            this.label14.Text = "Specular Blue";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1510, 462);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 30);
            this.label15.TabIndex = 34;
            this.label15.Text = "Specular Green";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1337, 462);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 30);
            this.label16.TabIndex = 33;
            this.label16.Text = "Specular Red";
            // 
            // Light1SpecBlue
            // 
            this.Light1SpecBlue.Location = new System.Drawing.Point(1680, 498);
            this.Light1SpecBlue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light1SpecBlue.Name = "Light1SpecBlue";
            this.Light1SpecBlue.Size = new System.Drawing.Size(169, 35);
            this.Light1SpecBlue.TabIndex = 32;
            this.Light1SpecBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light1SpecBlue_KeyPress);
            this.Light1SpecBlue.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light1SpecGreen
            // 
            this.Light1SpecGreen.Location = new System.Drawing.Point(1498, 498);
            this.Light1SpecGreen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light1SpecGreen.Name = "Light1SpecGreen";
            this.Light1SpecGreen.Size = new System.Drawing.Size(169, 35);
            this.Light1SpecGreen.TabIndex = 31;
            this.Light1SpecGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light1SpecGreen_KeyPress);
            this.Light1SpecGreen.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light1SpecRed
            // 
            this.Light1SpecRed.Location = new System.Drawing.Point(1317, 498);
            this.Light1SpecRed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light1SpecRed.Name = "Light1SpecRed";
            this.Light1SpecRed.Size = new System.Drawing.Size(169, 35);
            this.Light1SpecRed.TabIndex = 30;
            this.Light1SpecRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light1SpecRed_KeyPress);
            this.Light1SpecRed.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1353, 554);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 30);
            this.label17.TabIndex = 36;
            this.label17.Text = "Intensity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1353, 880);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 30);
            this.label18.TabIndex = 51;
            this.label18.Text = "Intensity";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1697, 788);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 30);
            this.label19.TabIndex = 50;
            this.label19.Text = "Specular Blue";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1510, 788);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 30);
            this.label20.TabIndex = 49;
            this.label20.Text = "Specular Green";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1337, 788);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 30);
            this.label21.TabIndex = 48;
            this.label21.Text = "Specular Red";
            // 
            // Light2SpecBlue
            // 
            this.Light2SpecBlue.Location = new System.Drawing.Point(1680, 824);
            this.Light2SpecBlue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light2SpecBlue.Name = "Light2SpecBlue";
            this.Light2SpecBlue.Size = new System.Drawing.Size(169, 35);
            this.Light2SpecBlue.TabIndex = 47;
            this.Light2SpecBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light2SpecBlue_KeyPress);
            this.Light2SpecBlue.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light2SpecGreen
            // 
            this.Light2SpecGreen.Location = new System.Drawing.Point(1498, 824);
            this.Light2SpecGreen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light2SpecGreen.Name = "Light2SpecGreen";
            this.Light2SpecGreen.Size = new System.Drawing.Size(169, 35);
            this.Light2SpecGreen.TabIndex = 46;
            this.Light2SpecGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light2SpecGreen_KeyPress);
            this.Light2SpecGreen.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light2SpecRed
            // 
            this.Light2SpecRed.Location = new System.Drawing.Point(1317, 824);
            this.Light2SpecRed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light2SpecRed.Name = "Light2SpecRed";
            this.Light2SpecRed.Size = new System.Drawing.Size(169, 35);
            this.Light2SpecRed.TabIndex = 45;
            this.Light2SpecRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light2SpecRed_KeyPress);
            this.Light2SpecRed.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1707, 698);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 30);
            this.label22.TabIndex = 44;
            this.label22.Text = "Position Z";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1526, 698);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 30);
            this.label23.TabIndex = 43;
            this.label23.Text = "Position Y";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1344, 698);
            this.label24.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 30);
            this.label24.TabIndex = 42;
            this.label24.Text = "Position X";
            // 
            // Light2PosZ
            // 
            this.Light2PosZ.Location = new System.Drawing.Point(1680, 734);
            this.Light2PosZ.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light2PosZ.Name = "Light2PosZ";
            this.Light2PosZ.Size = new System.Drawing.Size(169, 35);
            this.Light2PosZ.TabIndex = 41;
            this.Light2PosZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light2PosZ_KeyPress);
            this.Light2PosZ.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light2PosY
            // 
            this.Light2PosY.Location = new System.Drawing.Point(1498, 734);
            this.Light2PosY.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light2PosY.Name = "Light2PosY";
            this.Light2PosY.Size = new System.Drawing.Size(169, 35);
            this.Light2PosY.TabIndex = 40;
            this.Light2PosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light2PosY_KeyPress);
            this.Light2PosY.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light2PosX
            // 
            this.Light2PosX.Location = new System.Drawing.Point(1317, 734);
            this.Light2PosX.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light2PosX.Name = "Light2PosX";
            this.Light2PosX.Size = new System.Drawing.Size(169, 35);
            this.Light2PosX.TabIndex = 39;
            this.Light2PosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light2PosX_KeyPress);
            this.Light2PosX.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(1476, 644);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(208, 38);
            this.label25.TabIndex = 38;
            this.label25.Text = "Light 2 Settings";
            // 
            // Light2Intensity
            // 
            this.Light2Intensity.Location = new System.Drawing.Point(1317, 916);
            this.Light2Intensity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light2Intensity.Name = "Light2Intensity";
            this.Light2Intensity.Size = new System.Drawing.Size(169, 35);
            this.Light2Intensity.TabIndex = 37;
            this.Light2Intensity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light2Intensity_KeyPress);
            this.Light2Intensity.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1353, 1208);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 30);
            this.label26.TabIndex = 66;
            this.label26.Text = "Intensity";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1697, 1116);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(138, 30);
            this.label27.TabIndex = 65;
            this.label27.Text = "Specular Blue";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1510, 1116);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(153, 30);
            this.label28.TabIndex = 64;
            this.label28.Text = "Specular Green";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(1337, 1116);
            this.label29.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(133, 30);
            this.label29.TabIndex = 63;
            this.label29.Text = "Specular Red";
            // 
            // Light3SpecBlue
            // 
            this.Light3SpecBlue.Location = new System.Drawing.Point(1680, 1152);
            this.Light3SpecBlue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light3SpecBlue.Name = "Light3SpecBlue";
            this.Light3SpecBlue.Size = new System.Drawing.Size(169, 35);
            this.Light3SpecBlue.TabIndex = 62;
            this.Light3SpecBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light3SpecBlue_KeyPress);
            this.Light3SpecBlue.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light3SpecGreen
            // 
            this.Light3SpecGreen.Location = new System.Drawing.Point(1498, 1152);
            this.Light3SpecGreen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light3SpecGreen.Name = "Light3SpecGreen";
            this.Light3SpecGreen.Size = new System.Drawing.Size(169, 35);
            this.Light3SpecGreen.TabIndex = 61;
            this.Light3SpecGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light3SpecGreen_KeyPress);
            this.Light3SpecGreen.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light3SpecRed
            // 
            this.Light3SpecRed.Location = new System.Drawing.Point(1317, 1152);
            this.Light3SpecRed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light3SpecRed.Name = "Light3SpecRed";
            this.Light3SpecRed.Size = new System.Drawing.Size(169, 35);
            this.Light3SpecRed.TabIndex = 60;
            this.Light3SpecRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light3SpecRed_KeyPress);
            this.Light3SpecRed.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(1707, 1026);
            this.label30.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 30);
            this.label30.TabIndex = 59;
            this.label30.Text = "Position Z";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(1526, 1026);
            this.label31.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(104, 30);
            this.label31.TabIndex = 58;
            this.label31.Text = "Position Y";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(1344, 1026);
            this.label32.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(104, 30);
            this.label32.TabIndex = 57;
            this.label32.Text = "Position X";
            // 
            // Light3PosZ
            // 
            this.Light3PosZ.Location = new System.Drawing.Point(1680, 1062);
            this.Light3PosZ.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light3PosZ.Name = "Light3PosZ";
            this.Light3PosZ.Size = new System.Drawing.Size(169, 35);
            this.Light3PosZ.TabIndex = 56;
            this.Light3PosZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light3PosZ_KeyPress);
            this.Light3PosZ.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light3PosY
            // 
            this.Light3PosY.Location = new System.Drawing.Point(1498, 1062);
            this.Light3PosY.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light3PosY.Name = "Light3PosY";
            this.Light3PosY.Size = new System.Drawing.Size(169, 35);
            this.Light3PosY.TabIndex = 55;
            this.Light3PosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light3PosY_KeyPress);
            this.Light3PosY.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // Light3PosX
            // 
            this.Light3PosX.Location = new System.Drawing.Point(1317, 1062);
            this.Light3PosX.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light3PosX.Name = "Light3PosX";
            this.Light3PosX.Size = new System.Drawing.Size(169, 35);
            this.Light3PosX.TabIndex = 54;
            this.Light3PosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light3PosX_KeyPress);
            this.Light3PosX.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(1476, 972);
            this.label33.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(208, 38);
            this.label33.TabIndex = 53;
            this.label33.Text = "Light 3 Settings";
            // 
            // Light3Intensity
            // 
            this.Light3Intensity.Location = new System.Drawing.Point(1317, 1244);
            this.Light3Intensity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Light3Intensity.Name = "Light3Intensity";
            this.Light3Intensity.Size = new System.Drawing.Size(169, 35);
            this.Light3Intensity.TabIndex = 52;
            this.Light3Intensity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Light3Intensity_KeyPress);
            this.Light3Intensity.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // ResolutionX
            // 
            this.ResolutionX.Location = new System.Drawing.Point(1317, 1384);
            this.ResolutionX.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ResolutionX.Name = "ResolutionX";
            this.ResolutionX.Size = new System.Drawing.Size(169, 35);
            this.ResolutionX.TabIndex = 70;
            this.ResolutionX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResolutionX_KeyPress);
            this.ResolutionX.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(1526, 1348);
            this.label34.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(128, 30);
            this.label34.TabIndex = 69;
            this.label34.Text = "Resolution Y";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(1337, 1348);
            this.label35.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(128, 30);
            this.label35.TabIndex = 68;
            this.label35.Text = "Resolution X";
            // 
            // ResolutionY
            // 
            this.ResolutionY.Location = new System.Drawing.Point(1498, 1384);
            this.ResolutionY.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ResolutionY.Name = "ResolutionY";
            this.ResolutionY.Size = new System.Drawing.Size(169, 35);
            this.ResolutionY.TabIndex = 67;
            this.ResolutionY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResolutionY_KeyPress);
            this.ResolutionY.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label36.Location = new System.Drawing.Point(1476, 1296);
            this.label36.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(212, 38);
            this.label36.TabIndex = 71;
            this.label36.Text = "Render Settings";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(1680, 1442);
            this.label37.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(169, 30);
            this.label37.TabIndex = 77;
            this.label37.Text = "Background Blue";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(1495, 1442);
            this.label38.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(184, 30);
            this.label38.TabIndex = 76;
            this.label38.Text = "Background Green";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(1322, 1442);
            this.label39.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(164, 30);
            this.label39.TabIndex = 75;
            this.label39.Text = "Background Red";
            // 
            // DiffuseBlue
            // 
            this.DiffuseBlue.Location = new System.Drawing.Point(1680, 1478);
            this.DiffuseBlue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DiffuseBlue.Name = "DiffuseBlue";
            this.DiffuseBlue.Size = new System.Drawing.Size(169, 35);
            this.DiffuseBlue.TabIndex = 74;
            this.DiffuseBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiffuseBlue_KeyPress);
            this.DiffuseBlue.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // DiffuseGreen
            // 
            this.DiffuseGreen.Location = new System.Drawing.Point(1498, 1478);
            this.DiffuseGreen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DiffuseGreen.Name = "DiffuseGreen";
            this.DiffuseGreen.Size = new System.Drawing.Size(169, 35);
            this.DiffuseGreen.TabIndex = 73;
            this.DiffuseGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiffuseGreen_KeyPress);
            this.DiffuseGreen.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // DiffuseRed
            // 
            this.DiffuseRed.Location = new System.Drawing.Point(1317, 1478);
            this.DiffuseRed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DiffuseRed.Name = "DiffuseRed";
            this.DiffuseRed.Size = new System.Drawing.Size(169, 35);
            this.DiffuseRed.TabIndex = 72;
            this.DiffuseRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiffuseRed_KeyPress);
            this.DiffuseRed.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // PhongExponent
            // 
            this.PhongExponent.Location = new System.Drawing.Point(1680, 1382);
            this.PhongExponent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PhongExponent.Name = "PhongExponent";
            this.PhongExponent.Size = new System.Drawing.Size(169, 35);
            this.PhongExponent.TabIndex = 78;
            this.PhongExponent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhongExponent_KeyPress);
            this.PhongExponent.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(1689, 1348);
            this.label40.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(166, 30);
            this.label40.TabIndex = 79;
            this.label40.Text = "Phong Exponent";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(286, 1544);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(255, 104);
            this.ExportButton.TabIndex = 85;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1317, 1536);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(535, 54);
            this.button1.TabIndex = 86;
            this.button1.Text = "Load Primitives";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1135, 1602);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 35);
            this.textBox1.TabIndex = 87;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(953, 1602);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 35);
            this.textBox2.TabIndex = 88;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1155, 1560);
            this.label41.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(124, 30);
            this.label41.TabIndex = 89;
            this.label41.Text = "Sample Size";
            // 
            // RenderWindow
            // 
            this.RenderWindow.Location = new System.Drawing.Point(21, 24);
            this.RenderWindow.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RenderWindow.Name = "RenderWindow";
            this.RenderWindow.Size = new System.Drawing.Size(1286, 1500);
            this.RenderWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RenderWindow.TabIndex = 2;
            this.RenderWindow.TabStop = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(984, 1566);
            this.label42.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(109, 30);
            this.label42.TabIndex = 90;
            this.label42.Text = "Ray Count";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(763, 1566);
            this.label43.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(189, 30);
            this.label43.TabIndex = 92;
            this.label43.Text = "Reflection intensity";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(771, 1602);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 35);
            this.textBox3.TabIndex = 91;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.CamPosY_Leave);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(551, 1577);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(209, 80);
            this.trackBar1.TabIndex = 93;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 1672);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.PhongExponent);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.DiffuseBlue);
            this.Controls.Add(this.DiffuseGreen);
            this.Controls.Add(this.DiffuseRed);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.ResolutionX);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.ResolutionY);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.Light3SpecBlue);
            this.Controls.Add(this.Light3SpecGreen);
            this.Controls.Add(this.Light3SpecRed);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.Light3PosZ);
            this.Controls.Add(this.Light3PosY);
            this.Controls.Add(this.Light3PosX);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.Light3Intensity);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Light2SpecBlue);
            this.Controls.Add(this.Light2SpecGreen);
            this.Controls.Add(this.Light2SpecRed);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.Light2PosZ);
            this.Controls.Add(this.Light2PosY);
            this.Controls.Add(this.Light2PosX);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.Light2Intensity);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Light1SpecBlue);
            this.Controls.Add(this.Light1SpecGreen);
            this.Controls.Add(this.Light1SpecRed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Light1PosZ);
            this.Controls.Add(this.Light1PosY);
            this.Controls.Add(this.Light1PosX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LensAngle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Light1Intensity);
            this.Controls.Add(this.ProjectionDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CamRotZ);
            this.Controls.Add(this.CamRotY);
            this.Controls.Add(this.CamRotX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CamPosZ);
            this.Controls.Add(this.CamPosY);
            this.Controls.Add(this.CamPosX);
            this.Controls.Add(this.GeoInfo);
            this.Controls.Add(this.RenderWindow);
            this.Controls.Add(this.RenderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main";
            this.Text = "RayTracer";
            ((System.ComponentModel.ISupportInitialize)(this.RenderWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.TextBox GeoInfo;
        private System.Windows.Forms.TextBox CamPosX;
        private System.Windows.Forms.TextBox CamPosY;
        private System.Windows.Forms.TextBox CamPosZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CamRotZ;
        private System.Windows.Forms.TextBox CamRotY;
        private System.Windows.Forms.TextBox CamRotX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Light1Intensity;
        private System.Windows.Forms.TextBox ProjectionDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LensAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Light1PosZ;
        private System.Windows.Forms.TextBox Light1PosY;
        private System.Windows.Forms.TextBox Light1PosX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Light1SpecBlue;
        private System.Windows.Forms.TextBox Light1SpecGreen;
        private System.Windows.Forms.TextBox Light1SpecRed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Light2SpecBlue;
        private System.Windows.Forms.TextBox Light2SpecGreen;
        private System.Windows.Forms.TextBox Light2SpecRed;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox Light2PosZ;
        private System.Windows.Forms.TextBox Light2PosY;
        private System.Windows.Forms.TextBox Light2PosX;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Light2Intensity;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox Light3SpecBlue;
        private System.Windows.Forms.TextBox Light3SpecGreen;
        private System.Windows.Forms.TextBox Light3SpecRed;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox Light3PosZ;
        private System.Windows.Forms.TextBox Light3PosY;
        private System.Windows.Forms.TextBox Light3PosX;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox Light3Intensity;
        private System.Windows.Forms.TextBox ResolutionX;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox ResolutionY;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox DiffuseBlue;
        private System.Windows.Forms.TextBox DiffuseGreen;
        private System.Windows.Forms.TextBox DiffuseRed;
        private System.Windows.Forms.TextBox PhongExponent;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.PictureBox RenderWindow;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

