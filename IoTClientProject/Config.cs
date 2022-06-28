using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace IoTClientProject
{
    public class Config
    {
        public String Devices { get; set; }
        public int AmountDevice { get; set; }
        public double maxLux { get; set; }
        public double maxHumidity { get; set; }
        public double maxTemperature { get; set; }
        public double minLux { get; set; }
        public double minHumidity { get; set; }
        public double minTemperature { get; set; }
        public bool isMonitoring { get; set; }
        public Config()
        {
            Devices = "";
            isMonitoring = false;
        }
        public Config(Config config)
        {
            Devices = config.Devices;
            maxHumidity = config.maxHumidity;
            maxLux = config.maxLux;
            maxTemperature = config.maxTemperature;
            minLux = config.minLux;
            minHumidity = config.minHumidity;
            minTemperature = config.minTemperature;
            isMonitoring = config.isMonitoring;
            AmountDevice = config.AmountDevice;
        }
        public Config(string devices, int amountDevice, double maxLux, double maxHumidity, double maxTemperature, double minLux, double minHumidity, double minTemperature, bool isMonitoring)
        {
            Devices = devices;
            AmountDevice = amountDevice;
            this.maxLux = maxLux;
            this.maxHumidity = maxHumidity;
            this.maxTemperature = maxTemperature;
            this.minLux = minLux;
            this.minHumidity = minHumidity;
            this.minTemperature = minTemperature;
            this.isMonitoring = isMonitoring;
        }

        static public void LoadConfiguration(out Config config, String PathConfig = "Config.json")
        {
            if (File.Exists(PathConfig))
            {
                char[] checkJson = File.ReadAllText(PathConfig).ToCharArray();
                if (checkJson.Length == 0)
                {
                    File.WriteAllText(PathConfig, "{}");
                }
                else if (!(checkJson[0] == '{' && checkJson[checkJson.Length-1] == '}'))
                {
                    File.WriteAllText(PathConfig, "{}");
                }
                String objectJsonFile = File.ReadAllText(PathConfig);
                config = JsonSerializer.Deserialize<Config>(objectJsonFile);
            }
            else
            {
                config = new Config();
            }
        }
        public async Task WriteDownConfiguration(String PathConfig = "Config.json")
        {
            File.WriteAllText(PathConfig, "");
            using (FileStream fs = new FileStream(PathConfig, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Config>(fs, this, new JsonSerializerOptions { WriteIndented = true }); ;
            }
        }
        public void SetDevices(String data)
        {
            Devices = data;
            AmountDevice = data.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public void SetMinMaxValues(double maxLux, double maxHumidity, double maxTemperature,
            double minLux, double minxHumidity, double minTemperature)
        {
            this.maxHumidity = maxHumidity;
            this.maxLux = maxLux;
            this.maxTemperature = maxTemperature;
            this.minLux = minLux;
            this.minTemperature = minTemperature;
            this.minHumidity = minxHumidity;
        }
        public void SetMaxLux(double maxLux)
        {
            this.maxLux = maxLux;
        }
        public void SetMaxHumidity(double maxHumidity)
        {
            this.maxHumidity = maxHumidity;
        }
        public void SetMaxTemperature(double maxTemperature)
        {
            this.maxTemperature = maxTemperature;
        }
        public void SetMinLux(double minLux)
        {
            this.minLux = minLux;
        }
        public void SetMinHumidity(double minHumidity)
        {
            this.minHumidity = minHumidity;
        }
        public void SetMinTemperature(double minTemperature)
        {
            this.minTemperature = minTemperature;
        }
        public double GetMaxLux()
        {
            return maxLux;
        }
        public double GetMaxHumidity()
        {
            return maxHumidity;
        }
        public double GetMaxTemperature()
        {
            return maxTemperature;
        }
        public double GetMinLux()
        {
            return minLux;
        }
        public double GetMinHumidity()
        {
            return minHumidity;
        }
        public double GetMinTemperature()
        {
            return minTemperature;
        }

        public bool isEmpty()
        {
            if (Devices == "")
                return true;
            else
                return false;
        }
        public string[] GetDeviceList()
        {
            return Devices.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
