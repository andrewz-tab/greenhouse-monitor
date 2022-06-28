using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTClientProject
{
    public partial class ConfigForm : Form
    {
        Config configTemp;
        public ConfigForm(Config config)
        {
            configTemp = config;
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            configTemp.isMonitoring = isMonitoring.Checked;
            int SelectTB = 0;
            if (isMonitoring.Checked)
            {
                double minTemp = configTemp.minTemperature,
                    maxTemp = configTemp.maxTemperature,
                    minHumidity = configTemp.minHumidity,
                    maxHumidity = configTemp.minHumidity,
                    minLux = configTemp.minLux,
                    maxLux = configTemp.maxLux;
                try
                {
                    configTemp.SetMinTemperature(double.Parse(MinTemperatureTB.Text));
                    SelectTB++;
                    configTemp.SetMaxTemperature(double.Parse(MaxTemperatureTB.Text));
                    SelectTB++;
                    configTemp.SetMinHumidity(double.Parse(MinHumidityTB.Text));
                    SelectTB++;
                    configTemp.SetMaxHumidity(double.Parse(MaxHumidityTB.Text));
                    SelectTB++;
                    configTemp.SetMinLux(double.Parse(MinLuxTB.Text));
                    SelectTB++;
                    configTemp.SetMaxLux(double.Parse(MaxLuxTB.Text));
                }
                catch (FormatException ex)
                {
                    configTemp.SetMaxLux(maxLux);
                    configTemp.SetMinLux(minLux);
                    configTemp.SetMaxHumidity(maxHumidity);
                    configTemp.SetMinHumidity(minHumidity);
                    configTemp.SetMaxTemperature(maxTemp);
                    configTemp.SetMinTemperature(minTemp);
                    switch (SelectTB)
                    {
                        case 0:
                            MinTemperatureTB.Focus();
                            break;
                        case 1:
                            MaxTemperatureTB.Focus();
                            break;
                        case 2:
                            MinHumidityTB.Focus();
                            break;
                        case 3:
                            MaxHumidityTB.Focus();
                            break;
                        case 4:
                            MinLuxTB.Focus();
                            break;
                        case 5:
                            MaxLuxTB.Focus();
                            break;
                    }
                    DialogResult dr = MessageBox.Show("Неверные значения предельных параметров! Вводите вещественные числа с помощью запятой", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Retry)
                        return;
                    else
                    {
                        this.Close();
                    }
                }
            }
            configTemp.SetDevices(ConfingText.Text.Trim(' '));
            if (configTemp.isEmpty())
            {
                MessageBox.Show("Не были заданы ID датчиков.", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                configTemp.WriteDownConfiguration();
                this.Close();
            }
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            ConfingText.Text = string.Join(" ", configTemp.GetDeviceList());
            MinLuxTB.Text = configTemp.GetMinLux().ToString();
            MinHumidityTB.Text  = configTemp.GetMinHumidity().ToString();
            MinTemperatureTB.Text = configTemp.GetMinTemperature().ToString();
            MaxLuxTB.Text = configTemp.GetMaxLux().ToString();
            MaxHumidityTB.Text = configTemp.GetMaxHumidity().ToString();
            MaxTemperatureTB.Text = configTemp.GetMaxTemperature().ToString();
            isMonitoring.Checked = configTemp.isMonitoring;
        }

        private void isMonitoring_CheckedChanged(object sender, EventArgs e)
        {
            if(isMonitoring.Checked)
            {
                MonitoringData.Enabled = true;
            }
            else
            {
                MonitoringData.Enabled = false;
            }
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
