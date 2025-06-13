using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechList.Entities.Concrete;

namespace TechList.DataAccess.Abstract
{
    public interface IInventoryDal : IGenericDal<Inventory>
    {
    }
}
