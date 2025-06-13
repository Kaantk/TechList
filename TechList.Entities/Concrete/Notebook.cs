using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechList.Entities.Concrete
{
    public class Notebook
    {
        [Key]
        public int NotebookId { get; set; }

        // Foreign Key - Inventory ile bire-bir ilişki
        [ForeignKey("Inventory")]
        public int InventoryId { get; set; }

        public int AssetNo { get; set; }
        public string NotebookName { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }

        // Navigation property
        public virtual Inventory? Inventory { get; set; }
    }
}
