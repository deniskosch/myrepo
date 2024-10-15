using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MonitoringEF.Models
{
    public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public double FertilizerTankCapacity { get; set; }
        public double FuelTankCapacity { get; set; }
        public double EnginePower { get; set; }
        public double LoadCapacity { get; set; }
        public string EquipmentType { get; set; }

        // Связь с EquipmentUsage
        public ICollection<EquipmentUsage> EquipmentUsages { get; set; }
    }
}
