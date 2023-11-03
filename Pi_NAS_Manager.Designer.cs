namespace Pi_NAS_Manager
{
    partial class Pi_NAS_Manager
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
            this.label_refresh = new System.Windows.Forms.Label();
            this.groupBox_console = new System.Windows.Forms.GroupBox();
            this.richTextBox_consoleOutput = new System.Windows.Forms.RichTextBox();
            this.button_sendCommand = new System.Windows.Forms.Button();
            this.textBox_consoleInput = new System.Windows.Forms.TextBox();
            this.groupBox_CPU = new System.Windows.Forms.GroupBox();
            this.label_CPUTemp = new System.Windows.Forms.Label();
            this.label_CPU = new System.Windows.Forms.Label();
            this.progressBar_CPU = new System.Windows.Forms.ProgressBar();
            this.button_poweroff = new System.Windows.Forms.Button();
            this.groupBox_RAM = new System.Windows.Forms.GroupBox();
            this.label_RAM = new System.Windows.Forms.Label();
            this.progressBar_RAM = new System.Windows.Forms.ProgressBar();
            this.button_reboot = new System.Windows.Forms.Button();
            this.numericUpDown_refresh = new System.Windows.Forms.NumericUpDown();
            this.label_uptime = new System.Windows.Forms.Label();
            this.groupBox_uptime = new System.Windows.Forms.GroupBox();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.groupBox_console.SuspendLayout();
            this.groupBox_CPU.SuspendLayout();
            this.groupBox_RAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_refresh)).BeginInit();
            this.groupBox_uptime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_refresh
            // 
            this.label_refresh.AutoSize = true;
            this.label_refresh.Location = new System.Drawing.Point(163, 608);
            this.label_refresh.Name = "label_refresh";
            this.label_refresh.Size = new System.Drawing.Size(115, 13);
            this.label_refresh.TabIndex = 12;
            this.label_refresh.Text = "Refresh time (seconds)";
            // 
            // groupBox_console
            // 
            this.groupBox_console.Controls.Add(this.richTextBox_consoleOutput);
            this.groupBox_console.Controls.Add(this.button_sendCommand);
            this.groupBox_console.Controls.Add(this.textBox_consoleInput);
            this.groupBox_console.Location = new System.Drawing.Point(333, 17);
            this.groupBox_console.Name = "groupBox_console";
            this.groupBox_console.Size = new System.Drawing.Size(554, 609);
            this.groupBox_console.TabIndex = 14;
            this.groupBox_console.TabStop = false;
            this.groupBox_console.Text = "Console SSH";
            // 
            // richTextBox_consoleOutput
            // 
            this.richTextBox_consoleOutput.Location = new System.Drawing.Point(6, 19);
            this.richTextBox_consoleOutput.Name = "richTextBox_consoleOutput";
            this.richTextBox_consoleOutput.ReadOnly = true;
            this.richTextBox_consoleOutput.Size = new System.Drawing.Size(542, 558);
            this.richTextBox_consoleOutput.TabIndex = 15;
            this.richTextBox_consoleOutput.Text = "";
            // 
            // button_sendCommand
            // 
            this.button_sendCommand.Location = new System.Drawing.Point(473, 581);
            this.button_sendCommand.Name = "button_sendCommand";
            this.button_sendCommand.Size = new System.Drawing.Size(75, 23);
            this.button_sendCommand.TabIndex = 17;
            this.button_sendCommand.Text = "Send";
            this.button_sendCommand.UseVisualStyleBackColor = true;
            this.button_sendCommand.Click += new System.EventHandler(this.button_sendCommand_Click);
            // 
            // textBox_consoleInput
            // 
            this.textBox_consoleInput.Location = new System.Drawing.Point(6, 583);
            this.textBox_consoleInput.Name = "textBox_consoleInput";
            this.textBox_consoleInput.Size = new System.Drawing.Size(461, 20);
            this.textBox_consoleInput.TabIndex = 16;
            // 
            // groupBox_CPU
            // 
            this.groupBox_CPU.Controls.Add(this.label_CPUTemp);
            this.groupBox_CPU.Controls.Add(this.label_CPU);
            this.groupBox_CPU.Controls.Add(this.progressBar_CPU);
            this.groupBox_CPU.Location = new System.Drawing.Point(12, 12);
            this.groupBox_CPU.Name = "groupBox_CPU";
            this.groupBox_CPU.Size = new System.Drawing.Size(315, 48);
            this.groupBox_CPU.TabIndex = 0;
            this.groupBox_CPU.TabStop = false;
            this.groupBox_CPU.Text = "CPU";
            // 
            // label_CPUTemp
            // 
            this.label_CPUTemp.AutoSize = true;
            this.label_CPUTemp.Location = new System.Drawing.Point(38, 0);
            this.label_CPUTemp.Name = "label_CPUTemp";
            this.label_CPUTemp.Size = new System.Drawing.Size(22, 13);
            this.label_CPUTemp.TabIndex = 1;
            this.label_CPUTemp.Text = "0\'C";
            // 
            // label_CPU
            // 
            this.label_CPU.AutoSize = true;
            this.label_CPU.Location = new System.Drawing.Point(6, 23);
            this.label_CPU.Name = "label_CPU";
            this.label_CPU.Size = new System.Drawing.Size(21, 13);
            this.label_CPU.TabIndex = 2;
            this.label_CPU.Text = "0%";
            // 
            // progressBar_CPU
            // 
            this.progressBar_CPU.Location = new System.Drawing.Point(41, 19);
            this.progressBar_CPU.Name = "progressBar_CPU";
            this.progressBar_CPU.Size = new System.Drawing.Size(268, 23);
            this.progressBar_CPU.Step = 3;
            this.progressBar_CPU.TabIndex = 2;
            // 
            // button_poweroff
            // 
            this.button_poweroff.Location = new System.Drawing.Point(9, 36);
            this.button_poweroff.Name = "button_poweroff";
            this.button_poweroff.Size = new System.Drawing.Size(147, 23);
            this.button_poweroff.TabIndex = 9;
            this.button_poweroff.Text = "Power OFF";
            this.button_poweroff.UseVisualStyleBackColor = true;
            this.button_poweroff.Click += new System.EventHandler(this.button_poweroff_Click);
            // 
            // groupBox_RAM
            // 
            this.groupBox_RAM.Controls.Add(this.label_RAM);
            this.groupBox_RAM.Controls.Add(this.progressBar_RAM);
            this.groupBox_RAM.Location = new System.Drawing.Point(12, 66);
            this.groupBox_RAM.Name = "groupBox_RAM";
            this.groupBox_RAM.Size = new System.Drawing.Size(315, 48);
            this.groupBox_RAM.TabIndex = 4;
            this.groupBox_RAM.TabStop = false;
            this.groupBox_RAM.Text = "RAM";
            // 
            // label_RAM
            // 
            this.label_RAM.AutoSize = true;
            this.label_RAM.Location = new System.Drawing.Point(6, 23);
            this.label_RAM.Name = "label_RAM";
            this.label_RAM.Size = new System.Drawing.Size(21, 13);
            this.label_RAM.TabIndex = 5;
            this.label_RAM.Text = "0%";
            // 
            // progressBar_RAM
            // 
            this.progressBar_RAM.Location = new System.Drawing.Point(41, 19);
            this.progressBar_RAM.Name = "progressBar_RAM";
            this.progressBar_RAM.Size = new System.Drawing.Size(268, 23);
            this.progressBar_RAM.Step = 1;
            this.progressBar_RAM.TabIndex = 6;
            // 
            // button_reboot
            // 
            this.button_reboot.Location = new System.Drawing.Point(162, 36);
            this.button_reboot.Name = "button_reboot";
            this.button_reboot.Size = new System.Drawing.Size(147, 23);
            this.button_reboot.TabIndex = 10;
            this.button_reboot.Text = "Reboot";
            this.button_reboot.UseVisualStyleBackColor = true;
            this.button_reboot.Click += new System.EventHandler(this.button_reboot_Click);
            // 
            // numericUpDown_refresh
            // 
            this.numericUpDown_refresh.Location = new System.Drawing.Point(284, 606);
            this.numericUpDown_refresh.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_refresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_refresh.Name = "numericUpDown_refresh";
            this.numericUpDown_refresh.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_refresh.TabIndex = 13;
            this.numericUpDown_refresh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_uptime
            // 
            this.label_uptime.AutoSize = true;
            this.label_uptime.Location = new System.Drawing.Point(6, 20);
            this.label_uptime.Name = "label_uptime";
            this.label_uptime.Size = new System.Drawing.Size(132, 13);
            this.label_uptime.TabIndex = 8;
            this.label_uptime.Text = "System Uptime: 0 seconds";
            // 
            // groupBox_uptime
            // 
            this.groupBox_uptime.Controls.Add(this.label_uptime);
            this.groupBox_uptime.Controls.Add(this.button_reboot);
            this.groupBox_uptime.Controls.Add(this.button_poweroff);
            this.groupBox_uptime.Location = new System.Drawing.Point(12, 120);
            this.groupBox_uptime.Name = "groupBox_uptime";
            this.groupBox_uptime.Size = new System.Drawing.Size(315, 65);
            this.groupBox_uptime.TabIndex = 7;
            this.groupBox_uptime.TabStop = false;
            this.groupBox_uptime.Text = "Power Management";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(12, 603);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(145, 23);
            this.button_disconnect.TabIndex = 11;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // Pi_NAS_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 633);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.groupBox_uptime);
            this.Controls.Add(this.label_refresh);
            this.Controls.Add(this.groupBox_console);
            this.Controls.Add(this.groupBox_CPU);
            this.Controls.Add(this.groupBox_RAM);
            this.Controls.Add(this.numericUpDown_refresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pi_NAS_Manager";
            this.Text = "DashBoard | Logged as: ";
            this.Load += new System.EventHandler(this.Pi_NAS_Manager_Load);
            this.groupBox_console.ResumeLayout(false);
            this.groupBox_console.PerformLayout();
            this.groupBox_CPU.ResumeLayout(false);
            this.groupBox_CPU.PerformLayout();
            this.groupBox_RAM.ResumeLayout(false);
            this.groupBox_RAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_refresh)).EndInit();
            this.groupBox_uptime.ResumeLayout(false);
            this.groupBox_uptime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_refresh;
        private System.Windows.Forms.GroupBox groupBox_console;
        private System.Windows.Forms.RichTextBox richTextBox_consoleOutput;
        private System.Windows.Forms.Button button_sendCommand;
        private System.Windows.Forms.TextBox textBox_consoleInput;
        private System.Windows.Forms.GroupBox groupBox_CPU;
        private System.Windows.Forms.Label label_CPUTemp;
        private System.Windows.Forms.Label label_CPU;
        private System.Windows.Forms.ProgressBar progressBar_CPU;
        private System.Windows.Forms.Button button_poweroff;
        private System.Windows.Forms.GroupBox groupBox_RAM;
        private System.Windows.Forms.Label label_RAM;
        private System.Windows.Forms.ProgressBar progressBar_RAM;
        private System.Windows.Forms.Button button_reboot;
        private System.Windows.Forms.NumericUpDown numericUpDown_refresh;
        private System.Windows.Forms.Label label_uptime;
        private System.Windows.Forms.GroupBox groupBox_uptime;
        private System.Windows.Forms.Button button_disconnect;
    }
}