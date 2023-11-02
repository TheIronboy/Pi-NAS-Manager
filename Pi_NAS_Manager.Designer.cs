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
            this.groupBox_CPU = new System.Windows.Forms.GroupBox();
            this.label_CPU = new System.Windows.Forms.Label();
            this.progressBar_CPU = new System.Windows.Forms.ProgressBar();
            this.groupBox_RAM = new System.Windows.Forms.GroupBox();
            this.label_RAM = new System.Windows.Forms.Label();
            this.progressBar_RAM = new System.Windows.Forms.ProgressBar();
            this.label_refresh = new System.Windows.Forms.Label();
            this.numericUpDown_refresh = new System.Windows.Forms.NumericUpDown();
            this.label_loggedUser = new System.Windows.Forms.Label();
            this.label_CPUTemp = new System.Windows.Forms.Label();
            this.groupBox_CPU.SuspendLayout();
            this.groupBox_RAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_CPU
            // 
            this.groupBox_CPU.Controls.Add(this.label_CPUTemp);
            this.groupBox_CPU.Controls.Add(this.label_CPU);
            this.groupBox_CPU.Controls.Add(this.progressBar_CPU);
            this.groupBox_CPU.Location = new System.Drawing.Point(12, 12);
            this.groupBox_CPU.Name = "groupBox_CPU";
            this.groupBox_CPU.Size = new System.Drawing.Size(154, 48);
            this.groupBox_CPU.TabIndex = 0;
            this.groupBox_CPU.TabStop = false;
            this.groupBox_CPU.Text = "CPU";
            // 
            // label_CPU
            // 
            this.label_CPU.AutoSize = true;
            this.label_CPU.Location = new System.Drawing.Point(6, 24);
            this.label_CPU.Name = "label_CPU";
            this.label_CPU.Size = new System.Drawing.Size(21, 13);
            this.label_CPU.TabIndex = 1;
            this.label_CPU.Text = "0%";
            // 
            // progressBar_CPU
            // 
            this.progressBar_CPU.Location = new System.Drawing.Point(41, 19);
            this.progressBar_CPU.Name = "progressBar_CPU";
            this.progressBar_CPU.Size = new System.Drawing.Size(107, 23);
            this.progressBar_CPU.Step = 1;
            this.progressBar_CPU.TabIndex = 2;
            // 
            // groupBox_RAM
            // 
            this.groupBox_RAM.Controls.Add(this.label_RAM);
            this.groupBox_RAM.Controls.Add(this.progressBar_RAM);
            this.groupBox_RAM.Location = new System.Drawing.Point(172, 12);
            this.groupBox_RAM.Name = "groupBox_RAM";
            this.groupBox_RAM.Size = new System.Drawing.Size(154, 48);
            this.groupBox_RAM.TabIndex = 3;
            this.groupBox_RAM.TabStop = false;
            this.groupBox_RAM.Text = "RAM";
            // 
            // label_RAM
            // 
            this.label_RAM.AutoSize = true;
            this.label_RAM.Location = new System.Drawing.Point(6, 24);
            this.label_RAM.Name = "label_RAM";
            this.label_RAM.Size = new System.Drawing.Size(21, 13);
            this.label_RAM.TabIndex = 4;
            this.label_RAM.Text = "0%";
            // 
            // progressBar_RAM
            // 
            this.progressBar_RAM.Location = new System.Drawing.Point(41, 19);
            this.progressBar_RAM.Name = "progressBar_RAM";
            this.progressBar_RAM.Size = new System.Drawing.Size(107, 23);
            this.progressBar_RAM.Step = 1;
            this.progressBar_RAM.TabIndex = 5;
            // 
            // label_refresh
            // 
            this.label_refresh.AutoSize = true;
            this.label_refresh.Location = new System.Drawing.Point(332, 31);
            this.label_refresh.Name = "label_refresh";
            this.label_refresh.Size = new System.Drawing.Size(115, 13);
            this.label_refresh.TabIndex = 6;
            this.label_refresh.Text = "Refresh time (seconds)";
            // 
            // numericUpDown_refresh
            // 
            this.numericUpDown_refresh.Location = new System.Drawing.Point(453, 29);
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
            this.numericUpDown_refresh.TabIndex = 7;
            this.numericUpDown_refresh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_loggedUser
            // 
            this.label_loggedUser.AutoSize = true;
            this.label_loggedUser.Location = new System.Drawing.Point(332, 12);
            this.label_loggedUser.Name = "label_loggedUser";
            this.label_loggedUser.Size = new System.Drawing.Size(63, 13);
            this.label_loggedUser.TabIndex = 8;
            this.label_loggedUser.Text = "Logged as: ";
            // 
            // label_CPUTemp
            // 
            this.label_CPUTemp.AutoSize = true;
            this.label_CPUTemp.Location = new System.Drawing.Point(38, 0);
            this.label_CPUTemp.Name = "label_CPUTemp";
            this.label_CPUTemp.Size = new System.Drawing.Size(22, 13);
            this.label_CPUTemp.TabIndex = 3;
            this.label_CPUTemp.Text = "0\'C";
            // 
            // Pi_NAS_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 72);
            this.Controls.Add(this.label_loggedUser);
            this.Controls.Add(this.numericUpDown_refresh);
            this.Controls.Add(this.label_refresh);
            this.Controls.Add(this.groupBox_RAM);
            this.Controls.Add(this.groupBox_CPU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pi_NAS_Manager";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.Pi_NAS_Manager_Load);
            this.groupBox_CPU.ResumeLayout(false);
            this.groupBox_CPU.PerformLayout();
            this.groupBox_RAM.ResumeLayout(false);
            this.groupBox_RAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_CPU;
        private System.Windows.Forms.Label label_CPU;
        private System.Windows.Forms.ProgressBar progressBar_CPU;
        private System.Windows.Forms.GroupBox groupBox_RAM;
        private System.Windows.Forms.ProgressBar progressBar_RAM;
        private System.Windows.Forms.Label label_RAM;
        private System.Windows.Forms.Label label_refresh;
        private System.Windows.Forms.NumericUpDown numericUpDown_refresh;
        private System.Windows.Forms.Label label_loggedUser;
        private System.Windows.Forms.Label label_CPUTemp;
    }
}