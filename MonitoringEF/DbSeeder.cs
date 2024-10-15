using MonitoringEF.Data;
using MonitoringEF.Models;
using System;
using System.Linq;

namespace MonitoringEF
{
    public static class DbSeeder
    {
        public static void SeedDatabase(ApplicationDbContext context)
        {
            // Проверяем, есть ли уже данные в таблице Equipment
            if (!context.Equipment.Any())
            {
                // Если нет данных, добавляем 10 строк для Equipment
                context.Equipment.AddRange(
                    new Equipment { Name = "Tractor A", FertilizerTankCapacity = 500, FuelTankCapacity = 200, EnginePower = 250, LoadCapacity = 3000, EquipmentType = "Tractor" },
                    new Equipment { Name = "Harvester B", FertilizerTankCapacity = 0, FuelTankCapacity = 300, EnginePower = 400, LoadCapacity = 5000, EquipmentType = "Harvester" },
                    new Equipment { Name = "Sprayer C", FertilizerTankCapacity = 1000, FuelTankCapacity = 100, EnginePower = 120, LoadCapacity = 1000, EquipmentType = "Sprayer" },
                    new Equipment { Name = "Loader D", FertilizerTankCapacity = 0, FuelTankCapacity = 150, EnginePower = 180, LoadCapacity = 2000, EquipmentType = "Loader" },
                    new Equipment { Name = "Plow E", FertilizerTankCapacity = 0, FuelTankCapacity = 0, EnginePower = 0, LoadCapacity = 500, EquipmentType = "Plow" },
                    new Equipment { Name = "Combine F", FertilizerTankCapacity = 0, FuelTankCapacity = 400, EnginePower = 500, LoadCapacity = 7000, EquipmentType = "Combine" },
                    new Equipment { Name = "Seeder G", FertilizerTankCapacity = 800, FuelTankCapacity = 50, EnginePower = 100, LoadCapacity = 800, EquipmentType = "Seeder" },
                    new Equipment { Name = "Tractor H", FertilizerTankCapacity = 600, FuelTankCapacity = 250, EnginePower = 300, LoadCapacity = 3500, EquipmentType = "Tractor" },
                    new Equipment { Name = "Harvester I", FertilizerTankCapacity = 0, FuelTankCapacity = 350, EnginePower = 450, LoadCapacity = 6000, EquipmentType = "Harvester" },
                    new Equipment { Name = "Sprayer J", FertilizerTankCapacity = 1200, FuelTankCapacity = 80, EnginePower = 150, LoadCapacity = 1500, EquipmentType = "Sprayer" }
                );

                context.SaveChanges();
            }

            // Проверяем, есть ли уже данные в таблице Consumables
            if (!context.Consumables.Any())
            {
                // Если нет данных, добавляем 10 строк для Consumables
                context.Consumables.AddRange(
                    new Consumable { Name = "Fertilizer Type 1", Type = "Fertilizer", CostPerUnit = 20.0 },
                    new Consumable { Name = "Fertilizer Type 2", Type = "Fertilizer", CostPerUnit = 25.0 },
                    new Consumable { Name = "Fertilizer Type 3", Type = "Fertilizer", CostPerUnit = 30.0 },
                    new Consumable { Name = "Fuel Type 1", Type = "Fuel", CostPerUnit = 1.5 },
                    new Consumable { Name = "Fuel Type 2", Type = "Fuel", CostPerUnit = 1.8 },
                    new Consumable { Name = "Fuel Type 3", Type = "Fuel", CostPerUnit = 2.0 },
                    new Consumable { Name = "Oil Type 1", Type = "Oil", CostPerUnit = 5.0 },
                    new Consumable { Name = "Oil Type 2", Type = "Oil", CostPerUnit = 6.0 },
                    new Consumable { Name = "Oil Type 3", Type = "Oil", CostPerUnit = 7.0 },
                    new Consumable { Name = "Lubricant Type 1", Type = "Lubricant", CostPerUnit = 8.0 }
                );

                context.SaveChanges();
            }

            // Проверяем, есть ли уже данные в таблице EquipmentUsage
            if (!context.EquipmentUsages.Any())
            {
                // Если нет данных, добавляем 10 строк для EquipmentUsage
                context.EquipmentUsages.AddRange(
                    new EquipmentUsage { EquipmentId = 1, UsageDate = DateTime.Now.AddDays(-1), FertilizerUsed = 100, FuelUsed = 50, FertilizerTypeId = 1, FuelTypeId = 4, HoursWorked = 8, DistanceCovered = 30, AreaCovered = 5, RepairCost = 100, Refills = 2, OperatorComments = "Normal usage" },
                    new EquipmentUsage { EquipmentId = 2, UsageDate = DateTime.Now.AddDays(-2), FertilizerUsed = 200, FuelUsed = 75, FertilizerTypeId = 2, FuelTypeId = 5, HoursWorked = 6, DistanceCovered = 20, AreaCovered = 4, RepairCost = 150, Refills = 1, OperatorComments = "Minor repairs" },
                    new EquipmentUsage { EquipmentId = 3, UsageDate = DateTime.Now.AddDays(-3), FertilizerUsed = 50, FuelUsed = 40, FertilizerTypeId = 1, FuelTypeId = 6, HoursWorked = 10, DistanceCovered = 25, AreaCovered = 6, RepairCost = 50, Refills = 0, OperatorComments = "No issues" },
                    new EquipmentUsage { EquipmentId = 4, UsageDate = DateTime.Now.AddDays(-4), FertilizerUsed = 300, FuelUsed = 100, FertilizerTypeId = 3, FuelTypeId = 4, HoursWorked = 5, DistanceCovered = 15, AreaCovered = 3, RepairCost = 200, Refills = 3, OperatorComments = "Heavy usage" },
                    new EquipmentUsage { EquipmentId = 5, UsageDate = DateTime.Now.AddDays(-5), FertilizerUsed = 150, FuelUsed = 60, FertilizerTypeId = 1, FuelTypeId = 5, HoursWorked = 7, DistanceCovered = 22, AreaCovered = 4, RepairCost = 120, Refills = 2, OperatorComments = "Average usage" },
                    new EquipmentUsage { EquipmentId = 6, UsageDate = DateTime.Now.AddDays(-6), FertilizerUsed = 250, FuelUsed = 80, FertilizerTypeId = 2, FuelTypeId = 6, HoursWorked = 9, DistanceCovered = 28, AreaCovered = 5, RepairCost = 80, Refills = 1, OperatorComments = "Good performance" },
                    new EquipmentUsage { EquipmentId = 7, UsageDate = DateTime.Now.AddDays(-7), FertilizerUsed = 100, FuelUsed = 30, FertilizerTypeId = 1, FuelTypeId = 4, HoursWorked = 8, DistanceCovered = 18, AreaCovered = 2, RepairCost = 0, Refills = 0, OperatorComments = "Minimal use" },
                    new EquipmentUsage { EquipmentId = 8, UsageDate = DateTime.Now.AddDays(-8), FertilizerUsed = 180, FuelUsed = 90, FertilizerTypeId = 2, FuelTypeId = 5, HoursWorked = 11, DistanceCovered = 23, AreaCovered = 4, RepairCost = 90, Refills = 2, OperatorComments = "Regular checks" },
                    new EquipmentUsage { EquipmentId = 9, UsageDate = DateTime.Now.AddDays(-9), FertilizerUsed = 120, FuelUsed = 70, FertilizerTypeId = 3, FuelTypeId = 6, HoursWorked = 7, DistanceCovered = 27, AreaCovered = 6, RepairCost = 150, Refills = 3, OperatorComments = "Maintenance needed" },
                    new EquipmentUsage { EquipmentId = 10, UsageDate = DateTime.Now.AddDays(-10), FertilizerUsed = 90, FuelUsed = 55, FertilizerTypeId = 1, FuelTypeId = 4, HoursWorked = 4, DistanceCovered = 14, AreaCovered = 2, RepairCost = 200, Refills = 2, OperatorComments = "All good" }
                );

                context.SaveChanges();
            }
        }
    }
}
