namespace AK400_Digital
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusBar = new Label();
            label_cpuUsage = new Label();
            label_cpuTemp = new Label();
            groupBox1 = new GroupBox();
            displayCpuTemp = new Button();
            displayCpuUsage = new Button();
            groupBox2 = new GroupBox();
            label_deviceStatus = new Label();
            label_deviceInfo = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuIShow = new ToolStripMenuItem();
            toolStripMenuIExit = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.AutoSize = true;
            statusBar.Location = new Point(11, 345);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(124, 15);
            statusBar.TabIndex = 0;
            statusBar.Text = "Status: Not connected";
            // 
            // label_cpuUsage
            // 
            label_cpuUsage.AutoSize = true;
            label_cpuUsage.Location = new Point(6, 32);
            label_cpuUsage.Name = "label_cpuUsage";
            label_cpuUsage.Size = new Size(99, 15);
            label_cpuUsage.TabIndex = 2;
            label_cpuUsage.Text = "CPU Usage: ??? %";
            // 
            // label_cpuTemp
            // 
            label_cpuTemp.AutoSize = true;
            label_cpuTemp.Location = new Point(6, 58);
            label_cpuTemp.Name = "label_cpuTemp";
            label_cpuTemp.Size = new Size(100, 15);
            label_cpuTemp.TabIndex = 3;
            label_cpuTemp.Text = "CPU Temp: ??? °C";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_cpuTemp);
            groupBox1.Controls.Add(label_cpuUsage);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 90);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "System Info";
            // 
            // displayCpuTemp
            // 
            displayCpuTemp.Location = new Point(146, 70);
            displayCpuTemp.Name = "displayCpuTemp";
            displayCpuTemp.Size = new Size(134, 30);
            displayCpuTemp.TabIndex = 6;
            displayCpuTemp.Text = "Display CPU Temp";
            displayCpuTemp.UseVisualStyleBackColor = true;
            displayCpuTemp.Click += displayCpuTemp_Click;
            // 
            // displayCpuUsage
            // 
            displayCpuUsage.Location = new Point(6, 70);
            displayCpuUsage.Name = "displayCpuUsage";
            displayCpuUsage.Size = new Size(134, 30);
            displayCpuUsage.TabIndex = 5;
            displayCpuUsage.Text = "Display CPU Usage";
            displayCpuUsage.UseVisualStyleBackColor = true;
            displayCpuUsage.Click += displayCpuUsage_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_deviceStatus);
            groupBox2.Controls.Add(displayCpuTemp);
            groupBox2.Controls.Add(displayCpuUsage);
            groupBox2.Location = new Point(12, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 111);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // label_deviceStatus
            // 
            label_deviceStatus.AutoSize = true;
            label_deviceStatus.Location = new Point(6, 30);
            label_deviceStatus.Name = "label_deviceStatus";
            label_deviceStatus.Size = new Size(117, 15);
            label_deviceStatus.TabIndex = 7;
            label_deviceStatus.Text = "Showing on Display: ";
            // 
            // label_deviceInfo
            // 
            label_deviceInfo.AutoSize = true;
            label_deviceInfo.Location = new Point(6, 29);
            label_deviceInfo.Name = "label_deviceInfo";
            label_deviceInfo.Size = new Size(154, 15);
            label_deviceInfo.TabIndex = 9;
            label_deviceInfo.Text = "AK400 Digital isn't detected!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(271, 345);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 6;
            label2.Text = "Developed by @bishalqx980";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label_deviceInfo);
            groupBox3.Location = new Point(12, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(413, 117);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Device Info";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "! AK400 Digital ";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuIShow, toolStripMenuIExit });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 48);
            // 
            // toolStripMenuIShow
            // 
            toolStripMenuIShow.Name = "toolStripMenuIShow";
            toolStripMenuIShow.Size = new Size(103, 22);
            toolStripMenuIShow.Text = "Show";
            toolStripMenuIShow.Click += toolStripMenuShow_Click;
            // 
            // toolStripMenuIExit
            // 
            toolStripMenuIExit.Name = "toolStripMenuIExit";
            toolStripMenuIExit.Size = new Size(103, 22);
            toolStripMenuIExit.Text = "Exit";
            toolStripMenuIExit.Click += toolStripMenuExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 369);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "AK400 Digital";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statusBar;
        private Label label_cpuUsage;
        private Label label_cpuTemp;
        private GroupBox groupBox1;
        private Button displayCpuTemp;
        private Button displayCpuUsage;
        private GroupBox groupBox2;
        private Label label_deviceStatus;
        private Label label2;
        private Label label_deviceInfo;
        private GroupBox groupBox3;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuIShow;
        private ToolStripMenuItem toolStripMenuIExit;
    }
}
