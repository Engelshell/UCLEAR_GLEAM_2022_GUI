using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;

/*
 [
  4,
  [
    [
      [
        0,0,0
      ],
      [
        0,0,0
      ],
      [
        0,0,0
      ],
      [
        0,0,0
      ],
      [
        0,0,0
      ],
      [
        0,0,0
      ]
    ],
    [
      0,0
    ],
    [
      0,0
    ],
    [
      0,0,0
    ],
    [
      8569
    ]
  ]
]

*/



namespace GroundControlGUI
{

    [MessagePackObject]
    public class Vec3
    {
        [Key(0)]
        public float x { get; set; }
        [Key(1)]
        public float y { get; set; }
        [Key(2)]
        public float z { get; set; }
        public String ToString()
        {
            return String.Format("X:{0} Y:{1} Z:{2}", x, y, z);
        }
    }
    [MessagePackObject]
    public class BNO055
    {
        
        [Key(0)]
        public Vec3 acceleration { get; set; } //Acceleration Vector (100Hz) Three axis of acceleration (gravity + linear motion) in m/s^2
        
        [Key(1)]
        public Vec3 orientation { get; set; }//Absolute Orientation (Euler Vector, 100Hz) Three axis orientation data based on a 360° sphere
        
        [Key(2)]
        public Vec3 angvelocity { get; set; } //Angular Velocity Vector (100Hz) Three axis of 'rotation speed' in rad/s
        
        [Key(3)]
        public Vec3 linearAccel { get; set; } //Linear Acceleration Vector (100Hz) Three axis of linear acceleration data (acceleration minus gravity) in m/s^2
        
        [Key(4)]
        public Vec3 magnetometer { get; set; } //Magnetic Field Strength Vector (20Hz) Three axis of magnetic field sensing in micro Tesla (uT)
        
        [Key(5)]
        public Vec3 gravity { get; set; } //Gravity Vector (100Hz) Three axis of gravitational acceleration (minus any movement) in m/s^2
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
        public Int32 pressure { get; set; }
        [Key(1)]
        public float altitude { get; set; }
    };

    [MessagePackObject]
    public class Time
    {
        [Key(0)]
        public UInt32 millis;
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
        public Time time { get; set; }
    };


    [MessagePackObject]
    public class SensorData
    {
        [Key(0)]
        public byte type { get; set; }
        [Key(1)]
        public Sensors sensors { get; set; }
        
    };


    [MessagePackObject]
    public class LogMessage
    {
        [Key(0)]
        public byte type { get; set; }
        [Key(1)]
        public String message { get; set; }
    };



}
