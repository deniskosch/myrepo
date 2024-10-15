using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonitoringEF.Models
{
    public class EquipmentUsage
    {
        [Key]
        public int UsageId { get; set; }

        [ForeignKey("Equipment")]
        public int EquipmentId { get; set; }

        [ForeignKey("FertilizerType")]
        public int FertilizerTypeId { get; set; }

        [ForeignKey("FuelType")]
        public int FuelTypeId { get; set; }

        public DateTime UsageDate { get; set; }
        public double FertilizerUsed { get; set; }
        public double FuelUsed { get; set; }
        public double HoursWorked { get; set; }
        public double DistanceCovered { get; set; }
        public double AreaCovered { get; set; }
        public double? RepairCost { get; set; }
        public int Refills { get; set; }
        public string OperatorComments { get; set; }

        // Навигационные свойства
        public Equipment Equipment { get; set; }
        public Consumable FertilizerType { get; set; }
        public Consumable FuelType { get; set; }
    }
}
