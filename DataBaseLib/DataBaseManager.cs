using System;
using System.Data;
using System.Data.SQLite;

namespace DataBaseLib
{
    public class DataBaseManager
    {
        private SQLiteConnection Db;
        SQLiteCommand cmd;
        public DataBaseManager()
        {
            Db = new SQLiteConnection("Data Source=SensorData.db; version=3");
            Db.Open();
        }
        public void AddTelemetry(String IDDevice, double Temperature, double Humidity, double Lux)
        {
            cmd = Db.CreateCommand();
            cmd.CommandText = "insert into LatestDataSensor(IDDevice, Temperature, Lux, Humidity) values(@device, @temp, @lux, @humidity)";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            cmd.Parameters.Add("@temp", DbType.Double).Value = Temperature;
            cmd.Parameters.Add("@lux", DbType.Double).Value = Lux;
            cmd.Parameters.Add("@humidity", DbType.Double).Value = Humidity;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into AllDataSensor(IDDevice, Temperature, Lux, Humidity, DateTime) values(@device, @temp, @lux, @humidity, @date)";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            cmd.Parameters.Add("@temp", DbType.Double).Value = Temperature;
            cmd.Parameters.Add("@lux", DbType.Double).Value = Lux;
            cmd.Parameters.Add("@humidity", DbType.Double).Value = Humidity;
            cmd.Parameters.Add("@date", DbType.DateTime).Value = DateTime.Now;
            cmd.ExecuteNonQuery();
        }
        public void AddHumidityTelemetry(String IDDevice, double Humidity)
        {
            cmd = Db.CreateCommand();
            cmd.CommandText = "insert into LatestDataSensor(IDDevice, Humidity) values(@device, @humidity)";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            cmd.Parameters.Add("@humidity", DbType.Double).Value = Humidity;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into AllDataSensor(IDDevice, Humidity, DateTime) values(@device, @humidity, @date)";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            cmd.Parameters.Add("@humidity", DbType.Double).Value = Humidity;
            cmd.Parameters.Add("@date", DbType.DateTime).Value = DateTime.Now;
            cmd.ExecuteNonQuery();
        }
        public void AddLuxTelemetry(String IDDevice, double Lux)
        {
            cmd = Db.CreateCommand();
            cmd.CommandText = "insert into LatestDataSensor(IDDevice, Lux) values(@device, @lux,)";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            cmd.Parameters.Add("@lux", DbType.Double).Value = Lux;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into AllDataSensor(IDDevice, Lux, DateTime) values(@device, @lux, @date)";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            cmd.Parameters.Add("@lux", DbType.Double).Value = Lux;
            cmd.Parameters.Add("@date", DbType.DateTime).Value = DateTime.Now;
            cmd.ExecuteNonQuery();
        }
        public void AddTemperatureTelemetry(String IDDevice, double Temperature)
        {
            cmd = Db.CreateCommand();
            cmd.CommandText = "insert into LatestDataSensor(IDDevice, Temperature) values(@device, @temp)";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            cmd.Parameters.Add("@temp", DbType.Double).Value = Temperature;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into AllDataTemperature(IDDevice, Temperature, DateTime) values(@device, @temp, @date)";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            cmd.Parameters.Add("@temp", DbType.Double).Value = Temperature;
            cmd.Parameters.Add("@date", DbType.DateTime).Value = DateTime.Now;
            cmd.ExecuteNonQuery();
        }
        public String[,] GetTelemetry(String IDDevice) //i, 5
        {
            cmd = Db.CreateCommand();
            cmd.CommandText = "select count(IDRecord) from AllDataSensor where IDDevice = @device";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            var countObj = cmd.ExecuteScalar();
            int count = countObj != null ? int.Parse(countObj.ToString()) : 0;
            cmd.CommandText = "select Temperature, Lux, Humidity, DateTime from AllDataSensor where IDDevice = @device order by DateTime";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            SQLiteDataReader reader = cmd.ExecuteReader();

            string[,] data = new string[count, 4];
            for (int i = 0; i < count; i++)
            {
                reader.Read();
                data[i, 0] = reader.GetValue(0).ToString();
                data[i, 1] = reader.GetValue(1).ToString();
                data[i, 2] = reader.GetValue(2).ToString();
                data[i, 3] = reader.GetValue(3).ToString();
            }
            reader.Close();
            return data;
        }
        public void DeleteDateEarlierThen(DateTime date)
        {
            cmd = Db.CreateCommand();
            cmd.CommandText = "delete from AllDataSensor where DateTime < @date;";
            cmd.Parameters.Add("@date", DbType.DateTime).Value = date;
            cmd.ExecuteNonQuery();
        }
        public String[] GetLatestTelemetry(String IDDevice) //i, 5
        {
            cmd = Db.CreateCommand();
            cmd.CommandText = "select Temperature, Lux, Humidity from LatestDataSensor where IDDevice = @device";
            cmd.Parameters.Add("@device", DbType.String).Value = IDDevice;
            SQLiteDataReader reader = cmd.ExecuteReader();

            string[] data = new string[3];
            if (reader.HasRows)
            {
                reader.Read();
                data[0] = reader.GetValue(0).ToString();
                data[1] = reader.GetValue(1).ToString();
                data[2] = reader.GetValue(2).ToString();
            }
            else
            {
                data[0] = "none";
                data[1] = "none";
                data[2] = "none";
            }
            reader.Close();
            return data;
        }
        ~DataBaseManager()
        {
            Db.Close();
        }
    }

}
