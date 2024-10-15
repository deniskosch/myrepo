using System.ComponentModel.DataAnnotations;

namespace MonitoringEF.Models
{
    public class Consumable
    {
        [Key]
        public int ConsumableId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // Удобрение или Топливо
        public double CostPerUnit { get; set; }

        // Связи с EquipmentUsage
        public ICollection<EquipmentUsage> EquipmentUsagesAsFertilizer { get; set; }
        public ICollection<EquipmentUsage> EquipmentUsagesAsFuel { get; set; }
    }
}
