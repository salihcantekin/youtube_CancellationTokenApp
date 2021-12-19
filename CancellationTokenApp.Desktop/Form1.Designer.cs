namespace CancellationTokenApp.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.numericCheckTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartApp = new System.Windows.Forms.Button();
            this.btnStopApp = new System.Windows.Forms.Button();
            this.btnGettingData = new System.Windows.Forms.Button();
            this.btnCheckNow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCheckTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogs
            // 
            this.lbLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 20;
            this.lbLogs.Location = new System.Drawing.Point(0, 351);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(800, 244);
            this.lbLogs.TabIndex = 0;
            // 
            // numericCheckTime
            // 
            this.numericCheckTime.Location = new System.Drawing.Point(249, 91);
            this.numericCheckTime.Name = "numericCheckTime";
            this.numericCheckTime.Size = new System.Drawing.Size(258, 27);
            this.numericCheckTime.TabIndex = 2;
            this.numericCheckTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check Time (Second)";
            // 
            // btnStartApp
            // 
            this.btnStartApp.Location = new System.Drawing.Point(249, 138);
            this.btnStartApp.Name = "btnStartApp";
            this.btnStartApp.Size = new System.Drawing.Size(251, 44);
            this.btnStartApp.TabIndex = 4;
            this.btnStartApp.Text = "Start App";
            this.btnStartApp.UseVisualStyleBackColor = true;
            this.btnStartApp.Click += new System.EventHandler(this.btnStartApp_Click);
            // 
            // btnStopApp
            // 
            this.btnStopApp.Location = new System.Drawing.Point(249, 258);
            this.btnStopApp.Name = "btnStopApp";
            this.btnStopApp.Size = new System.Drawing.Size(251, 44);
            this.btnStopApp.TabIndex = 4;
            this.btnStopApp.Text = "Stop App";
            this.btnStopApp.UseVisualStyleBackColor = true;
            this.btnStopApp.Click += new System.EventHandler(this.btnStopApp_Click);
            // 
            // btnGettingData
            // 
            this.btnGettingData.Location = new System.Drawing.Point(563, 258);
            this.btnGettingData.Name = "btnGettingData";
            this.btnGettingData.Size = new System.Drawing.Size(165, 44);
            this.btnGettingData.TabIndex = 4;
            this.btnGettingData.Text = "Stop Getting Data";
            this.btnGettingData.UseVisualStyleBackColor = true;
            this.btnGettingData.Click += new System.EventHandler(this.btnGettingData_Click);
            // 
            // btnCheckNow
            // 
            this.btnCheckNow.Location = new System.Drawing.Point(563, 138);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new System.Drawing.Size(160, 44);
            this.btnCheckNow.TabIndex = 4;
            this.btnCheckNow.Text = "Check Now";
            this.btnCheckNow.UseVisualStyleBackColor = true;
            this.btnCheckNow.Click += new System.EventHandler(this.btnCheckNow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.btnGettingData);
            this.Controls.Add(this.btnStopApp);
            this.Controls.Add(this.btnCheckNow);
            this.Controls.Add(this.btnStartApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericCheckTime);
            this.Controls.Add(this.lbLogs);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Sender - Cancellation Token";
            ((System.ComponentModel.ISupportInitialize)(this.numericCheckTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.NumericUpDown numericCheckTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartApp;
        private System.Windows.Forms.Button btnStopApp;
        private System.Windows.Forms.Button btnGettingData;
        private System.Windows.Forms.Button btnCheckNow;
    }
}
