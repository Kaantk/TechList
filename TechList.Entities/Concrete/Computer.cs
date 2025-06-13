using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechList.Entities.Concrete
{
    public class Computer
    {
        [Key]
        public int Id { get; set; }

        // Foreign Key - Inventory ile bire-bir ilişki
        [ForeignKey("Inventory")]
        public int InventoryId { get; set; }

        public string ComputerName { get; set; }
        public string UserName { get; set; }
        public string IPAddress { get; set; }
        public string Description { get; set; }
        public bool? EDigitalSignature { get; set; }
        public bool? UsbEnabled { get; set; }

        // Navigation property
        public virtual Inventory? Inventory { get; set; }
    }
}
