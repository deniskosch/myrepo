using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MonitoringEF.Data;
using MonitoringEF.Models; // Подключение моделей

namespace MonitoringEF
{
    public partial class ReportsForm : Form
    {
        private readonly ApplicationDbContext _context;

        public ReportsForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        // Метод генерации отчета
        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date.AddDays(1).AddTicks(-1); // Чтобы захватить весь день

            try
            {
                // Фильтрация данных по диапазону дат
                var usageData = _context.EquipmentUsages
                        .Include(eu => eu.FertilizerType)
                        .Include(eu => eu.FuelType)
                        .Where(eu => eu.UsageDate >= startDate && eu.UsageDate <= endDate)
                        .ToList();

                if (!usageData.Any())
                {
                    MessageBox.Show("Данные за указанный период отсутствуют.");
                    return;
                }

                // Рассчитываем средние затраты на удобрения и топливо за один выезд
                var avgFertilizerCost = usageData.Average(eu => eu.FertilizerUsed * eu.FertilizerType.CostPerUnit);
                var avgFuelCost = usageData.Average(eu => eu.FuelUsed * eu.FuelType.CostPerUnit);

                // Рассчитываем общие затраты на один выезд (включая ремонт)
                var avgTotalCost = usageData.Average(eu =>
                    (eu.FertilizerUsed * eu.FertilizerType.CostPerUnit) +
                    (eu.FuelUsed * eu.FuelType.CostPerUnit) +
                    (eu.RepairCost ?? 0));

                // Общие количества потраченного топлива и удобрений
                var totalFuelUsed = usageData.Sum(eu => eu.FuelUsed);
                var totalFertilizerUsed = usageData.Sum(eu => eu.FertilizerUsed);

                // Отображаем результаты
                resultFertilizerCostAvg.Text = avgFertilizerCost.ToString("F2");
                resultFuelCostAvg.Text = avgFuelCost.ToString("F2");
                resultTotalCostAvg.Text = avgTotalCost.ToString("F2");
                resultFuelSum.Text = totalFuelUsed.ToString("F2");
                resultFertilizerSum.Text = totalFertilizerUsed.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при генерации отчета: {ex.Message}");
            }
        }
    }
}
