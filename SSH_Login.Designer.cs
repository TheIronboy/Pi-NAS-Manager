namespace Pi_NAS_Manager
{
    partial class SSH_Login
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.checkBox_remember = new System.Windows.Forms.CheckBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(101, 15);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(232, 22);
            this.textBox_ip.TabIndex = 1;
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(16, 18);
            this.label_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(22, 16);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "IP:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(16, 50);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(73, 16);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "Username:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(101, 47);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(232, 22);
            this.textBox_username.TabIndex = 3;
            // 
            // checkBox_remember
            // 
            this.checkBox_remember.AutoSize = true;
            this.checkBox_remember.Location = new System.Drawing.Point(20, 116);
            this.checkBox_remember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_remember.Name = "checkBox_remember";
            this.checkBox_remember.Size = new System.Drawing.Size(162, 20);
            this.checkBox_remember.TabIndex = 6;
            this.checkBox_remember.Text = "Remember connection";
            this.checkBox_remember.UseVisualStyleBackColor = true;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(205, 111);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(129, 28);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(16, 82);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 16);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(101, 79);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(232, 22);
            this.textBox_password.TabIndex = 5;
            // 
            // SSH_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 149);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.checkBox_remember);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.textBox_ip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SSH_Login";
            this.Text = "Login to SSH Server";
            this.Load += new System.EventHandler(this.SSH_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.CheckBox checkBox_remember;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
    }
}

