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

namespace GroundControlGUI
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;
        SerialPort _serialPort;
        PacketSerial _ps;

        public Form1()
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            aTimer = new System.Timers.Timer(1);
            String portname = "COM4";
            //SerialPort.GetPortNames()[0]
            _ps = new PacketSerial();
            _serialPort = new SerialPort();

            _serialPort.PortName = portname;
            _serialPort.BaudRate = 230400;

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _ps.setStream(_serialPort);
            _ps.setPacketHandler(messageCallback);
            _serialPort.Open();

            aTimer.Elapsed += loop;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;



            InitializeComponent();
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

                    //FrontSensors
                    FrontSensorDistanceBox.Invoke(new Action(() => FrontSensorDistanceBox.Text =
                        sensors.sensors.frontsensors.distance.ToString()));

                    FrontSensorMagnetismBox.Invoke(new Action(() => FrontSensorMagnetismBox.Text =
                        sensors.sensors.frontsensors.magnetism.ToString()));

                    FrontSensorTemperaturBox.Invoke(new Action(() => FrontSensorTemperaturBox.Text =
                        sensors.sensors.frontsensors.temperature.ToString()));


                    //Time
                    timeBox.Invoke(new Action(() => timeBox.Text =
                        sensors.sensors.time.millis.ToString()));


                }



            }
            catch (Exception ex)
            {
                return;
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
            _ps.update();
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
    }
}
