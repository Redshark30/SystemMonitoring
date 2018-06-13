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
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
            CreerProcessDGV();
        }

        public void CreerProcessDGV()
        {
            Process[] processList = Process.GetProcesses();
            foreach ( Process processus in processList)
            {               
                int memoire = 0;
                memoire = Convert.ToInt32(processus.PrivateMemorySize64);
                processDGV.Rows.Add(processus.ProcessName, processus.Id, memoire / 1024);
            }
            processDGV.Sort(processDGV.Columns[0], ListSortDirection.Ascending); 
        }

        private void processDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ProcessChoice = (DataGridView)sender;
            if (ProcessChoice.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DialogResult terminer = MessageBox.Show("Etes-vous sûr(e) de vouloir arrêter ce processus ?", "Attention",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (terminer == DialogResult.Yes)
                {
                    try
                    {
                        string pid = processDGV.CurrentRow.Cells[1].FormattedValue.ToString();
                        Process stop = Process.GetProcessById(Int32.Parse(pid));
                        stop.Kill();
                        refreshDgv();                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.ToString());
                    }
                }
                refreshDgv();
            }
        }

        public void refreshDgv()
        {
            processDGV.Rows.Clear();
            CreerProcessDGV();

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshDgv();
        }
    }
}
