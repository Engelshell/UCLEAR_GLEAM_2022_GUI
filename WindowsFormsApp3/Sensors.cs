using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;

namespace WindowsFormsApp3
{

    public class Vec3
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }
    [MessagePackObject]
    public class BNO055
    {
        [Key(0)]
        Vec3 acceleration { get; set; } //Acceleration Vector (100Hz) Three axis of acceleration (gravity + linear motion) in m/s^2
        [Key(1)]
        Vec3 orientation { get; set; }//Absolute Orientation (Euler Vector, 100Hz) Three axis orientation data based on a 360° sphere
        [Key(2)]
        Vec3 angvelocity { get; set; } //Angular Velocity Vector (100Hz) Three axis of 'rotation speed' in rad/s
        [Key(3)]
        Vec3 linearAccel { get; set; } //Linear Acceleration Vector (100Hz) Three axis of linear acceleration data (acceleration minus gravity) in m/s^2
        [Key(4)]
        Vec3 magnetometer { get; set; } //Magnetic Field Strength Vector (20Hz) Three axis of magnetic field sensing in micro Tesla (uT)
        [Key(5)]
        Vec3 gravity { get; set; } //Gravity Vector (100Hz) Three axis of gravitational acceleration (minus any movement) in m/s^2
    };

    [MessagePackObject]
    public class SI7021
    { 
        [Key(0)]
        public float temperature { get; set; }
        [Key(1)]
        public float humidity { get; set; }
    };

    [MessagePackObject]
    public class BMP085
    {
        [Key(0)]
        int pressure { get; set; }
        [Key(1)]
        float altitude { get; set; }
    };

    [MessagePackObject]
    public class FrontSensors
    {
        [Key(0)]
        float temperature { get; set; }
        [Key(1)]
        float magnetism { get; set; }
        [Key(2)]
        float distance { get; set; }
    }

    [MessagePackObject]
    public class Time
    {
        [Key(0)]
        UInt32 millis;
    };

    [MessagePackObject]
    public class Sensors
    {
        [Key(0)]
        public BNO055 bno055 { get; set; }
        [Key(1)]
        public SI7021 si7021 { get; set; }
        [Key(2)]
        public BMP085 bmp085 { get; set; }
        [Key(3)]
        public FrontSensors frontsensors { get; set; }
        [Key(4)]
        public Time time { get; set; }
    }; //102



}
