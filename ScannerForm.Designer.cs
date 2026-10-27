namespace Home_Appliance
{
    partial class ScannerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannerForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextBox_display = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_scan = new Guna.UI2.WinForms.Guna2Button();
            this.PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.comboBox_camera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_go = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.Button_copy = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextBox_display
            // 
            this.TextBox_display.BorderRadius = 18;
            this.TextBox_display.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_display.DefaultText = "";
            this.TextBox_display.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_display.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_display.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_display.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_display.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_display.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_display.ForeColor = System.Drawing.Color.DeepPink;
            this.TextBox_display.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_display.Location = new System.Drawing.Point(209, 514);
            this.TextBox_display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_display.Name = "TextBox_display";
            this.TextBox_display.PasswordChar = '\0';
            this.TextBox_display.PlaceholderForeColor = System.Drawing.Color.DeepPink;
            this.TextBox_display.PlaceholderText = "";
            this.TextBox_display.SelectedText = "";
            this.TextBox_display.Size = new System.Drawing.Size(385, 32);
            this.TextBox_display.TabIndex = 5;
            // 
            // Button_scan
            // 
            this.Button_scan.BorderRadius = 18;
            this.Button_scan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_scan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_scan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_scan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_scan.FillColor = System.Drawing.Color.Transparent;
            this.Button_scan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_scan.ForeColor = System.Drawing.Color.Black;
            this.Button_scan.Image = ((System.Drawing.Image)(resources.GetObject("Button_scan.Image")));
            this.Button_scan.ImageSize = new System.Drawing.Size(100, 100);
            this.Button_scan.Location = new System.Drawing.Point(267, 565);
            this.Button_scan.Name = "Button_scan";
            this.Button_scan.Size = new System.Drawing.Size(120, 119);
            this.Button_scan.TabIndex = 7;
            this.Button_scan.Click += new System.EventHandler(this.Button_scan_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.ImageRotate = 0F;
            this.PictureBox.Location = new System.Drawing.Point(209, 125);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(385, 327);
            this.PictureBox.TabIndex = 8;
            this.PictureBox.TabStop = false;
            // 
            // comboBox_camera
            // 
            this.comboBox_camera.ForeColor = System.Drawing.Color.DeepPink;
            this.comboBox_camera.FormattingEnabled = true;
            this.comboBox_camera.Items.AddRange(new object[] {
            "Web Cam Type"});
            this.comboBox_camera.Location = new System.Drawing.Point(377, 79);
            this.comboBox_camera.Name = "comboBox_camera";
            this.comboBox_camera.Size = new System.Drawing.Size(217, 24);
            this.comboBox_camera.TabIndex = 10;
            this.comboBox_camera.Text = "WEB CAM TYPE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(240, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "CAMERA";
            // 
            // Button_go
            // 
            this.Button_go.BorderRadius = 18;
            this.Button_go.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_go.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_go.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_go.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_go.FillColor = System.Drawing.Color.DeepPink;
            this.Button_go.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_go.ForeColor = System.Drawing.Color.Black;
            this.Button_go.Location = new System.Drawing.Point(209, 475);
            this.Button_go.Name = "Button_go";
            this.Button_go.Size = new System.Drawing.Size(132, 32);
            this.Button_go.TabIndex = 13;
            this.Button_go.Text = "Search";
            this.Button_go.Click += new System.EventHandler(this.Button_go_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 18;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(70, 70);
            this.guna2Button1.Location = new System.Drawing.Point(12, 26);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Size = new System.Drawing.Size(84, 77);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 18;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(100, 100);
            this.guna2Button2.Location = new System.Drawing.Point(429, 565);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(120, 119);
            this.guna2Button2.TabIndex = 17;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(622, -173);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(432, 429);
            this.guna2GradientCircleButton1.TabIndex = 18;
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(-229, 422);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(432, 429);
            this.guna2GradientCircleButton2.TabIndex = 19;
            // 
            // Button_copy
            // 
            this.Button_copy.BorderRadius = 18;
            this.Button_copy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_copy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_copy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_copy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_copy.FillColor = System.Drawing.Color.DeepPink;
            this.Button_copy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_copy.ForeColor = System.Drawing.Color.Black;
            this.Button_copy.Location = new System.Drawing.Point(611, 514);
            this.Button_copy.Name = "Button_copy";
            this.Button_copy.Size = new System.Drawing.Size(79, 32);
            this.Button_copy.TabIndex = 20;
            this.Button_copy.Text = "Copy";
            this.Button_copy.Click += new System.EventHandler(this.Button_copy_Click);
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(811, 686);
            this.Controls.Add(this.Button_copy);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Button_go);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_camera);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Button_scan);
            this.Controls.Add(this.TextBox_display);
            this.Name = "ScannerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScannerForm_FormClosing);
            this.Load += new System.EventHandler(this.ScannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_display;
        private Guna.UI2.WinForms.Guna2Button Button_scan;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox;
        private System.Windows.Forms.ComboBox comboBox_camera;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Button_go;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Guna.UI2.WinForms.Guna2Button Button_copy;
    }
}