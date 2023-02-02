
namespace PingDesktopApp
{
    partial class formPing
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
            this.btn_Ping = new System.Windows.Forms.Button();
            this.lbl_Host = new System.Windows.Forms.Label();
            this.txtBox_IpAdress = new System.Windows.Forms.TextBox();
            this.chckBox_Fragment = new System.Windows.Forms.CheckBox();
            this.txtBox_Data = new System.Windows.Forms.TextBox();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.spinBox_PingInterval = new System.Windows.Forms.NumericUpDown();
            this.lbl_PingPerSec = new System.Windows.Forms.Label();
            this.checkBox_ContiniousPing = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBx_PingResp = new System.Windows.Forms.RichTextBox();
            this.txtBox_FailedCounter = new System.Windows.Forms.TextBox();
            this.txtBox_SucessCounter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinBox_PingInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Ping
            // 
            this.btn_Ping.Location = new System.Drawing.Point(150, 169);
            this.btn_Ping.Name = "btn_Ping";
            this.btn_Ping.Size = new System.Drawing.Size(75, 23);
            this.btn_Ping.TabIndex = 0;
            this.btn_Ping.Text = "Ping";
            this.btn_Ping.UseVisualStyleBackColor = true;
            this.btn_Ping.Click += new System.EventHandler(this.btn_Ping_Click);
            // 
            // lbl_Host
            // 
            this.lbl_Host.AutoSize = true;
            this.lbl_Host.CausesValidation = false;
            this.lbl_Host.Location = new System.Drawing.Point(34, 26);
            this.lbl_Host.Name = "lbl_Host";
            this.lbl_Host.Size = new System.Drawing.Size(29, 13);
            this.lbl_Host.TabIndex = 2;
            this.lbl_Host.Text = "Host";
            // 
            // txtBox_IpAdress
            // 
            this.txtBox_IpAdress.Location = new System.Drawing.Point(91, 19);
            this.txtBox_IpAdress.Name = "txtBox_IpAdress";
            this.txtBox_IpAdress.Size = new System.Drawing.Size(134, 20);
            this.txtBox_IpAdress.TabIndex = 3;
            // 
            // chckBox_Fragment
            // 
            this.chckBox_Fragment.AutoSize = true;
            this.chckBox_Fragment.Location = new System.Drawing.Point(91, 88);
            this.chckBox_Fragment.Name = "chckBox_Fragment";
            this.chckBox_Fragment.Size = new System.Drawing.Size(70, 17);
            this.chckBox_Fragment.TabIndex = 8;
            this.chckBox_Fragment.Text = "Fragment";
            this.chckBox_Fragment.UseVisualStyleBackColor = true;
            // 
            // txtBox_Data
            // 
            this.txtBox_Data.Location = new System.Drawing.Point(91, 53);
            this.txtBox_Data.Name = "txtBox_Data";
            this.txtBox_Data.Size = new System.Drawing.Size(134, 20);
            this.txtBox_Data.TabIndex = 10;
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.CausesValidation = false;
            this.lbl_Data.Location = new System.Drawing.Point(34, 60);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(30, 13);
            this.lbl_Data.TabIndex = 9;
            this.lbl_Data.Text = "Data";
            // 
            // spinBox_PingInterval
            // 
            this.spinBox_PingInterval.Location = new System.Drawing.Point(139, 134);
            this.spinBox_PingInterval.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.spinBox_PingInterval.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spinBox_PingInterval.Name = "spinBox_PingInterval";
            this.spinBox_PingInterval.Size = new System.Drawing.Size(55, 20);
            this.spinBox_PingInterval.TabIndex = 17;
            this.spinBox_PingInterval.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.spinBox_PingInterval.ValueChanged += new System.EventHandler(this.spinBox_PingInterval_ValueChanged);
            // 
            // lbl_PingPerSec
            // 
            this.lbl_PingPerSec.AutoSize = true;
            this.lbl_PingPerSec.CausesValidation = false;
            this.lbl_PingPerSec.Location = new System.Drawing.Point(34, 136);
            this.lbl_PingPerSec.Name = "lbl_PingPerSec";
            this.lbl_PingPerSec.Size = new System.Drawing.Size(88, 13);
            this.lbl_PingPerSec.TabIndex = 18;
            this.lbl_PingPerSec.Text = "Ping Interval [ms]";
            // 
            // checkBox_ContiniousPing
            // 
            this.checkBox_ContiniousPing.AutoSize = true;
            this.checkBox_ContiniousPing.Location = new System.Drawing.Point(91, 111);
            this.checkBox_ContiniousPing.Name = "checkBox_ContiniousPing";
            this.checkBox_ContiniousPing.Size = new System.Drawing.Size(103, 17);
            this.checkBox_ContiniousPing.TabIndex = 19;
            this.checkBox_ContiniousPing.Text = "Continously ping";
            this.checkBox_ContiniousPing.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox_ContiniousPing.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spinBox_PingInterval);
            this.groupBox1.Controls.Add(this.lbl_Host);
            this.groupBox1.Controls.Add(this.btn_Ping);
            this.groupBox1.Controls.Add(this.checkBox_ContiniousPing);
            this.groupBox1.Controls.Add(this.txtBox_IpAdress);
            this.groupBox1.Controls.Add(this.lbl_PingPerSec);
            this.groupBox1.Controls.Add(this.chckBox_Fragment);
            this.groupBox1.Controls.Add(this.lbl_Data);
            this.groupBox1.Controls.Add(this.txtBox_Data);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 198);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Failed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Successfull:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBx_PingResp
            // 
            this.txtBx_PingResp.Location = new System.Drawing.Point(261, 12);
            this.txtBx_PingResp.Name = "txtBx_PingResp";
            this.txtBx_PingResp.ReadOnly = true;
            this.txtBx_PingResp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtBx_PingResp.Size = new System.Drawing.Size(225, 242);
            this.txtBx_PingResp.TabIndex = 24;
            this.txtBx_PingResp.Text = "";
            this.txtBx_PingResp.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtBox_FailedCounter
            // 
            this.txtBox_FailedCounter.Location = new System.Drawing.Point(191, 234);
            this.txtBox_FailedCounter.Name = "txtBox_FailedCounter";
            this.txtBox_FailedCounter.ReadOnly = true;
            this.txtBox_FailedCounter.Size = new System.Drawing.Size(59, 20);
            this.txtBox_FailedCounter.TabIndex = 19;
            // 
            // txtBox_SucessCounter
            // 
            this.txtBox_SucessCounter.Location = new System.Drawing.Point(76, 234);
            this.txtBox_SucessCounter.Name = "txtBox_SucessCounter";
            this.txtBox_SucessCounter.ReadOnly = true;
            this.txtBox_SucessCounter.Size = new System.Drawing.Size(59, 20);
            this.txtBox_SucessCounter.TabIndex = 20;
            // 
            // formPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 271);
            this.Controls.Add(this.txtBox_FailedCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_SucessCounter);
            this.Controls.Add(this.txtBx_PingResp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "formPing";
            this.Text = "Ping App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinBox_PingInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ping;
        private System.Windows.Forms.Label lbl_Host;
        private System.Windows.Forms.TextBox txtBox_IpAdress;
        private System.Windows.Forms.CheckBox chckBox_Fragment;
        private System.Windows.Forms.TextBox txtBox_Data;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.NumericUpDown spinBox_PingInterval;
        private System.Windows.Forms.Label lbl_PingPerSec;
        private System.Windows.Forms.CheckBox checkBox_ContiniousPing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtBx_PingResp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_FailedCounter;
        private System.Windows.Forms.TextBox txtBox_SucessCounter;
    }
}

