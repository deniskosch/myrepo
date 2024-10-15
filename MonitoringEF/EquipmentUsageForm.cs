using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MonitoringEF.Data;
using MonitoringEF.Models;

namespace MonitoringEF
{
    public partial class EquipmentUsageForm : Form
    {
        private readonly ApplicationDbContext _context;

        public EquipmentUsageForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            LoadData();
        }

        private void LoadData()
        {
            // Загрузка оборудования в комбобокс
            var equipmentList = _context.Equipment.ToList();
            cmbEquipment.DataSource = null; // Сброс источника данных перед новой привязкой
            cmbEquipment.DataSource = equipmentList;
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.ValueMember = "EquipmentId";

            // Загрузка удобрений в комбобокс
            var fertilizerList = _context.Consumables.Where(c => c.Type == "Fertilizer").ToList();
            cmbFertilizer.DataSource = null; // Сброс источника данных перед новой привязкой
            cmbFertilizer.DataSource = fertilizerList;
            cmbFertilizer.DisplayMember = "Name";
            cmbFertilizer.ValueMember = "ConsumableId";

            // Загрузка топлива в комбобокс
            var fuelList = _context.Consumables.Where(c => c.Type == "Fuel").ToList();
            cmbFuel.DataSource = null; // Сброс источника данных перед новой привязкой
            cmbFuel.DataSource = fuelList;
            cmbFuel.DisplayMember = "Name";
            cmbFuel.ValueMember = "ConsumableId";

            // Загрузка данных использования оборудования
            RefreshEquipmentUsageGrid();
        }

        private void RefreshEquipmentUsageGrid()
        {
            // Загрузка данных с полными зависимостями
            var usageData = _context.EquipmentUsages
                .Include(e => e.Equipment)
                .Include(e => e.FertilizerType)
                .Include(e => e.FuelType)
                .ToList();

            // Привязка данных к DataGridView
            dataGridView1.DataSource = usageData;

            // Настройка колонок с ComboBox для отображения связей
            ConfigureEquipmentUsageGrid();
        }

        private void ConfigureEquipmentUsageGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UsageId",
                HeaderText = "ID использования",
                Name = "UsageId"
            });

            // Колонка для оборудования (с ComboBox)
            var equipmentColumn = new DataGridViewComboBoxColumn
            {
                DataSource = _context.Equipment.ToList(),
                DisplayMember = "Name",
                ValueMember = "EquipmentId",
                DataPropertyName = "EquipmentId",
                HeaderText = "Оборудование",
                Name = "Equipment"
            };
            dataGridView1.Columns.Add(equipmentColumn);

            // Колонка для удобрений (с ComboBox)
            var fertilizerColumn = new DataGridViewComboBoxColumn
            {
                DataSource = _context.Consumables.Where(c => c.Type == "Fertilizer").ToList(),
                DisplayMember = "Name",
                ValueMember = "ConsumableId",
                DataPropertyName = "FertilizerTypeId",
                HeaderText = "Удобрение",
                Name = "Fertilizer"
            };
            dataGridView1.Columns.Add(fertilizerColumn);

            // Колонка для топлива (с ComboBox)
            var fuelColumn = new DataGridViewComboBoxColumn
            {
                DataSource = _context.Consumables.Where(c => c.Type == "Fuel").ToList(),
                DisplayMember = "Name",
                ValueMember = "ConsumableId",
                DataPropertyName = "FuelTypeId",
                HeaderText = "Топливо",
                Name = "Fuel"
            };
            dataGridView1.Columns.Add(fuelColumn);

            // Колонка для даты использования
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UsageDate",
                HeaderText = "Дата использования",
                Name = "UsageDate"
            });

            // Колонка для использованного удобрения
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FertilizerUsed",
                HeaderText = "Использовано удобрений",
                Name = "FertilizerUsed"
            });

            // Колонка для использованного топлива
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FuelUsed",
                HeaderText = "Использовано топлива",
                Name = "FuelUsed"
            });

            // Колонка для отработанных часов
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HoursWorked",
                HeaderText = "Отработанные часы",
                Name = "HoursWorked"
            });

            // Колонка для пройденного расстояния
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DistanceCovered",
                HeaderText = "Пройденное расстояние (км)",
                Name = "DistanceCovered"
            });

            // Колонка для обработанной площади
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AreaCovered",
                HeaderText = "Обработанная площадь (га)",
                Name = "AreaCovered"
            });

            // Колонка для затрат на ремонт
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RepairCost",
                HeaderText = "Затраты на ремонт",
                Name = "RepairCost"
            });

            // Колонка для количества заправок
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Refills",
                HeaderText = "Количество заправок",
                Name = "Refills"
            });

            // Колонка для комментариев оператора
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OperatorComments",
                HeaderText = "Комментарии оператора",
                Name = "OperatorComments"
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var equipmentUsage = new EquipmentUsage
            {
                EquipmentId = (int)cmbEquipment.SelectedValue,
                FertilizerTypeId = (int)cmbFertilizer.SelectedValue,
                FuelTypeId = (int)cmbFuel.SelectedValue,
                UsageDate = dateTimePicker.Value,
                FertilizerUsed = (double)nudFertilizerUsed.Value,
                FuelUsed = (double)nudFuelUsed.Value,
                HoursWorked = (double)nudHoursWorked.Value,
                DistanceCovered = (double)nudDistanceCovered.Value,
                AreaCovered = (double)nudAreaCovered.Value,
                RepairCost = nudRepairCost.Value == 0 ? (double?)null : (double)nudRepairCost.Value,
                Refills = (int)nudRefills.Value,
                OperatorComments = txtComments.Text
            };

            _context.EquipmentUsages.Add(equipmentUsage);
            _context.SaveChanges();
            RefreshEquipmentUsageGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            // Получение выбранного элемента EquipmentUsage
            var selectedUsage = (EquipmentUsage)dataGridView1.CurrentRow.DataBoundItem;

            // Обновление значений вручную перед сохранением
            cmbEquipment.SelectedValue = selectedUsage.EquipmentId;
            cmbFertilizer.SelectedValue = selectedUsage.FertilizerTypeId;
            cmbFuel.SelectedValue = selectedUsage.FuelTypeId;

            // Явное обновление значений ComboBox перед сохранением
            selectedUsage.EquipmentId = (int)cmbEquipment.SelectedValue;
            selectedUsage.FertilizerTypeId = (int)cmbFertilizer.SelectedValue;
            selectedUsage.FuelTypeId = (int)cmbFuel.SelectedValue;

            // Обновление остальных полей
            selectedUsage.UsageDate = dateTimePicker.Value;
            selectedUsage.FertilizerUsed = (double)nudFertilizerUsed.Value;
            selectedUsage.FuelUsed = (double)nudFuelUsed.Value;
            selectedUsage.HoursWorked = (double)nudHoursWorked.Value;
            selectedUsage.DistanceCovered = (double)nudDistanceCovered.Value;
            selectedUsage.AreaCovered = (double)nudAreaCovered.Value;
            selectedUsage.RepairCost = nudRepairCost.Value == 0 ? (double?)null : (double)nudRepairCost.Value;
            selectedUsage.Refills = (int)nudRefills.Value;
            selectedUsage.OperatorComments = txtComments.Text;

            // Сохранение изменений в базе данных
            _context.SaveChanges();

            // Обновление отображения данных
            RefreshEquipmentUsageGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var selectedUsage = (EquipmentUsage)dataGridView1.CurrentRow.DataBoundItem;
            _context.EquipmentUsages.Remove(selectedUsage);
            _context.SaveChanges();
            RefreshEquipmentUsageGrid();
        }
    }
}
