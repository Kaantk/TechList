using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechList.Entities.Concrete
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        public int? OldAssetNo { get; set; }
        public int AssetNo { get; set; }
        public string AssetName { get; set; }   
        public string SerialNumber { get; set; }
        public string BuildingName { get; set; }
        public string BrandModelSpecs { get; set; }
        public bool? Status { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Navigation properties - Bire-bir ilişki
        public virtual Computer? Computer { get; set; }
        public virtual Notebook? Notebook { get; set; }
    }
}
