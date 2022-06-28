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
using System.IO;

namespace IoTClientProject
{
    public partial class Authorization : Form
    {
        Config config;
        public Authorization()
        {
            Config.LoadConfiguration(out config);
            InitializeComponent();
        }

        private void OpenScoreboard()
        {
            this.Hide();
            Scoreboard form = new Scoreboard(client, UserLoginTextBox.Text, config);
            form.Show();
        }
        
  
        MqttClient client;
        private void LogInButton_Click(object sender, EventArgs e)
        { 
            try
            {
                client = new MqttClient("m6.wqtt.ru", 11246, false, MqttSslProtocols.None, null, null);
                client.Connect("clientMain", UserLoginTextBox.Text, "1");
            }
            catch (uPLibrary.Networking.M2Mqtt.Exceptions.MqttCommunicationException ex)
            {
                MessageBox.Show("Cannot connect to MQTT broker: " + ex.Message, "Ошибка подключения", MessageBoxButtons.OK);                
            }
            if (client.IsConnected)
            {
                ConfigForm configForm = new ConfigForm(config);
                configForm.ShowDialog();
                if(config.isEmpty())
                {
                    MessageBox.Show("Не были заданы ID датчиков. Попробуйте войти еще раз и ввести значения ID.", "Ошибка!", MessageBoxButtons.OK);
                    if (client.IsConnected)
                    {
                        client.Disconnect();
                    }
                }
                else
                    OpenScoreboard();
            }
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(client != null)
                if (client.IsConnected)
                {
                    client.Disconnect();
                }
            
        }
    }
}
