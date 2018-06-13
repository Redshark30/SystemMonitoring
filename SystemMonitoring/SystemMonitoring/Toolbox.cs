using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitoring
{
    public partial class Toolbox : Form
    {
        public Toolbox()
        {
            InitializeComponent();
        }
        
        private void StartProcess(string ProcessName, string arguments)
        {
            Process process = new Process();
            process.StartInfo.FileName = ProcessName;
            process.StartInfo.Arguments = arguments;
            process.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StartProcess(@"cmd.exe", @"/C %SystemRoot%\system32\taskschd.msc");
        }

        private void Shutdown(int time)
        {
            string delay = (@"/C shutdown -s -t " + time).ToString();
            StartProcess("cmd.exe", delay);
        }
        private void Restart(int time)
        {
            string delay = (@"/C shutdown -r -t " + time).ToString();
            StartProcess("cmd.exe", delay);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartProcess("cmd.exe", "");
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            StartProcess(@"powershell.exe" , "(New-Object -ComObject Microsoft.Update.AutoUpdate).DetectNow()");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartProcess(@"cmd.exe", @"/C control panel");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartProcess(@"cmd.exe", @"/C start ms-settings:");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StartProcess(@"C:\Windows\regedit.exe", null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(textBox1.Text);
            time = time * 60;
            Restart(time);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(textBox2.Text);
            time = time * 60;
            Shutdown(time);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StartProcess(@"dsa.msc", null);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StartProcess(@"cmd.exe", @"/C shutdown -a");
        }
    }
}
