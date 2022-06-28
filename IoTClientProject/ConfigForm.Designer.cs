
namespace IoTClientProject
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.ConfingText = new System.Windows.Forms.TextBox();
            this.LabelInf = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.MinTemperatureTB = new System.Windows.Forms.TextBox();
            this.MaxTemperatureTB = new System.Windows.Forms.TextBox();
            this.MinHumidityTB = new System.Windows.Forms.TextBox();
            this.MaxHumidityTB = new System.Windows.Forms.TextBox();
            this.MinLuxTB = new System.Windows.Forms.TextBox();
            this.MaxLuxTB = new System.Windows.Forms.TextBox();
            this.LabelInf2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.isMonitoring = new System.Windows.Forms.CheckBox();
            this.MonitoringData = new System.Windows.Forms.GroupBox();
            this.MonitoringData.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfingText
            // 
            resources.ApplyResources(this.ConfingText, "ConfingText");
            this.ConfingText.Name = "ConfingText";
            // 
            // LabelInf
            // 
            resources.ApplyResources(this.LabelInf, "LabelInf");
            this.LabelInf.Name = "LabelInf";
            // 
            // buttonConfirm
            // 
            resources.ApplyResources(this.buttonConfirm, "buttonConfirm");
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // MinTemperatureTB
            // 
            resources.ApplyResources(this.MinTemperatureTB, "MinTemperatureTB");
            this.MinTemperatureTB.Name = "MinTemperatureTB";
            // 
            // MaxTemperatureTB
            // 
            resources.ApplyResources(this.MaxTemperatureTB, "MaxTemperatureTB");
            this.MaxTemperatureTB.Name = "MaxTemperatureTB";
            // 
            // MinHumidityTB
            // 
            resources.ApplyResources(this.MinHumidityTB, "MinHumidityTB");
            this.MinHumidityTB.Name = "MinHumidityTB";
            // 
            // MaxHumidityTB
            // 
            resources.ApplyResources(this.MaxHumidityTB, "MaxHumidityTB");
            this.MaxHumidityTB.Name = "MaxHumidityTB";
            // 
            // MinLuxTB
            // 
            resources.ApplyResources(this.MinLuxTB, "MinLuxTB");
            this.MinLuxTB.Name = "MinLuxTB";
            // 
            // MaxLuxTB
            // 
            resources.ApplyResources(this.MaxLuxTB, "MaxLuxTB");
            this.MaxLuxTB.Name = "MaxLuxTB";
            // 
            // LabelInf2
            // 
            resources.ApplyResources(this.LabelInf2, "LabelInf2");
            this.LabelInf2.Name = "LabelInf2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // isMonitoring
            // 
            resources.ApplyResources(this.isMonitoring, "isMonitoring");
            this.isMonitoring.Checked = true;
            this.isMonitoring.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isMonitoring.Name = "isMonitoring";
            this.isMonitoring.UseVisualStyleBackColor = true;
            this.isMonitoring.CheckedChanged += new System.EventHandler(this.isMonitoring_CheckedChanged);
            // 
            // MonitoringData
            // 
            this.MonitoringData.Controls.Add(this.MaxTemperatureTB);
            this.MonitoringData.Controls.Add(this.MinTemperatureTB);
            this.MonitoringData.Controls.Add(this.label9);
            this.MonitoringData.Controls.Add(this.MinHumidityTB);
            this.MonitoringData.Controls.Add(this.label8);
            this.MonitoringData.Controls.Add(this.MaxHumidityTB);
            this.MonitoringData.Controls.Add(this.label7);
            this.MonitoringData.Controls.Add(this.MinLuxTB);
            this.MonitoringData.Controls.Add(this.label5);
            this.MonitoringData.Controls.Add(this.MaxLuxTB);
            this.MonitoringData.Controls.Add(this.label6);
            this.MonitoringData.Controls.Add(this.label1);
            this.MonitoringData.Controls.Add(this.label3);
            this.MonitoringData.Controls.Add(this.label2);
            this.MonitoringData.Controls.Add(this.label4);
            resources.ApplyResources(this.MonitoringData, "MonitoringData");
            this.MonitoringData.Name = "MonitoringData";
            this.MonitoringData.TabStop = false;
            // 
            // ConfigForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MonitoringData);
            this.Controls.Add(this.isMonitoring);
            this.Controls.Add(this.LabelInf2);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.LabelInf);
            this.Controls.Add(this.ConfingText);
            this.Name = "ConfigForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.MonitoringData.ResumeLayout(false);
            this.MonitoringData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConfingText;
        private System.Windows.Forms.Label LabelInf;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox MinTemperatureTB;
        private System.Windows.Forms.TextBox MaxTemperatureTB;
        private System.Windows.Forms.TextBox MinHumidityTB;
        private System.Windows.Forms.TextBox MaxHumidityTB;
        private System.Windows.Forms.TextBox MinLuxTB;
        private System.Windows.Forms.TextBox MaxLuxTB;
        private System.Windows.Forms.Label LabelInf2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox isMonitoring;
        private System.Windows.Forms.GroupBox MonitoringData;
    }
}