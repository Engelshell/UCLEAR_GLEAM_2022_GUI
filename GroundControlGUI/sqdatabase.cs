using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace GroundControlGUI
{
    internal class sqdatabase
    {

		SqliteConnection sqconnection;

		public String tableschema =
@"CREATE TABLE IF NOT EXISTS `RoverData` (
	`accelerationX`	NUMERIC,
	`accelerationY`	NUMERIC,
	`accelerationZ`	NUMERIC,
	`orientationX`	NUMERIC,
	`orientationY`	NUMERIC,
	`orientationZ`	NUMERIC,
	`angularX`	NUMERIC,
	`angularY`	NUMERIC,
	`angularZ`	NUMERIC,
	`linearX`	NUMERIC,
	`linearY`	NUMERIC,
	`linearZ`	NUMERIC,
	`magnetismX`	NUMERIC,
	`magnetismY`	NUMERIC,
	`magnetismZ`	NUMERIC,
	`gravityX`	NUMERIC,
	`gravityY`	NUMERIC,
	`gravityZ`	NUMERIC,
	`si7021temperature`	NUMERIC,
	`si7021humidity`	NUMERIC,
	`bmp085pressure`	INTEGER,
	`bmp085altitude`	NUMERIC,
	`timemillis`	INTEGER,
	`datetimeepoch`	INTEGER
);";


		public String insertStatement = @"
INSERT INTO
  `RoverData` (
    accelerationX,
    accelerationY,
    accelerationZ,
    orientationX,
    orientationY,
    orientationZ,
    angularX,
    angularY,
    angularZ,
    linearX,
    linearY,
    linearZ,
    magnetismX,
    magnetismY,
    magnetismZ,
    gravityX,
    gravityY,
    gravityZ,
    si7021temperature,
    si7021humidity,
    bmp085pressure,
    bmp085altitude,
    timemillis,
    datetimeepoch
  )
VALUES(
    @accelerationX,
    @accelerationY,
    @accelerationZ,
    @orientationX,
    @orientationY,
    @orientationZ,
    @angularX,
    @angularY,
    @angularZ,
    @linearX,
    @linearY,
    @linearZ,
    @magnetismX,
    @magnetismY,
    @magnetismZ,
    @gravityX,
    @gravityY,
    @gravityZ,
    @si7021temperature,
    @si7021humidity,
    @bmp085pressure,
    @bmp085altitude,
    @timemillis,
    @datetimeepoch
  )
";
		public void initializeDB()
        {
			String datetim = DateTime.Now.ToString("yyyyMMddHHmmss");
			SQLitePCL.Batteries.Init();
			sqconnection = new SqliteConnection($"Data Source={datetim}.db");
			sqconnection.Open();
			SqliteTransaction tran;
			var command = sqconnection.CreateCommand();
			command.CommandText = tableschema;
			int t = command.ExecuteNonQuery();
			if(t != 0 ) {
				Console.WriteLine("database table error");
            }
			
		}
		public struct DataRow
		{
			public Vec3 acceleration { get; set; }
			public Vec3 orientation { get; set; }
			public Vec3 angular { get; set; }
			public Vec3 linear { get; set; }
			public Vec3 magnetism { get; set; }
			public Vec3 gravity { get; set; }
			public float si7021temperature { get; set; }
			public float si7021humidity { get; set; }
			public int bmp085pressure { get; set; }
			public float bmp085altitude { get; set; }
			public int timemillis { get; set; }
			public int datetimeepoch { get; set; }
		}
		public void writeDataRow(ref SensorData data)
        {
			using (var transaction = sqconnection.BeginTransaction())
			{

				var command = sqconnection.CreateCommand();
				command.CommandText = insertStatement;
				command.Prepare();
				command.Parameters.AddWithValue("@accelerationX", data.sensors.bno055.acceleration.x);
				command.Parameters.AddWithValue("@accelerationY", data.sensors.bno055.acceleration.y);
				command.Parameters.AddWithValue("@accelerationZ", data.sensors.bno055.acceleration.z);

				command.Parameters.AddWithValue("@orientationX", data.sensors.bno055.orientation.x);
				command.Parameters.AddWithValue("@orientationY", data.sensors.bno055.orientation.y);
				command.Parameters.AddWithValue("@orientationZ", data.sensors.bno055.orientation.z);

				command.Parameters.AddWithValue("@angularX", data.sensors.bno055.angvelocity.x);
				command.Parameters.AddWithValue("@angularY", data.sensors.bno055.angvelocity.y);
				command.Parameters.AddWithValue("@angularZ", data.sensors.bno055.angvelocity.z);

				command.Parameters.AddWithValue("@linearX", data.sensors.bno055.linearAccel.x);
				command.Parameters.AddWithValue("@linearY", data.sensors.bno055.linearAccel.y);
				command.Parameters.AddWithValue("@linearZ", data.sensors.bno055.linearAccel.z);

				command.Parameters.AddWithValue("@magnetismX", data.sensors.bno055.magnetometer.x);
				command.Parameters.AddWithValue("@magnetismY", data.sensors.bno055.magnetometer.y);
				command.Parameters.AddWithValue("@magnetismZ", data.sensors.bno055.magnetometer.z);

				command.Parameters.AddWithValue("@gravityX", data.sensors.bno055.gravity.x);
				command.Parameters.AddWithValue("@gravityY", data.sensors.bno055.gravity.y);
				command.Parameters.AddWithValue("@gravityZ", data.sensors.bno055.gravity.z);

				command.Parameters.AddWithValue("@si7021temperature", data.sensors.si7021.temperature);
				command.Parameters.AddWithValue("@si7021humidity", data.sensors.si7021.humidity);
				command.Parameters.AddWithValue("@bmp085pressure", data.sensors.bmp085.pressure);
				command.Parameters.AddWithValue("@bmp085altitude", data.sensors.bmp085.altitude);

				command.Parameters.AddWithValue("@timemillis", data.sensors.time.millis);
				command.Parameters.AddWithValue("@datetimeepoch", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());

				var ret = command.ExecuteNonQuery();
				Console.WriteLine(ret);
				transaction.Commit();
			}


		}

    }
}
