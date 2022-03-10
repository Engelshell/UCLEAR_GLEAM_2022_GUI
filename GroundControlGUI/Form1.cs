using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
//using GroundControlGUI.PacketSerial;
using System.Timers;
using MessagePack;
using SQLitePCL;
using Microsoft.Data.Sqlite;
using System.IO;

namespace GroundControlGUI
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer _loopTimer;
        SerialPort _serialPort;
        PacketSerial _ps;
        sqdatabase sqdb;
        StreamWriter SI7021DataFile;

        public Form1()
        {

            _ps = new PacketSerial();
            _serialPort = new SerialPort();
            _loopTimer = new System.Timers.Timer(1);
            _ps.setStream(_serialPort);
            _ps.setPacketHandler(messageCallback);
            //_serialPort.ReadTimeout = 500;
            //_serialPort.WriteTimeout = 500;
            //sqdb = new sqdatabase();
            SI7021DataFile = new StreamWriter("SI7021DataFile.csv");
            
            //sqdb.initializeDB();

            InitializeComponent();
            this.serialOpenButton.Enabled = true;
            this.serialCloseButton.Enabled = false;

            this.serialBaudRateComboBox.Items.AddRange(new String[]
            {"9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600"});
            this.serialBaudRateComboBox.SelectedIndex = 5;

            this.serialPortComboBox.Items.AddRange(SerialPort.GetPortNames());
            //this.serialPortComboBox.SelectedIndex = 0;
           
            _loopTimer.Elapsed += loop;
            _loopTimer.AutoReset = true;
            _loopTimer.Enabled = true;

        }

        public void messageCallback(ref byte[] bytes, int size)
        {
            try
            {
                Array.Resize(ref bytes, size);
                string hex = BitConverter.ToString(bytes).Replace("-", " ");
                Console.WriteLine(hex);
                SensorData sensors = MessagePackSerializer.Deserialize<SensorData>(bytes);
                //LogMessage mes = MessagePackSerializer.Deserialize<LogMessage>(bytes);
                Console.WriteLine(sensors.type);
                
                //we have sensors
                if (sensors.type == 4)
                {
                    Console.WriteLine(sensors.sensors.bno055.acceleration.x);
                    //BNO055
                    accelerationBox.Invoke(new Action(() => accelerationBox.Text =
                        sensors.sensors.bno055.acceleration.ToString()));

                    orientationBox.Invoke(new Action(() => orientationBox.Text =
                       sensors.sensors.bno055.orientation.ToString()));

                    angvelocityBox.Invoke(new Action(() => angvelocityBox.Text =
                       sensors.sensors.bno055.angvelocity.ToString()));

                    linearAccelBox.Invoke(new Action(() => linearAccelBox.Text =
                       sensors.sensors.bno055.linearAccel.ToString()));

                    magnetometerBox.Invoke(new Action(() => magnetometerBox.Text =
                       sensors.sensors.bno055.magnetometer.ToString()));

                    gravityBox.Invoke(new Action(() => gravityBox.Text =
                       sensors.sensors.bno055.gravity.ToString()));

                    //SI7021
                    SI7021TemperatureBox.Invoke(new Action(() => SI7021TemperatureBox.Text =
                        sensors.sensors.si7021.temperature.ToString()));

                    SI7021HumidityBox.Invoke(new Action(() => SI7021HumidityBox.Text =
                        sensors.sensors.si7021.humidity.ToString()));

                    //BMP085
                    BMP085PressureBox.Invoke(new Action(() => BMP085PressureBox.Text =
                        sensors.sensors.bmp085.pressure.ToString()));

                    BMP085AltitudeBox.Invoke(new Action(() => BMP085AltitudeBox.Text =
                        sensors.sensors.bmp085.altitude.ToString()));

 
                    //Time
                    timeBox.Invoke(new Action(() => timeBox.Text =
                        sensors.sensors.time.millis.ToString()));

                    SI7021DataFile.Write(String.Format("{0},{1}\r\n",
                        sensors.sensors.si7021.temperature,
                        sensors.sensors.si7021.humidity));

                    SI7021DataFile.Flush();
                }

                

            }
            catch (Exception ex)
            {
               
            }

            try
            {
               LogMessage logm = MessagePackSerializer.Deserialize<LogMessage>(bytes);
                if(logm.type == 5)
                {
                    Console.WriteLine(logm.message);
                }


            } catch(Exception ex)
            {

            }
            //var json = MessagePackSerializer.ConvertToJson(bytes);
            //Sensors sensors = MessagePackSerializer.Deserialize<Sensors>(bytes);

            // You can dump MessagePack binary blobs to human readable json.
            // Using indexed keys (as opposed to string keys) will serialize to MessagePack arrays,
            // hence property names are not available.
            // [99,"hoge","huga"]
            // var json = MessagePackSerializer.ConvertToJson(bytes);

            //Console.WriteLine(json);

        }

        public void loop(Object source, ElapsedEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _ps.update();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void magnetometerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void serialOpenButton_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
            {
                if(this.serialPortComboBox.Items.Count < 1)
                {
                    this.serialErrorLabel.Text = "No serial COM devices found";
                    return;
                }
                this.serialErrorLabel.Text = "";
                _serialPort.PortName = (string)this.serialPortComboBox.SelectedItem;
                _serialPort.BaudRate = Int32.Parse((String)this.serialBaudRateComboBox.SelectedItem);
                _serialPort.Open();
                this.serialCloseButton.Enabled = true;
                this.serialOpenButton.Enabled = false;
            }

        }

        private void serialCloseButton_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                this.serialErrorLabel.Text = "";
                _serialPort.Close();
                this.serialOpenButton.Enabled = true;
                this.serialCloseButton.Enabled = false;
            }
        }
    }
}
