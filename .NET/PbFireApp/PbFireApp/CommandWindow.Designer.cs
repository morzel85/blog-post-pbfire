namespace PbFireApp
{
    partial class CommandWindow
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.nudBaudRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFire = new System.Windows.Forms.GroupBox();
            this.chkSafe = new System.Windows.Forms.CheckBox();
            this.lblIsReadyToFire = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFire = new System.Windows.Forms.Button();
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbFire.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(268, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPortName
            // 
            this.txtPortName.Location = new System.Drawing.Point(8, 39);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(86, 20);
            this.txtPortName.TabIndex = 1;
            this.txtPortName.Text = "COM3";
            // 
            // nudBaudRate
            // 
            this.nudBaudRate.Location = new System.Drawing.Point(123, 39);
            this.nudBaudRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBaudRate.Minimum = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            this.nudBaudRate.Name = "nudBaudRate";
            this.nudBaudRate.Size = new System.Drawing.Size(86, 20);
            this.nudBaudRate.TabIndex = 2;
            this.nudBaudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud rate:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPortName);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 88);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reset Arduino after connecting to receive ready to fire signal!";
            // 
            // gbFire
            // 
            this.gbFire.Controls.Add(this.chkSafe);
            this.gbFire.Controls.Add(this.lblIsReadyToFire);
            this.gbFire.Controls.Add(this.label3);
            this.gbFire.Controls.Add(this.btnFire);
            this.gbFire.Enabled = false;
            this.gbFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbFire.Location = new System.Drawing.Point(13, 116);
            this.gbFire.Name = "gbFire";
            this.gbFire.Size = new System.Drawing.Size(443, 128);
            this.gbFire.TabIndex = 8;
            this.gbFire.TabStop = false;
            this.gbFire.Text = "Fire";
            // 
            // chkSafe
            // 
            this.chkSafe.AutoSize = true;
            this.chkSafe.Checked = true;
            this.chkSafe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSafe.ForeColor = System.Drawing.Color.Green;
            this.chkSafe.Location = new System.Drawing.Point(385, 27);
            this.chkSafe.Name = "chkSafe";
            this.chkSafe.Size = new System.Drawing.Size(52, 17);
            this.chkSafe.TabIndex = 2;
            this.chkSafe.Text = "Safe";
            this.chkSafe.UseVisualStyleBackColor = true;
            this.chkSafe.CheckedChanged += new System.EventHandler(this.chkSafe_CheckedChanged);
            // 
            // lblIsReadyToFire
            // 
            this.lblIsReadyToFire.AutoSize = true;
            this.lblIsReadyToFire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIsReadyToFire.Location = new System.Drawing.Point(128, 27);
            this.lblIsReadyToFire.Name = "lblIsReadyToFire";
            this.lblIsReadyToFire.Size = new System.Drawing.Size(25, 13);
            this.lblIsReadyToFire.TabIndex = 1;
            this.lblIsReadyToFire.Text = "NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Device ready to fire:";
            // 
            // btnFire
            // 
            this.btnFire.Enabled = false;
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFire.ForeColor = System.Drawing.Color.Red;
            this.btnFire.Location = new System.Drawing.Point(131, 61);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(207, 49);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // CommandWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 256);
            this.Controls.Add(this.gbFire);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CommandWindow";
            this.Text = "PbFireApp  (morzel.net blog post code sample)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommandWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFire.ResumeLayout(false);
            this.gbFire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.NumericUpDown nudBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFire;
        private System.Windows.Forms.Button btnFire;
        private System.IO.Ports.SerialPort spArduino;
        private System.Windows.Forms.CheckBox chkSafe;
        private System.Windows.Forms.Label lblIsReadyToFire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

