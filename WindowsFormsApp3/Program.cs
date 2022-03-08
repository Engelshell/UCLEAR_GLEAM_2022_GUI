using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
//using WindowsFormsApp3.PacketSerial;
using System.Timers;
using MessagePack;

namespace WindowsFormsApp3
{
    static class Program
    {
        private static System.Timers.Timer aTimer;

        static SerialPort _serialPort;
        static PacketSerial _ps;

        //delegate void onPacketFunction(ref byte[] bytes, int size);
        public static void messageCallback(ref byte[] bytes, int size)
        {


            Sensors sensors = MessagePackSerializer.Deserialize<Sensors>(bytes);

            // You can dump MessagePack binary blobs to human readable json.
            // Using indexed keys (as opposed to string keys) will serialize to MessagePack arrays,
            // hence property names are not available.
            // [99,"hoge","huga"]
            var json = MessagePackSerializer.ConvertToJson(bytes);
            Console.WriteLine(json);

        }

        public static void loop(Object source, ElapsedEventArgs e)
        {
            _ps.update();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
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

           

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            _serialPort.Close();
        }
    }
}
