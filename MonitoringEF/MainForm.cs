using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringEF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenEquipmentForm_Click(object sender, EventArgs e)
        {
            EquipmentForm equipmentForm = new EquipmentForm();
            equipmentForm.Show();
        }

        private void OpenEquipmentUsageForm_Click(object sender, EventArgs e)
        {
            EquipmentUsageForm equipmentUsageForm = new EquipmentUsageForm();
            equipmentUsageForm.Show();
        }

        private void OpenConsumablesForm_Click(object sender, EventArgs e)
        {
            ConsumablesForm consumablesForm = new ConsumablesForm();
            consumablesForm.Show();
        }

        private void OpenReportsForm_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }
    }
}
