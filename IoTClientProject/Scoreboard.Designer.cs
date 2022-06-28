
namespace IoTClientProject
{
    partial class Scoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HumLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LuxLabel = new System.Windows.Forms.Label();
            this.listDevice = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CorrentTelemetry = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.ChangeCongfig = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionColor = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MaxYTempTB = new System.Windows.Forms.TextBox();
            this.MinYTempTB = new System.Windows.Forms.TextBox();
            this.MaxYHumidityTB = new System.Windows.Forms.TextBox();
            this.MinYHumidityTB = new System.Windows.Forms.TextBox();
            this.MaxYLuxTB = new System.Windows.Forms.TextBox();
            this.MinYLuxTB = new System.Windows.Forms.TextBox();
            this.MinXDate = new System.Windows.Forms.TextBox();
            this.MaxXDate = new System.Windows.Forms.TextBox();
            this.SetXYSettingsButton = new System.Windows.Forms.Button();
            this.DefaultSettingsClick = new System.Windows.Forms.Button();
            this.MaxYTemp = new System.Windows.Forms.Label();
            this.MinYTemp = new System.Windows.Forms.Label();
            this.MaxYHumidity = new System.Windows.Forms.Label();
            this.MinYHumidity = new System.Windows.Forms.Label();
            this.MinYLux = new System.Windows.Forms.Label();
            this.MaxYLux = new System.Windows.Forms.Label();
            this.ChartParam = new System.Windows.Forms.GroupBox();
            this.ChartXParam = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MinXvalue = new System.Windows.Forms.Label();
            this.MaxXvalue = new System.Windows.Forms.Label();
            this.CorrentTelemetry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConditionColor)).BeginInit();
            this.ChartParam.SuspendLayout();
            this.ChartXParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Температура";
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Location = new System.Drawing.Point(119, 33);
            this.TempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(0, 13);
            this.TempLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Влажность";
            // 
            // HumLabel
            // 
            this.HumLabel.AutoSize = true;
            this.HumLabel.Location = new System.Drawing.Point(119, 75);
            this.HumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HumLabel.Name = "HumLabel";
            this.HumLabel.Size = new System.Drawing.Size(0, 13);
            this.HumLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Освещенность";
            // 
            // LuxLabel
            // 
            this.LuxLabel.AutoSize = true;
            this.LuxLabel.Location = new System.Drawing.Point(119, 110);
            this.LuxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LuxLabel.Name = "LuxLabel";
            this.LuxLabel.Size = new System.Drawing.Size(0, 13);
            this.LuxLabel.TabIndex = 5;
            // 
            // listDevice
            // 
            this.listDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.listDevice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listDevice.FormattingEnabled = true;
            this.listDevice.Location = new System.Drawing.Point(33, 74);
            this.listDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listDevice.Name = "listDevice";
            this.listDevice.Size = new System.Drawing.Size(152, 121);
            this.listDevice.TabIndex = 6;
            this.listDevice.SelectedIndexChanged += new System.EventHandler(this.listDevice_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Выберете ID устройства";
            // 
            // CorrentTelemetry
            // 
            this.CorrentTelemetry.Controls.Add(this.chart);
            this.CorrentTelemetry.Controls.Add(this.DataBox);
            this.CorrentTelemetry.Controls.Add(this.TempLabel);
            this.CorrentTelemetry.Controls.Add(this.LuxLabel);
            this.CorrentTelemetry.Controls.Add(this.label1);
            this.CorrentTelemetry.Controls.Add(this.label5);
            this.CorrentTelemetry.Controls.Add(this.HumLabel);
            this.CorrentTelemetry.Controls.Add(this.label3);
            this.CorrentTelemetry.Location = new System.Drawing.Point(211, 46);
            this.CorrentTelemetry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CorrentTelemetry.Name = "CorrentTelemetry";
            this.CorrentTelemetry.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CorrentTelemetry.Size = new System.Drawing.Size(482, 662);
            this.CorrentTelemetry.TabIndex = 8;
            this.CorrentTelemetry.TabStop = false;
            this.CorrentTelemetry.Text = "Показатели";
            // 
            // chart
            // 
            chartArea1.Name = "ChartTemp";
            chartArea2.Name = "ChartHumidity";
            chartArea3.Name = "ChartLux";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.ChartAreas.Add(chartArea3);
            this.chart.Location = new System.Drawing.Point(20, 159);
            this.chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartTemp";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "TemperatureSeries";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartLux";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Name = "LuxSeries";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartHumidity";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Green;
            series3.Name = "HumiditySeries";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(424, 492);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart";
            title1.DockedToChartArea = "ChartTemp";
            title1.IsDockedInsideChartArea = false;
            title1.Name = "TitleTemp";
            title1.Text = "Температура, °C";
            title2.DockedToChartArea = "ChartHumidity";
            title2.IsDockedInsideChartArea = false;
            title2.Name = "TitleHumidity";
            title2.Text = "Влажность, %";
            title3.DockedToChartArea = "ChartLux";
            title3.IsDockedInsideChartArea = false;
            title3.Name = "TitleLux";
            title3.Text = "Освещенность, lux";
            this.chart.Titles.Add(title1);
            this.chart.Titles.Add(title2);
            this.chart.Titles.Add(title3);
            // 
            // DataBox
            // 
            this.DataBox.Location = new System.Drawing.Point(166, 17);
            this.DataBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataBox.Multiline = true;
            this.DataBox.Name = "DataBox";
            this.DataBox.ReadOnly = true;
            this.DataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataBox.Size = new System.Drawing.Size(280, 126);
            this.DataBox.TabIndex = 6;
            // 
            // ChangeCongfig
            // 
            this.ChangeCongfig.Location = new System.Drawing.Point(45, 205);
            this.ChangeCongfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeCongfig.Name = "ChangeCongfig";
            this.ChangeCongfig.Size = new System.Drawing.Size(131, 19);
            this.ChangeCongfig.TabIndex = 9;
            this.ChangeCongfig.Text = "Изменить настройки";
            this.ChangeCongfig.UseVisualStyleBackColor = true;
            this.ChangeCongfig.Click += new System.EventHandler(this.ChangeCongfig_Click);
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(31, 11);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(64, 13);
            this.ConditionLabel.TabIndex = 11;
            this.ConditionLabel.Text = "Состояние:";
            // 
            // ConditionColor
            // 
            this.ConditionColor.BackColor = System.Drawing.Color.ForestGreen;
            this.ConditionColor.Location = new System.Drawing.Point(102, 10);
            this.ConditionColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConditionColor.Name = "ConditionColor";
            this.ConditionColor.Size = new System.Drawing.Size(54, 21);
            this.ConditionColor.TabIndex = 12;
            this.ConditionColor.TabStop = false;
            // 
            // MaxYTempTB
            // 
            this.MaxYTempTB.Location = new System.Drawing.Point(88, 34);
            this.MaxYTempTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaxYTempTB.Name = "MaxYTempTB";
            this.MaxYTempTB.Size = new System.Drawing.Size(76, 20);
            this.MaxYTempTB.TabIndex = 13;
            // 
            // MinYTempTB
            // 
            this.MinYTempTB.Location = new System.Drawing.Point(88, 71);
            this.MinYTempTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinYTempTB.Name = "MinYTempTB";
            this.MinYTempTB.Size = new System.Drawing.Size(76, 20);
            this.MinYTempTB.TabIndex = 14;
            // 
            // MaxYHumidityTB
            // 
            this.MaxYHumidityTB.Location = new System.Drawing.Point(88, 182);
            this.MaxYHumidityTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaxYHumidityTB.Name = "MaxYHumidityTB";
            this.MaxYHumidityTB.Size = new System.Drawing.Size(76, 20);
            this.MaxYHumidityTB.TabIndex = 15;
            // 
            // MinYHumidityTB
            // 
            this.MinYHumidityTB.Location = new System.Drawing.Point(88, 223);
            this.MinYHumidityTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinYHumidityTB.Name = "MinYHumidityTB";
            this.MinYHumidityTB.Size = new System.Drawing.Size(76, 20);
            this.MinYHumidityTB.TabIndex = 16;
            // 
            // MaxYLuxTB
            // 
            this.MaxYLuxTB.Location = new System.Drawing.Point(88, 339);
            this.MaxYLuxTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaxYLuxTB.Name = "MaxYLuxTB";
            this.MaxYLuxTB.Size = new System.Drawing.Size(76, 20);
            this.MaxYLuxTB.TabIndex = 17;
            // 
            // MinYLuxTB
            // 
            this.MinYLuxTB.Location = new System.Drawing.Point(88, 377);
            this.MinYLuxTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinYLuxTB.Name = "MinYLuxTB";
            this.MinYLuxTB.Size = new System.Drawing.Size(76, 20);
            this.MinYLuxTB.TabIndex = 18;
            // 
            // MinXDate
            // 
            this.MinXDate.Location = new System.Drawing.Point(21, 25);
            this.MinXDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinXDate.Name = "MinXDate";
            this.MinXDate.Size = new System.Drawing.Size(76, 20);
            this.MinXDate.TabIndex = 19;
            // 
            // MaxXDate
            // 
            this.MaxXDate.Location = new System.Drawing.Point(370, 25);
            this.MaxXDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaxXDate.Name = "MaxXDate";
            this.MaxXDate.Size = new System.Drawing.Size(76, 20);
            this.MaxXDate.TabIndex = 20;
            // 
            // SetXYSettingsButton
            // 
            this.SetXYSettingsButton.Location = new System.Drawing.Point(45, 689);
            this.SetXYSettingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SetXYSettingsButton.Name = "SetXYSettingsButton";
            this.SetXYSettingsButton.Size = new System.Drawing.Size(121, 19);
            this.SetXYSettingsButton.TabIndex = 21;
            this.SetXYSettingsButton.Text = "Применить настройки";
            this.SetXYSettingsButton.UseVisualStyleBackColor = true;
            this.SetXYSettingsButton.Click += new System.EventHandler(this.SetXYSettingsButton_Click);
            // 
            // DefaultSettingsClick
            // 
            this.DefaultSettingsClick.Location = new System.Drawing.Point(45, 721);
            this.DefaultSettingsClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DefaultSettingsClick.Name = "DefaultSettingsClick";
            this.DefaultSettingsClick.Size = new System.Drawing.Size(121, 19);
            this.DefaultSettingsClick.TabIndex = 22;
            this.DefaultSettingsClick.Text = "Сбросить настройки";
            this.DefaultSettingsClick.UseVisualStyleBackColor = true;
            this.DefaultSettingsClick.Click += new System.EventHandler(this.DefaultSettingsClick_Click);
            // 
            // MaxYTemp
            // 
            this.MaxYTemp.AutoSize = true;
            this.MaxYTemp.Location = new System.Drawing.Point(19, 34);
            this.MaxYTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxYTemp.Name = "MaxYTemp";
            this.MaxYTemp.Size = new System.Drawing.Size(34, 13);
            this.MaxYTemp.TabIndex = 23;
            this.MaxYTemp.Text = "MaxY";
            // 
            // MinYTemp
            // 
            this.MinYTemp.AutoSize = true;
            this.MinYTemp.Location = new System.Drawing.Point(19, 76);
            this.MinYTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinYTemp.Name = "MinYTemp";
            this.MinYTemp.Size = new System.Drawing.Size(31, 13);
            this.MinYTemp.TabIndex = 24;
            this.MinYTemp.Text = "MinY";
            // 
            // MaxYHumidity
            // 
            this.MaxYHumidity.AutoSize = true;
            this.MaxYHumidity.Location = new System.Drawing.Point(19, 182);
            this.MaxYHumidity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxYHumidity.Name = "MaxYHumidity";
            this.MaxYHumidity.Size = new System.Drawing.Size(34, 13);
            this.MaxYHumidity.TabIndex = 25;
            this.MaxYHumidity.Text = "MaxY";
            // 
            // MinYHumidity
            // 
            this.MinYHumidity.AutoSize = true;
            this.MinYHumidity.Location = new System.Drawing.Point(21, 223);
            this.MinYHumidity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinYHumidity.Name = "MinYHumidity";
            this.MinYHumidity.Size = new System.Drawing.Size(31, 13);
            this.MinYHumidity.TabIndex = 26;
            this.MinYHumidity.Text = "MinY";
            // 
            // MinYLux
            // 
            this.MinYLux.AutoSize = true;
            this.MinYLux.Location = new System.Drawing.Point(21, 379);
            this.MinYLux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinYLux.Name = "MinYLux";
            this.MinYLux.Size = new System.Drawing.Size(31, 13);
            this.MinYLux.TabIndex = 28;
            this.MinYLux.Text = "MinY";
            // 
            // MaxYLux
            // 
            this.MaxYLux.AutoSize = true;
            this.MaxYLux.Location = new System.Drawing.Point(19, 339);
            this.MaxYLux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxYLux.Name = "MaxYLux";
            this.MaxYLux.Size = new System.Drawing.Size(34, 13);
            this.MaxYLux.TabIndex = 27;
            this.MaxYLux.Text = "MaxY";
            // 
            // ChartParam
            // 
            this.ChartParam.Controls.Add(this.MinYLux);
            this.ChartParam.Controls.Add(this.MinYLuxTB);
            this.ChartParam.Controls.Add(this.MaxYLux);
            this.ChartParam.Controls.Add(this.MaxYTempTB);
            this.ChartParam.Controls.Add(this.MinYHumidity);
            this.ChartParam.Controls.Add(this.MinYTempTB);
            this.ChartParam.Controls.Add(this.MaxYHumidity);
            this.ChartParam.Controls.Add(this.MaxYHumidityTB);
            this.ChartParam.Controls.Add(this.MinYTemp);
            this.ChartParam.Controls.Add(this.MinYHumidityTB);
            this.ChartParam.Controls.Add(this.MaxYTemp);
            this.ChartParam.Controls.Add(this.MaxYLuxTB);
            this.ChartParam.Location = new System.Drawing.Point(21, 240);
            this.ChartParam.Name = "ChartParam";
            this.ChartParam.Size = new System.Drawing.Size(185, 413);
            this.ChartParam.TabIndex = 29;
            this.ChartParam.TabStop = false;
            this.ChartParam.Text = "Параметры осей OY";
            // 
            // ChartXParam
            // 
            this.ChartXParam.Controls.Add(this.MaxXvalue);
            this.ChartXParam.Controls.Add(this.MinXvalue);
            this.ChartXParam.Controls.Add(this.label2);
            this.ChartXParam.Controls.Add(this.MaxXDate);
            this.ChartXParam.Controls.Add(this.MinXDate);
            this.ChartXParam.Location = new System.Drawing.Point(211, 714);
            this.ChartXParam.Name = "ChartXParam";
            this.ChartXParam.Size = new System.Drawing.Size(482, 77);
            this.ChartXParam.TabIndex = 30;
            this.ChartXParam.TabStop = false;
            this.ChartXParam.Text = "Параметры оси ОХ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Формат данных: дд-мм-гггг ЧЧ:ММ";
            // 
            // MinXvalue
            // 
            this.MinXvalue.AutoSize = true;
            this.MinXvalue.Location = new System.Drawing.Point(44, 57);
            this.MinXvalue.Name = "MinXvalue";
            this.MinXvalue.Size = new System.Drawing.Size(31, 13);
            this.MinXvalue.TabIndex = 22;
            this.MinXvalue.Text = "MinX";
            // 
            // MaxXvalue
            // 
            this.MaxXvalue.AutoSize = true;
            this.MaxXvalue.Location = new System.Drawing.Point(395, 57);
            this.MaxXvalue.Name = "MaxXvalue";
            this.MaxXvalue.Size = new System.Drawing.Size(34, 13);
            this.MaxXvalue.TabIndex = 31;
            this.MaxXvalue.Text = "MaxX";
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 793);
            this.Controls.Add(this.ChartXParam);
            this.Controls.Add(this.ChartParam);
            this.Controls.Add(this.DefaultSettingsClick);
            this.Controls.Add(this.SetXYSettingsButton);
            this.Controls.Add(this.ConditionColor);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ChangeCongfig);
            this.Controls.Add(this.CorrentTelemetry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listDevice);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Scoreboard";
            this.Text = "Мониторинг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scoreboard_FormClosing);
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            this.CorrentTelemetry.ResumeLayout(false);
            this.CorrentTelemetry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConditionColor)).EndInit();
            this.ChartParam.ResumeLayout(false);
            this.ChartParam.PerformLayout();
            this.ChartXParam.ResumeLayout(false);
            this.ChartXParam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HumLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LuxLabel;
        private System.Windows.Forms.ListBox listDevice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox CorrentTelemetry;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Button ChangeCongfig;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.PictureBox ConditionColor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox MaxYTempTB;
        private System.Windows.Forms.TextBox MinYTempTB;
        private System.Windows.Forms.TextBox MaxYHumidityTB;
        private System.Windows.Forms.TextBox MinYHumidityTB;
        private System.Windows.Forms.TextBox MaxYLuxTB;
        private System.Windows.Forms.TextBox MinYLuxTB;
        private System.Windows.Forms.TextBox MinXDate;
        private System.Windows.Forms.TextBox MaxXDate;
        private System.Windows.Forms.Button SetXYSettingsButton;
        private System.Windows.Forms.Button DefaultSettingsClick;
        private System.Windows.Forms.Label MaxYTemp;
        private System.Windows.Forms.Label MinYTemp;
        private System.Windows.Forms.Label MaxYHumidity;
        private System.Windows.Forms.Label MinYHumidity;
        private System.Windows.Forms.Label MinYLux;
        private System.Windows.Forms.Label MaxYLux;
        private System.Windows.Forms.GroupBox ChartParam;
        private System.Windows.Forms.GroupBox ChartXParam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaxXvalue;
        private System.Windows.Forms.Label MinXvalue;
    }
}