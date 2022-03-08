
namespace GroundControlGUI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accelerationBox = new System.Windows.Forms.TextBox();
            this.orientationBox = new System.Windows.Forms.TextBox();
            this.angvelocityBox = new System.Windows.Forms.TextBox();
            this.linearAccelBox = new System.Windows.Forms.TextBox();
            this.magnetometerBox = new System.Windows.Forms.TextBox();
            this.gravityBox = new System.Windows.Forms.TextBox();
            this.SI7021Groupbox = new System.Windows.Forms.GroupBox();
            this.SI7021TemperatureBox = new System.Windows.Forms.TextBox();
            this.SI7021HumidityBox = new System.Windows.Forms.TextBox();
            this.BMP085GroupBox = new System.Windows.Forms.GroupBox();
            this.BMP085PressureBox = new System.Windows.Forms.TextBox();
            this.BMP085AltitudeBox = new System.Windows.Forms.TextBox();
            this.FrontSensorsGroupBox = new System.Windows.Forms.GroupBox();
            this.FrontSensorTemperaturBox = new System.Windows.Forms.TextBox();
            this.FrontSensorMagnetismBox = new System.Windows.Forms.TextBox();
            this.FrontSensorDistanceBox = new System.Windows.Forms.TextBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SI7021Groupbox.SuspendLayout();
            this.BMP085GroupBox.SuspendLayout();
            this.FrontSensorsGroupBox.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gravityBox);
            this.groupBox1.Controls.Add(this.magnetometerBox);
            this.groupBox1.Controls.Add(this.linearAccelBox);
            this.groupBox1.Controls.Add(this.angvelocityBox);
            this.groupBox1.Controls.Add(this.orientationBox);
            this.groupBox1.Controls.Add(this.accelerationBox);
            this.groupBox1.Location = new System.Drawing.Point(38, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BNO055 IMU";
            // 
            // accelerationBox
            // 
            this.accelerationBox.Location = new System.Drawing.Point(6, 42);
            this.accelerationBox.Name = "accelerationBox";
            this.accelerationBox.ReadOnly = true;
            this.accelerationBox.Size = new System.Drawing.Size(100, 20);
            this.accelerationBox.TabIndex = 0;
            this.accelerationBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // orientationBox
            // 
            this.orientationBox.Location = new System.Drawing.Point(6, 79);
            this.orientationBox.Name = "orientationBox";
            this.orientationBox.ReadOnly = true;
            this.orientationBox.Size = new System.Drawing.Size(100, 20);
            this.orientationBox.TabIndex = 1;
            // 
            // angvelocityBox
            // 
            this.angvelocityBox.Location = new System.Drawing.Point(6, 120);
            this.angvelocityBox.Name = "angvelocityBox";
            this.angvelocityBox.ReadOnly = true;
            this.angvelocityBox.Size = new System.Drawing.Size(100, 20);
            this.angvelocityBox.TabIndex = 2;
            // 
            // linearAccelBox
            // 
            this.linearAccelBox.Location = new System.Drawing.Point(6, 157);
            this.linearAccelBox.Name = "linearAccelBox";
            this.linearAccelBox.ReadOnly = true;
            this.linearAccelBox.Size = new System.Drawing.Size(100, 20);
            this.linearAccelBox.TabIndex = 3;
            // 
            // magnetometerBox
            // 
            this.magnetometerBox.Location = new System.Drawing.Point(6, 199);
            this.magnetometerBox.Name = "magnetometerBox";
            this.magnetometerBox.ReadOnly = true;
            this.magnetometerBox.Size = new System.Drawing.Size(100, 20);
            this.magnetometerBox.TabIndex = 4;
            this.magnetometerBox.TextChanged += new System.EventHandler(this.magnetometerBox_TextChanged);
            // 
            // gravityBox
            // 
            this.gravityBox.Location = new System.Drawing.Point(6, 244);
            this.gravityBox.Name = "gravityBox";
            this.gravityBox.ReadOnly = true;
            this.gravityBox.Size = new System.Drawing.Size(100, 20);
            this.gravityBox.TabIndex = 5;
            // 
            // SI7021Groupbox
            // 
            this.SI7021Groupbox.Controls.Add(this.SI7021HumidityBox);
            this.SI7021Groupbox.Controls.Add(this.SI7021TemperatureBox);
            this.SI7021Groupbox.Location = new System.Drawing.Point(38, 378);
            this.SI7021Groupbox.Name = "SI7021Groupbox";
            this.SI7021Groupbox.Size = new System.Drawing.Size(200, 120);
            this.SI7021Groupbox.TabIndex = 2;
            this.SI7021Groupbox.TabStop = false;
            this.SI7021Groupbox.Text = "SI7021";
            // 
            // SI7021TemperatureBox
            // 
            this.SI7021TemperatureBox.Location = new System.Drawing.Point(15, 28);
            this.SI7021TemperatureBox.Name = "SI7021TemperatureBox";
            this.SI7021TemperatureBox.Size = new System.Drawing.Size(100, 20);
            this.SI7021TemperatureBox.TabIndex = 6;
            // 
            // SI7021HumidityBox
            // 
            this.SI7021HumidityBox.Location = new System.Drawing.Point(15, 63);
            this.SI7021HumidityBox.Name = "SI7021HumidityBox";
            this.SI7021HumidityBox.Size = new System.Drawing.Size(100, 20);
            this.SI7021HumidityBox.TabIndex = 7;
            // 
            // BMP085GroupBox
            // 
            this.BMP085GroupBox.Controls.Add(this.BMP085AltitudeBox);
            this.BMP085GroupBox.Controls.Add(this.BMP085PressureBox);
            this.BMP085GroupBox.Location = new System.Drawing.Point(256, 226);
            this.BMP085GroupBox.Name = "BMP085GroupBox";
            this.BMP085GroupBox.Size = new System.Drawing.Size(200, 120);
            this.BMP085GroupBox.TabIndex = 3;
            this.BMP085GroupBox.TabStop = false;
            this.BMP085GroupBox.Text = "BMP085";
            // 
            // BMP085PressureBox
            // 
            this.BMP085PressureBox.Location = new System.Drawing.Point(6, 34);
            this.BMP085PressureBox.Name = "BMP085PressureBox";
            this.BMP085PressureBox.Size = new System.Drawing.Size(100, 20);
            this.BMP085PressureBox.TabIndex = 7;
            // 
            // BMP085AltitudeBox
            // 
            this.BMP085AltitudeBox.Location = new System.Drawing.Point(6, 60);
            this.BMP085AltitudeBox.Name = "BMP085AltitudeBox";
            this.BMP085AltitudeBox.Size = new System.Drawing.Size(100, 20);
            this.BMP085AltitudeBox.TabIndex = 8;
            // 
            // FrontSensorsGroupBox
            // 
            this.FrontSensorsGroupBox.Controls.Add(this.FrontSensorDistanceBox);
            this.FrontSensorsGroupBox.Controls.Add(this.FrontSensorMagnetismBox);
            this.FrontSensorsGroupBox.Controls.Add(this.FrontSensorTemperaturBox);
            this.FrontSensorsGroupBox.Location = new System.Drawing.Point(256, 32);
            this.FrontSensorsGroupBox.Name = "FrontSensorsGroupBox";
            this.FrontSensorsGroupBox.Size = new System.Drawing.Size(200, 159);
            this.FrontSensorsGroupBox.TabIndex = 4;
            this.FrontSensorsGroupBox.TabStop = false;
            this.FrontSensorsGroupBox.Text = "Front Sensors";
            // 
            // FrontSensorTemperaturBox
            // 
            this.FrontSensorTemperaturBox.Location = new System.Drawing.Point(6, 26);
            this.FrontSensorTemperaturBox.Name = "FrontSensorTemperaturBox";
            this.FrontSensorTemperaturBox.Size = new System.Drawing.Size(100, 20);
            this.FrontSensorTemperaturBox.TabIndex = 8;
            // 
            // FrontSensorMagnetismBox
            // 
            this.FrontSensorMagnetismBox.Location = new System.Drawing.Point(6, 58);
            this.FrontSensorMagnetismBox.Name = "FrontSensorMagnetismBox";
            this.FrontSensorMagnetismBox.Size = new System.Drawing.Size(100, 20);
            this.FrontSensorMagnetismBox.TabIndex = 9;
            // 
            // FrontSensorDistanceBox
            // 
            this.FrontSensorDistanceBox.Location = new System.Drawing.Point(6, 92);
            this.FrontSensorDistanceBox.Name = "FrontSensorDistanceBox";
            this.FrontSensorDistanceBox.Size = new System.Drawing.Size(100, 20);
            this.FrontSensorDistanceBox.TabIndex = 10;
            // 
            // TimeGroupBox
            // 
            this.TimeGroupBox.Controls.Add(this.timeBox);
            this.TimeGroupBox.Location = new System.Drawing.Point(262, 383);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(194, 78);
            this.TimeGroupBox.TabIndex = 5;
            this.TimeGroupBox.TabStop = false;
            this.TimeGroupBox.Text = "Time";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(6, 33);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 20);
            this.timeBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 539);
            this.Controls.Add(this.TimeGroupBox);
            this.Controls.Add(this.FrontSensorsGroupBox);
            this.Controls.Add(this.BMP085GroupBox);
            this.Controls.Add(this.SI7021Groupbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ground Control GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SI7021Groupbox.ResumeLayout(false);
            this.SI7021Groupbox.PerformLayout();
            this.BMP085GroupBox.ResumeLayout(false);
            this.BMP085GroupBox.PerformLayout();
            this.FrontSensorsGroupBox.ResumeLayout(false);
            this.FrontSensorsGroupBox.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox accelerationBox;
        private System.Windows.Forms.TextBox gravityBox;
        private System.Windows.Forms.TextBox magnetometerBox;
        private System.Windows.Forms.TextBox linearAccelBox;
        private System.Windows.Forms.TextBox angvelocityBox;
        private System.Windows.Forms.TextBox orientationBox;
        private System.Windows.Forms.GroupBox SI7021Groupbox;
        private System.Windows.Forms.TextBox SI7021HumidityBox;
        private System.Windows.Forms.TextBox SI7021TemperatureBox;
        private System.Windows.Forms.GroupBox BMP085GroupBox;
        private System.Windows.Forms.TextBox BMP085AltitudeBox;
        private System.Windows.Forms.TextBox BMP085PressureBox;
        private System.Windows.Forms.GroupBox FrontSensorsGroupBox;
        private System.Windows.Forms.TextBox FrontSensorDistanceBox;
        private System.Windows.Forms.TextBox FrontSensorMagnetismBox;
        private System.Windows.Forms.TextBox FrontSensorTemperaturBox;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.TextBox timeBox;
    }
}

