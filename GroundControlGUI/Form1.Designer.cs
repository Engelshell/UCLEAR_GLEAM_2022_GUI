
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gravityBox = new System.Windows.Forms.TextBox();
            this.magnetometerBox = new System.Windows.Forms.TextBox();
            this.linearAccelBox = new System.Windows.Forms.TextBox();
            this.angvelocityBox = new System.Windows.Forms.TextBox();
            this.orientationBox = new System.Windows.Forms.TextBox();
            this.accelerationBox = new System.Windows.Forms.TextBox();
            this.SI7021Groupbox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SI7021HumidityBox = new System.Windows.Forms.TextBox();
            this.SI7021TemperatureBox = new System.Windows.Forms.TextBox();
            this.BMP085GroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BMP085AltitudeBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BMP085PressureBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.serialPortComboBox = new System.Windows.Forms.ComboBox();
            this.serialPortLabel = new System.Windows.Forms.Label();
            this.serialOpenButton = new System.Windows.Forms.Button();
            this.serialCloseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serialBaudRateLabel = new System.Windows.Forms.Label();
            this.serialBaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.serialErrorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SI7021Groupbox.SuspendLayout();
            this.BMP085GroupBox.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gravityBox);
            this.groupBox1.Controls.Add(this.magnetometerBox);
            this.groupBox1.Controls.Add(this.linearAccelBox);
            this.groupBox1.Controls.Add(this.angvelocityBox);
            this.groupBox1.Controls.Add(this.orientationBox);
            this.groupBox1.Controls.Add(this.accelerationBox);
            this.groupBox1.Location = new System.Drawing.Point(51, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(346, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BNO055 IMU";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Gravity";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Magnetometer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "linearAccel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "angVelocity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Orientation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Acceleration";
            // 
            // gravityBox
            // 
            this.gravityBox.Location = new System.Drawing.Point(8, 300);
            this.gravityBox.Margin = new System.Windows.Forms.Padding(4);
            this.gravityBox.Name = "gravityBox";
            this.gravityBox.ReadOnly = true;
            this.gravityBox.Size = new System.Drawing.Size(157, 22);
            this.gravityBox.TabIndex = 5;
            // 
            // magnetometerBox
            // 
            this.magnetometerBox.Location = new System.Drawing.Point(8, 245);
            this.magnetometerBox.Margin = new System.Windows.Forms.Padding(4);
            this.magnetometerBox.Name = "magnetometerBox";
            this.magnetometerBox.ReadOnly = true;
            this.magnetometerBox.Size = new System.Drawing.Size(157, 22);
            this.magnetometerBox.TabIndex = 4;
            this.magnetometerBox.TextChanged += new System.EventHandler(this.magnetometerBox_TextChanged);
            // 
            // linearAccelBox
            // 
            this.linearAccelBox.Location = new System.Drawing.Point(8, 193);
            this.linearAccelBox.Margin = new System.Windows.Forms.Padding(4);
            this.linearAccelBox.Name = "linearAccelBox";
            this.linearAccelBox.ReadOnly = true;
            this.linearAccelBox.Size = new System.Drawing.Size(157, 22);
            this.linearAccelBox.TabIndex = 3;
            // 
            // angvelocityBox
            // 
            this.angvelocityBox.Location = new System.Drawing.Point(8, 148);
            this.angvelocityBox.Margin = new System.Windows.Forms.Padding(4);
            this.angvelocityBox.Name = "angvelocityBox";
            this.angvelocityBox.ReadOnly = true;
            this.angvelocityBox.Size = new System.Drawing.Size(159, 22);
            this.angvelocityBox.TabIndex = 2;
            // 
            // orientationBox
            // 
            this.orientationBox.Location = new System.Drawing.Point(8, 97);
            this.orientationBox.Margin = new System.Windows.Forms.Padding(4);
            this.orientationBox.Name = "orientationBox";
            this.orientationBox.ReadOnly = true;
            this.orientationBox.Size = new System.Drawing.Size(160, 22);
            this.orientationBox.TabIndex = 1;
            // 
            // accelerationBox
            // 
            this.accelerationBox.Location = new System.Drawing.Point(8, 52);
            this.accelerationBox.Margin = new System.Windows.Forms.Padding(4);
            this.accelerationBox.Name = "accelerationBox";
            this.accelerationBox.ReadOnly = true;
            this.accelerationBox.Size = new System.Drawing.Size(164, 22);
            this.accelerationBox.TabIndex = 0;
            this.accelerationBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SI7021Groupbox
            // 
            this.SI7021Groupbox.Controls.Add(this.label4);
            this.SI7021Groupbox.Controls.Add(this.label3);
            this.SI7021Groupbox.Controls.Add(this.SI7021HumidityBox);
            this.SI7021Groupbox.Controls.Add(this.SI7021TemperatureBox);
            this.SI7021Groupbox.Location = new System.Drawing.Point(441, 277);
            this.SI7021Groupbox.Margin = new System.Windows.Forms.Padding(4);
            this.SI7021Groupbox.Name = "SI7021Groupbox";
            this.SI7021Groupbox.Padding = new System.Windows.Forms.Padding(4);
            this.SI7021Groupbox.Size = new System.Drawing.Size(267, 148);
            this.SI7021Groupbox.TabIndex = 2;
            this.SI7021Groupbox.TabStop = false;
            this.SI7021Groupbox.Text = "SI7021";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Humidity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Temperature";
            // 
            // SI7021HumidityBox
            // 
            this.SI7021HumidityBox.Location = new System.Drawing.Point(20, 78);
            this.SI7021HumidityBox.Margin = new System.Windows.Forms.Padding(4);
            this.SI7021HumidityBox.Name = "SI7021HumidityBox";
            this.SI7021HumidityBox.ReadOnly = true;
            this.SI7021HumidityBox.Size = new System.Drawing.Size(132, 22);
            this.SI7021HumidityBox.TabIndex = 7;
            // 
            // SI7021TemperatureBox
            // 
            this.SI7021TemperatureBox.Location = new System.Drawing.Point(20, 34);
            this.SI7021TemperatureBox.Margin = new System.Windows.Forms.Padding(4);
            this.SI7021TemperatureBox.Name = "SI7021TemperatureBox";
            this.SI7021TemperatureBox.ReadOnly = true;
            this.SI7021TemperatureBox.Size = new System.Drawing.Size(132, 22);
            this.SI7021TemperatureBox.TabIndex = 6;
            // 
            // BMP085GroupBox
            // 
            this.BMP085GroupBox.Controls.Add(this.label2);
            this.BMP085GroupBox.Controls.Add(this.label1);
            this.BMP085GroupBox.Controls.Add(this.textBox3);
            this.BMP085GroupBox.Controls.Add(this.BMP085AltitudeBox);
            this.BMP085GroupBox.Controls.Add(this.textBox2);
            this.BMP085GroupBox.Controls.Add(this.BMP085PressureBox);
            this.BMP085GroupBox.Controls.Add(this.textBox1);
            this.BMP085GroupBox.Location = new System.Drawing.Point(441, 39);
            this.BMP085GroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.BMP085GroupBox.Name = "BMP085GroupBox";
            this.BMP085GroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.BMP085GroupBox.Size = new System.Drawing.Size(267, 148);
            this.BMP085GroupBox.TabIndex = 3;
            this.BMP085GroupBox.TabStop = false;
            this.BMP085GroupBox.Text = "BMP085";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Altitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pressure";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, -126);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 10;
            // 
            // BMP085AltitudeBox
            // 
            this.BMP085AltitudeBox.Location = new System.Drawing.Point(8, 74);
            this.BMP085AltitudeBox.Margin = new System.Windows.Forms.Padding(4);
            this.BMP085AltitudeBox.Name = "BMP085AltitudeBox";
            this.BMP085AltitudeBox.ReadOnly = true;
            this.BMP085AltitudeBox.Size = new System.Drawing.Size(132, 22);
            this.BMP085AltitudeBox.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, -168);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 9;
            // 
            // BMP085PressureBox
            // 
            this.BMP085PressureBox.Location = new System.Drawing.Point(8, 42);
            this.BMP085PressureBox.Margin = new System.Windows.Forms.Padding(4);
            this.BMP085PressureBox.Name = "BMP085PressureBox";
            this.BMP085PressureBox.ReadOnly = true;
            this.BMP085PressureBox.Size = new System.Drawing.Size(132, 22);
            this.BMP085PressureBox.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, -207);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 8;
            // 
            // TimeGroupBox
            // 
            this.TimeGroupBox.Controls.Add(this.label11);
            this.TimeGroupBox.Controls.Add(this.timeBox);
            this.TimeGroupBox.Location = new System.Drawing.Point(51, 471);
            this.TimeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.TimeGroupBox.Size = new System.Drawing.Size(259, 96);
            this.TimeGroupBox.TabIndex = 5;
            this.TimeGroupBox.TabStop = false;
            this.TimeGroupBox.Text = "Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Milliseconds";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(8, 41);
            this.timeBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(132, 22);
            this.timeBox.TabIndex = 9;
            // 
            // serialPortComboBox
            // 
            this.serialPortComboBox.FormattingEnabled = true;
            this.serialPortComboBox.Location = new System.Drawing.Point(6, 35);
            this.serialPortComboBox.Name = "serialPortComboBox";
            this.serialPortComboBox.Size = new System.Drawing.Size(121, 24);
            this.serialPortComboBox.TabIndex = 6;
            // 
            // serialPortLabel
            // 
            this.serialPortLabel.AutoSize = true;
            this.serialPortLabel.Location = new System.Drawing.Point(133, 39);
            this.serialPortLabel.Name = "serialPortLabel";
            this.serialPortLabel.Size = new System.Drawing.Size(69, 16);
            this.serialPortLabel.TabIndex = 7;
            this.serialPortLabel.Text = "Serial Port";
            // 
            // serialOpenButton
            // 
            this.serialOpenButton.Location = new System.Drawing.Point(9, 107);
            this.serialOpenButton.Name = "serialOpenButton";
            this.serialOpenButton.Size = new System.Drawing.Size(77, 23);
            this.serialOpenButton.TabIndex = 8;
            this.serialOpenButton.Text = "Open";
            this.serialOpenButton.UseVisualStyleBackColor = true;
            this.serialOpenButton.Click += new System.EventHandler(this.serialOpenButton_Click);
            // 
            // serialCloseButton
            // 
            this.serialCloseButton.Location = new System.Drawing.Point(92, 107);
            this.serialCloseButton.Name = "serialCloseButton";
            this.serialCloseButton.Size = new System.Drawing.Size(71, 23);
            this.serialCloseButton.TabIndex = 9;
            this.serialCloseButton.Text = "Close";
            this.serialCloseButton.UseVisualStyleBackColor = true;
            this.serialCloseButton.Click += new System.EventHandler(this.serialCloseButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serialBaudRateLabel);
            this.groupBox2.Controls.Add(this.serialBaudRateComboBox);
            this.groupBox2.Controls.Add(this.serialErrorLabel);
            this.groupBox2.Controls.Add(this.serialPortComboBox);
            this.groupBox2.Controls.Add(this.serialCloseButton);
            this.groupBox2.Controls.Add(this.serialPortLabel);
            this.groupBox2.Controls.Add(this.serialOpenButton);
            this.groupBox2.Location = new System.Drawing.Point(758, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 215);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Network";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // serialBaudRateLabel
            // 
            this.serialBaudRateLabel.AutoSize = true;
            this.serialBaudRateLabel.Location = new System.Drawing.Point(133, 70);
            this.serialBaudRateLabel.Name = "serialBaudRateLabel";
            this.serialBaudRateLabel.Size = new System.Drawing.Size(71, 16);
            this.serialBaudRateLabel.TabIndex = 12;
            this.serialBaudRateLabel.Text = "Baud Rate";
            // 
            // serialBaudRateComboBox
            // 
            this.serialBaudRateComboBox.FormattingEnabled = true;
            this.serialBaudRateComboBox.Location = new System.Drawing.Point(6, 62);
            this.serialBaudRateComboBox.Name = "serialBaudRateComboBox";
            this.serialBaudRateComboBox.Size = new System.Drawing.Size(121, 24);
            this.serialBaudRateComboBox.TabIndex = 11;
            // 
            // serialErrorLabel
            // 
            this.serialErrorLabel.AutoSize = true;
            this.serialErrorLabel.Location = new System.Drawing.Point(6, 145);
            this.serialErrorLabel.Name = "serialErrorLabel";
            this.serialErrorLabel.Size = new System.Drawing.Size(44, 16);
            this.serialErrorLabel.TabIndex = 10;
            this.serialErrorLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TimeGroupBox);
            this.Controls.Add(this.BMP085GroupBox);
            this.Controls.Add(this.SI7021Groupbox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ground Control GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SI7021Groupbox.ResumeLayout(false);
            this.SI7021Groupbox.PerformLayout();
            this.BMP085GroupBox.ResumeLayout(false);
            this.BMP085GroupBox.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.ComboBox serialPortComboBox;
        private System.Windows.Forms.Label serialPortLabel;
        private System.Windows.Forms.Button serialOpenButton;
        private System.Windows.Forms.Button serialCloseButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label serialErrorLabel;
        private System.Windows.Forms.ComboBox serialBaudRateComboBox;
        private System.Windows.Forms.Label serialBaudRateLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
    }
}

