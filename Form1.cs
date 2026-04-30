namespace AK400_Digital
{
    public partial class Form1 : Form
    {
        // found using zadig (usb driver installer)
        const int AK400_VENDOR_ID = 0x3633;
        const int AK400_PRODUCT_ID = 0x0001;
        // Variable for what to show on display
        string show = "cpuTemp";

        const int INTERVAL = 2; // in seconds
        private System.Windows.Forms.Timer? timer;

        bool allowExit = false;

        private HIDConnect? hid;
        private HardwareMonitor? hw;

        // main func
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_Close;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            hid = new HIDConnect(); // its always null
            hw = new HardwareMonitor(); // its always null
            StartApp();
        }

        private void StartApp()
        {
            bool ok = hid.Connect(AK400_VENDOR_ID, AK400_PRODUCT_ID);
            if (!ok)
            {
                statusBar.Text = "Status: Failed to connect!";
                return;
            }

            statusBar.Text = "Status: Connected";
            label_deviceInfo.Text = hid.GetDeviceInfo();
            StartLoop();
        }

        private void StartLoop()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = INTERVAL * 1000; // sec > ms

            timer.Tick += (s, e) => StartWork();
            timer.Start();
        }

        private void StartWork()
        {
            float cpuUsageValue = hw.getCpuUsage();
            float cpuTempValue = hw.getCpuTemp(); // temp in celsius

            label_cpuUsage.Text = $"CPU Usage: {(int)cpuUsageValue}%";
            label_cpuTemp.Text = $"CPU Temp: {(int)cpuTempValue}°C";

            if (show == "cpuUsage")
            {
                label_deviceStatus.Text = "Showing on Display: CPU Usage";
                hid.SendData(cpuUsageValue, 76);
            }
            else if (show == "cpuTemp")
            {
                label_deviceStatus.Text = "Showing on Display: CPU Temperature";
                hid.SendData(cpuTempValue, 19);
            }
        }

        private void displayCpuUsage_Click(object sender, EventArgs e)
        {
            if (show == "cpuUsage")
            {
                MessageBox.Show("Display is already showing CPU usage!");
                return;
            }

            show = "cpuUsage";
            MessageBox.Show("Display is now showing CPU usage.");
        }

        private void displayCpuTemp_Click(object sender, EventArgs e)
        {
            if (show == "cpuTemp")
            {
                MessageBox.Show("Display is already showing CPU temperature!");
                return;
            }

            show = "cpuTemp";
            MessageBox.Show("Display is now showing CPU temperature.");

        }

        private void Form1_Close(object? sender, FormClosingEventArgs e)
        {
            if (!allowExit)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void toolStripMenuShow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            allowExit = true;
            Application.Exit();
        }
    }
}
