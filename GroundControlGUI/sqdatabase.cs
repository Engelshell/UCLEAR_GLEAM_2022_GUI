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
	`fsensetemperature`	NUMERIC,
	`fsensedistance`	NUMERIC,
	`fsensemagnetism`	NUMERIC,
	`timemillis`	INTEGER,
	`datetimeepoch`	INTEGER
);";

		public void initializeDB()
        {
			SQLitePCL.Batteries.Init();
			sqconnection = new SqliteConnection("Data Source=test.db");
			sqconnection.Open();

			using (var command = sqconnection.CreateCommand())
			{
				using (var tx = sqconnection.BeginTransaction())
				{
					command.CommandText = tableschema;
					var retval = command.ExecuteNonQuery();
					tx.Commit();
				}
			}
		}


    }
}
