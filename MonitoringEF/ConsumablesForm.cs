using MonitoringEF.Data;
using MonitoringEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MonitoringEF
{
    public partial class ConsumablesForm : Form
    {
        private readonly ApplicationDbContext _context;

        public ConsumablesForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            LoadConsumablesData();
        }

        private void LoadConsumablesData()
        {
            dataGridViewConsumables.DataSource = _context.Consumables.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var consumable = new Consumable
            {
                Name = txtName.Text,
                Type = txtType.Text,
                CostPerUnit = Convert.ToDouble(txtPrice.Text)
            };

            _context.Consumables.Add(consumable);
            _context.SaveChanges();
            LoadConsumablesData();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsumables.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewConsumables.SelectedRows[0];
                var consumableId = (int)selectedRow.Cells[0].Value;
                var consumable = _context.Consumables.Find(consumableId);

                if (consumable != null)
                {
                    consumable.Name = txtName.Text;
                    consumable.Type = txtType.Text;
                    consumable.CostPerUnit = Convert.ToDouble(txtPrice.Text);

                    _context.SaveChanges();
                    LoadConsumablesData();
                    ClearInputs();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsumables.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewConsumables.SelectedRows[0];
                var consumableId = (int)selectedRow.Cells[0].Value;
                var consumable = _context.Consumables.Find(consumableId);

                if (consumable != null)
                {
                    _context.Consumables.Remove(consumable);
                    _context.SaveChanges();
                    LoadConsumablesData();
                    ClearInputs();
                }
            }
        }

        private void dataGridViewConsumables_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewConsumables.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewConsumables.SelectedRows[0];
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtType.Text = selectedRow.Cells[2].Value.ToString();
                txtPrice.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtType.Clear();
            txtPrice.Clear();
        }
    }
}
