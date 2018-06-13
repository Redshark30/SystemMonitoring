using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring
{
    public partial class Form1 : Form
    {
        private static PerformanceCounter cpuCounter;
        public Form1()
        {
            InitializeComponent();
            cpuValueLbl.Text = HardwareInfo.GetCpu();
            ramValueLbl.Text = HardwareInfo.GetRam();
            osValueLbl.Text = HardwareInfo.GetOS();
            gpuValueLbl.Text = HardwareInfo.GetGpu();
            ipValueLbl.Text = HardwareInfo.GetIp();
            SetMakerLogo();

            CpuPbar.Hide();
            RamPbar.Hide();

            cpuWorker = new BackgroundWorker();
            cpuWorker.DoWork += new DoWorkEventHandler(cpuWorker_DoWork);
            cpuWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(cpuWorker_RunWorkerCompleted);
            cpuWorker.ProgressChanged += new ProgressChangedEventHandler(cpuWorker_ProgressChanged);
            cpuWorker.WorkerReportsProgress = true;
            cpuWorker.WorkerSupportsCancellation = false;
            

            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

        }
        
        private static double GetMemoryUsage()
        {
            var pCntr = new PerformanceCounter("Memory", "Available KBytes");
            var memAvailable = (double)pCntr.NextValue();

            var memPhysical = HardwareInfo.GetPhysicalMemory();

            return Math.Round((memPhysical - memAvailable) * 100 / memPhysical, 0);
        }

        public void ListAllDrives()
        {
            DriveInfo[] GetDrive = DriveInfo.GetDrives();
            foreach (DriveInfo drive in GetDrive)
            {
                long total = 0;
                long available = 0;
                if (drive.DriveType == DriveType.Fixed)
                {
                    total = ((drive.TotalSize) / 1024) / 1024;
                    available = ((drive.AvailableFreeSpace) / 1024) / 1024;
                    DiskDGV.Rows.Add(drive.Name, drive.VolumeLabel, total, available);
                }
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void cpuWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {
                ramUsageLbl.Invoke(new Action(() =>
                {
                    ramUsageLbl.Text = Convert.ToInt32(GetMemoryUsage()).ToString() + "%";
                }));

                string CpuUsageStr = Convert.ToInt32(GetCpuUsage()).ToString() + " %";

                cpuUsageLbl.Invoke(new Action(() =>
                {
                    cpuUsageLbl.Text = CpuUsageStr;
                }));
                Thread.Sleep(100);
            }
        }
        public void SetCpuValue()
        {
            CpuPbar.Value = Convert.ToInt32(GetCpuUsage());
        }
        
        private void cpuWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void cpuWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }
        public static string CurrentCPUusage
        {
            get
            {
                return Convert.ToInt32(cpuCounter.NextValue()) + "%";
            }
        }
        public void SetMakerLogo()
        {
            if (HardwareInfo.cpuMaker == "Intel")
            {
                cpuMakerLogo.Image = SystemMonitoring.Properties.Resources.intel;
            }
            else
            {
                cpuMakerLogo.Image = SystemMonitoring.Properties.Resources.amd;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            ProcessForm processus = new ProcessForm();
            processus.Show();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            ServiceForm services = new ServiceForm();
            services.Show();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apropos apropos = new Apropos();
            apropos.Show();
        }

        private void infosGBox_Enter(object sender, EventArgs e)
        {

        }

        private void hddLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }
        private static double GetCpuUsage()
        {
            var processor = new ManagementObject("Win32_PerfFormattedData_PerfOS_Processor.Name='_Total'");
            processor.Get();

            return int.Parse(processor.Properties["PercentProcessorTime"].Value.ToString());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            cpuWorker.RunWorkerAsync();
            ListAllDrives();
        }

        private void ToolsBtn_Click(object sender, EventArgs e)
        {
            Toolbox tools = new Toolbox();
            tools.Show();
        }
    }
}
