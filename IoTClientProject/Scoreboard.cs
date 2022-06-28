using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using DataBaseLib;
using System.Windows.Forms.DataVisualization.Charting;

namespace IoTClientProject
{
    delegate void HandleMess(string Data, string Topic);
    public partial class Scoreboard : Form
    {
        DataBaseManager manager;
        private MqttClient client;
        string TopicTelemetry;
        List<String> AllSubscribedTopics;
        string[] IDDevice;
        int CountDevice;
        int IDCurrentDevice;
        Config ActualConfig;
        bool CriticalCondition;
        TelegramBot bot;

        bool DateIsNow = true;

        public Scoreboard(MqttClient client, string userName, Config config)
        {         
            ActualConfig = config;
            this.client = client;
            this.TopicTelemetry = "/" + userName + "/Device/";
            AllSubscribedTopics = new List<String>();
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            TelegramBot.scoreboard = this;
            bot = new TelegramBot();
            InitializeComponent();
        }
        void SubOnTopic(string[] Topics)
        {
            for (int i = 0; i < Topics.Length; i++)
            {
                try
                {
                    client.Subscribe(new string[] { (TopicTelemetry + Topics[i]) }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    AllSubscribedTopics.Add(TopicTelemetry + Topics[i]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Scoreboard_FormClosing(this, new FormClosingEventArgs(CloseReason.ApplicationExitCall, false));
                }
            }
        }
        void UnSubFromTopic(string[] Topics)
        {
            for (int i = 0; i < Topics.Length; i++)
            {
                client.Unsubscribe(new string[] { (TopicTelemetry + Topics[i]) });
            }
        }
        void DefineDevice(Config config)
        {
            IDDevice = config.GetDeviceList();
            CountDevice = IDDevice.Length;
            listDevice.Items.Clear();
            listDevice.Items.AddRange(IDDevice);
            listDevice.SelectedIndex = 0;
            SubOnTopic(IDDevice);
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            SafeData(ReceivedMessage, e.Topic);
        }

        void ShowData(string DeviceID)
        {
            string[] LatestTelemetry = manager.GetLatestTelemetry(DeviceID);
            LuxLabel.Text = LatestTelemetry[1];
            HumLabel.Text = LatestTelemetry[2];
            TempLabel.Text = LatestTelemetry[0];


            string tempData = "T°C\t%\tLux\tDate" + Environment.NewLine;
            tempData += LatestTelemetry[0] + "\t" + LatestTelemetry[2] + "\t" + LatestTelemetry[1] + "\t" + DateTime.Now.ToString();
            tempData += DataBox.Text.TrimStart("T°C\t%\tLux\tDate".ToCharArray());
            DataBox.Text = tempData;
            chart.Series[0].Points.AddXY(DateTime.Now, LatestTelemetry[0]);
            chart.Series[2].Points.AddXY(DateTime.Now, LatestTelemetry[2]);
            chart.Series[1].Points.AddXY(DateTime.Now, LatestTelemetry[1]);
           
            if(DateIsNow)
            {
                for (int i = 0; i < 3; i++)
                {
                    chart.ChartAreas[i].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                }
            }
        }
        void LoadData(string DeviceID)
        {
            string[] LatestTelemetry = manager.GetLatestTelemetry(DeviceID);
            LuxLabel.Text = LatestTelemetry[1] + " lux";
            HumLabel.Text = LatestTelemetry[2] + " %";
            TempLabel.Text = LatestTelemetry[0] + " °C";

            string[,] AllTelemetry = manager.GetTelemetry(DeviceID);
            DateTime[] Date = new DateTime[AllTelemetry.GetLength(0)];
            double[] Temperature = new double[AllTelemetry.GetLength(0)];
            double[] Lux = new double[AllTelemetry.GetLength(0)];
            double[] Humidity = new double[AllTelemetry.GetLength(0)];


            DataBox.Text = "T°C\t%\tLux\tDate" + Environment.NewLine;
            for (int i = AllTelemetry.GetLength(0) - 1; i >= 0; i--)
            {
                Temperature[i] = double.Parse(AllTelemetry[i, 0]);
                Humidity[i] = double.Parse(AllTelemetry[i, 1]);
                Lux[i] = double.Parse(AllTelemetry[i, 2]);
                Date[i] = DateTime.Parse(AllTelemetry[i, 3]);
                DataBox.Text += Temperature[i] + "\t" + Lux[i] + "\t" + Humidity[i] + "\t" + Date[i] + Environment.NewLine;
            }
            chart.Series[0].Points.DataBindXY(Date, Temperature);
            chart.Series[1].Points.DataBindXY(Date, Humidity);
            chart.Series[2].Points.DataBindXY(Date, Lux);
            if (DateIsNow)
            {
                for (int i = 0; i < 3; i++)
                {
                    chart.ChartAreas[i].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                }
            }
        }
        void SafeData(string Data, string Topic)
        {
            string DeviceId = Topic.Split('/')[3];
            double Temperature = double.Parse(Data.Split(' ')[0]);
            double Humidity = double.Parse(Data.Split(' ')[1]);
            double Lux = double.Parse(Data.Split(' ')[2]);
            manager.AddTelemetry(DeviceId, Temperature, Humidity, Lux);
            if(ActualConfig.isMonitoring)
                CheckParam(DeviceId, Temperature, Humidity, Lux);
            if (DeviceId == IDDevice[IDCurrentDevice])
                ShowData(IDDevice[IDCurrentDevice]);

            manager.DeleteDateEarlierThen(DateTime.Now.AddDays(-11));
        }
        void CheckParam(string DeviceId, double Temperature, double Humidity, double Lux)
        {
            bool localCondition = false;
            string Mess = "";
            if (Temperature > ActualConfig.maxTemperature)
            {
                Mess += "Температура превышает критическое значение! Датчик - " + DeviceId + '\n';
                localCondition = true;
            }
            else if (Temperature < ActualConfig.minTemperature)
            {
                Mess += "Температура ниже минимального значения! Датчик - " + DeviceId + '\n';
                localCondition = true;
            }

            if (Humidity > ActualConfig.maxHumidity)
            {
                Mess += "Влажность превышает критическое значение! Датчик - " + DeviceId + '\n';
                localCondition = true;
            }
            else if (Humidity < ActualConfig.minHumidity)
            {
                Mess += "Влажность ниже минимального значения! Датчик - " + DeviceId + '\n';
                localCondition = true;
            }

            if (Lux > ActualConfig.maxLux)
            {
                Mess += "Освещенность превышает критическое значение! Датчик - " + DeviceId;
                localCondition = true;
            }
            else if (Lux < ActualConfig.minLux)
            {
                Mess += "Освещенность ниже минимального значения! Датчик - " + DeviceId;
                localCondition = true;
            }
            SetCondition(localCondition, Mess);
        }
        async Task SetCondition(bool condition, string Mess)
        {
            if (condition != CriticalCondition)
            {
                CriticalCondition = condition;
                if (CriticalCondition == false)
                    ConditionColor.BackColor = Color.Green;
                else
                    ConditionColor.BackColor = Color.Red;
                if (condition == true)
                {
                    TelegramBot.SendMess(Mess);
                    await Task.Run(() => SendMess(Mess));
                }
                else
                {
                    Mess = "Показатели с датчиков вернулись в оптимальное состояние";
                    TelegramBot.SendMess(Mess);
                    await Task.Run(() => SendMess(Mess));
                }
            }
            
        }
        void SendMess(string Mess)
        {
            MessageBox.Show(Mess, "Внимание!", MessageBoxButtons.OK);
        }

        private void Scoreboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client.IsConnected)
            {
                client.Disconnect();
            }
            Application.Exit();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            CriticalCondition = false;
            StartChart();
            manager = new DataBaseManager();
            DefineDevice(ActualConfig);
            IDCurrentDevice = 0;
        }

        private void StartChart()
        {
            chart.ChartAreas[0].AxisY.Minimum = -10;
            chart.ChartAreas[0].AxisY.Maximum = 45;
            chart.ChartAreas[1].AxisY.Minimum = -3;
            chart.ChartAreas[1].AxisY.Maximum = 103;
            chart.ChartAreas[2].AxisY.Minimum = 0;
            chart.ChartAreas[2].AxisY.Maximum = 10000;

            for (int i = 0; i < 3; i++)
            {
                chart.ChartAreas[i].AxisX.LabelStyle.Format = "dd-MM HH:mm";
                chart.Series[i].XValueType = ChartValueType.DateTime;

                chart.ChartAreas[i].AxisX.Minimum = DateTime.Now.AddMinutes(-60).ToOADate();
                chart.ChartAreas[i].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                DateIsNow = true;
            }
        }

        private void listDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDCurrentDevice = listDevice.SelectedIndex;
            LoadData(IDDevice[IDCurrentDevice]);
        }

        private void ChangeCongfig_Click(object sender, EventArgs e)
        {
            Config PreConfig = new Config(ActualConfig);
            ConfigForm configForm = new ConfigForm(ActualConfig);
            configForm.ShowDialog();
            UnSubFromTopic(PreConfig.GetDeviceList());
            DefineDevice(ActualConfig);
        }

        private void SetXYSettingsButton_Click(object sender, EventArgs e)
        {
            int SelectTB = 0;
            double maxY0 = chart.ChartAreas[0].AxisY.Maximum;
            double maxY1 = chart.ChartAreas[1].AxisY.Maximum;
            double maxY2 = chart.ChartAreas[2].AxisY.Maximum;
            double minY0 = chart.ChartAreas[0].AxisY.Minimum;
            double minY1 = chart.ChartAreas[1].AxisY.Minimum;
            double minY2 = chart.ChartAreas[2].AxisY.Minimum;
            DateTime minX = DateTime.FromOADate(chart.ChartAreas[0].AxisX.Minimum);
            DateTime maxX = DateTime.FromOADate(chart.ChartAreas[0].AxisX.Maximum);
            try
            {
                if (!(MaxYTempTB.Text.Trim(' ') == ""))
                    chart.ChartAreas[0].AxisY.Maximum = double.Parse(MaxYTempTB.Text);
                SelectTB++;
                if (!(MinYTempTB.Text.Trim(' ') == ""))
                    chart.ChartAreas[0].AxisY.Minimum = double.Parse(MinYTempTB.Text);
                SelectTB++;
                if (!(MaxYHumidityTB.Text.Trim(' ') == ""))
                    chart.ChartAreas[1].AxisY.Maximum = double.Parse(MaxYHumidityTB.Text);
                SelectTB++;
                if (!(MinYHumidityTB.Text.Trim(' ') == ""))
                    chart.ChartAreas[1].AxisY.Minimum = double.Parse(MinYHumidityTB.Text);
                SelectTB++;
                if (!(MaxYLuxTB.Text.Trim(' ') == ""))
                    chart.ChartAreas[2].AxisY.Maximum = double.Parse(MaxYLuxTB.Text);
                SelectTB++;
                if (!(MinYLuxTB.Text.Trim(' ') == ""))
                    chart.ChartAreas[2].AxisY.Minimum = double.Parse(MinYLuxTB.Text);
                SelectTB++;

                if(!(MinXDate.Text.Trim() == ""))
                {
                    chart.ChartAreas[0].AxisX.Minimum = DateTime.Parse(MinXDate.Text).ToOADate();
                    chart.ChartAreas[1].AxisX.Minimum = DateTime.Parse(MinXDate.Text).ToOADate();
                    chart.ChartAreas[2].AxisX.Minimum = DateTime.Parse(MinXDate.Text).ToOADate();
                }
                SelectTB++;
                if (!(MaxXDate.Text.Trim() == ""))
                {
                    chart.ChartAreas[0].AxisX.Maximum = DateTime.Parse(MaxXDate.Text).ToOADate();
                    chart.ChartAreas[1].AxisX.Maximum = DateTime.Parse(MaxXDate.Text).ToOADate();
                    chart.ChartAreas[2].AxisX.Maximum = DateTime.Parse(MaxXDate.Text).ToOADate();
                    DateIsNow = false;
                }
                SelectTB++;
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Ошибка формата данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chart.ChartAreas[0].AxisY.Maximum = maxY0;
                chart.ChartAreas[1].AxisY.Maximum = maxY1;
                chart.ChartAreas[2].AxisY.Maximum = maxY2;
                chart.ChartAreas[0].AxisY.Minimum = minY0;
                chart.ChartAreas[1].AxisY.Minimum = minY1;
                chart.ChartAreas[2].AxisY.Minimum = minY2;
                chart.ChartAreas[0].AxisX.Minimum = minX.ToOADate();
                chart.ChartAreas[0].AxisX.Maximum = maxX.ToOADate();
                chart.ChartAreas[1].AxisX.Minimum = minX.ToOADate();
                chart.ChartAreas[1].AxisX.Maximum = maxX.ToOADate();
                chart.ChartAreas[2].AxisX.Minimum = minX.ToOADate();
                chart.ChartAreas[2].AxisX.Maximum = maxX.ToOADate();
                switch (SelectTB)
                {
                    case 0:
                        MaxYTempTB.Focus();
                        break;
                    case 1:
                        MinYTempTB.Focus();
                        break;
                    case 2:
                        MaxYHumidityTB.Focus();
                        break;
                    case 3:
                        MinYHumidityTB.Focus();
                        break;
                    case 4:
                        MaxYLuxTB.Focus();
                        break;
                    case 5:
                        MinYLuxTB.Focus();
                        break;
                    case 6:
                        MinXDate.Focus();
                        break;
                    case 7:
                        MaxXDate.Focus();
                        break;
                    default:
                        break;
                }            
            }          
        }

        private void DefaultSettingsClick_Click(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisY.Minimum = -10;
            chart.ChartAreas[0].AxisY.Maximum = 45;
            chart.ChartAreas[1].AxisY.Minimum = -3;
            chart.ChartAreas[1].AxisY.Maximum = 103;
            chart.ChartAreas[2].AxisY.Minimum = 0;
            chart.ChartAreas[2].AxisY.Maximum = 10000;
            for (int i = 0; i < 3; i++)
            {
                chart.ChartAreas[i].AxisX.Minimum = DateTime.Now.AddMinutes(-60).ToOADate();
                chart.ChartAreas[i].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            }
            DateIsNow = true;
        }
        public string HandleRequest()
        {
            string answer = "";
            if (ActualConfig.isMonitoring == true)
            {
                if (CriticalCondition)
                    answer += "Состояние критическое!";
                else
                    answer += "Состояние в норме!";
                answer += '\n';
            }
            for(int i = 0; i < CountDevice; i++)
            {
                string[] Telemetry = manager.GetLatestTelemetry(IDDevice[i]);
                answer += "Датчик №" + IDDevice[i] + "\n\tТемпература " + Telemetry[0] + "°C\n\t" +
                    "Влажность " + Telemetry[2] + "%\n\t" +
                    "Освещеность " + Telemetry[1] + "lux\n";
            }
            return answer;
        }
        
    }
}
