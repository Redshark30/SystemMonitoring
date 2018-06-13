using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;


namespace SystemMonitoring
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
            CreateServiceDGV();
        }

        private void CreateServiceDGV()
        {

            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                ServiceDGV.Rows.Add(service.ServiceName, service.DisplayName, service.Status);
            }
        }

        private void ServiceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //Get & kill
                DialogResult terminer = MessageBox.Show("Etes-vous sûr(e) de vouloir arrêter ce service ?", "Attention",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (terminer == DialogResult.Yes)
                {
                    try
                    {
                        string svcName = ServiceDGV.CurrentRow.Cells[1].FormattedValue.ToString();
                        
                        RefreshServiceDGV();

                    }
                    catch
                    {
                    }
                }
                RefreshServiceDGV();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshServiceDGV();
        }
        private void RefreshServiceDGV()
        {
            ServiceDGV.Rows.Clear();
            CreateServiceDGV();
        }
    }
}
