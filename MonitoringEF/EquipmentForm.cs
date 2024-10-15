using MonitoringEF.Data;
using MonitoringEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MonitoringEF
{
    public partial class EquipmentForm : Form
    {
        private readonly ApplicationDbContext _context;

        public EquipmentForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            LoadEquipmentData();
        }

        private void LoadEquipmentData()
        {
            dataGridViewEquipment.DataSource = _context.Equipment.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var equipment = new Equipment
            {
                Name = txtName.Text,
                FertilizerTankCapacity = Convert.ToDouble(txtFertilizerTankCapacity.Text),
                FuelTankCapacity = Convert.ToDouble(txtFuelTankCapacity.Text),
                EnginePower = Convert.ToDouble(txtEnginePower.Text),
                LoadCapacity = Convert.ToDouble(txtLoadCapacity.Text),
                EquipmentType = txtEquipmentType.Text
            };

            _context.Equipment.Add(equipment);
            _context.SaveChanges();
            LoadEquipmentData();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewEquipment.SelectedRows[0];
                var equipmentId = (int)selectedRow.Cells[0].Value;
                var equipment = _context.Equipment.Find(equipmentId);

                if (equipment != null)
                {
                    equipment.Name = txtName.Text;
                    equipment.FertilizerTankCapacity = Convert.ToDouble(txtFertilizerTankCapacity.Text);
                    equipment.FuelTankCapacity = Convert.ToDouble(txtFuelTankCapacity.Text);
                    equipment.EnginePower = Convert.ToDouble(txtEnginePower.Text);
                    equipment.LoadCapacity = Convert.ToDouble(txtLoadCapacity.Text);
                    equipment.EquipmentType = txtEquipmentType.Text;

                    _context.SaveChanges();
                    LoadEquipmentData();
                    ClearInputs();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewEquipment.SelectedRows[0];
                var equipmentId = (int)selectedRow.Cells[0].Value;
                var equipment = _context.Equipment.Find(equipmentId);

                if (equipment != null)
                {
                    _context.Equipment.Remove(equipment);
                    _context.SaveChanges();
                    LoadEquipmentData();
                    ClearInputs();
                }
            }
        }

        private void dataGridViewEquipment_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewEquipment.SelectedRows[0];
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtFertilizerTankCapacity.Text = selectedRow.Cells[2].Value.ToString();
                txtFuelTankCapacity.Text = selectedRow.Cells[3].Value.ToString();
                txtEnginePower.Text = selectedRow.Cells[4].Value.ToString();
                txtLoadCapacity.Text = selectedRow.Cells[5].Value.ToString();
                txtEquipmentType.Text = selectedRow.Cells[6].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtFertilizerTankCapacity.Clear();
            txtFuelTankCapacity.Clear();
            txtEnginePower.Clear();
            txtLoadCapacity.Clear();
            txtEquipmentType.Clear();
        }
    }
}
