
namespace IoTClientProject
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginL = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.UserLoginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginL
            // 
            this.LoginL.AutoSize = true;
            this.LoginL.Location = new System.Drawing.Point(86, 63);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(47, 17);
            this.LoginL.TabIndex = 0;
            this.LoginL.Text = "Логин";
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(105, 211);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(184, 23);
            this.LogInButton.TabIndex = 2;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // UserLoginTextBox
            // 
            this.UserLoginTextBox.Location = new System.Drawing.Point(189, 63);
            this.UserLoginTextBox.Name = "UserLoginTextBox";
            this.UserLoginTextBox.Size = new System.Drawing.Size(127, 22);
            this.UserLoginTextBox.TabIndex = 3;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 310);
            this.Controls.Add(this.UserLoginTextBox);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LoginL);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginL;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TextBox UserLoginTextBox;
    }
}

