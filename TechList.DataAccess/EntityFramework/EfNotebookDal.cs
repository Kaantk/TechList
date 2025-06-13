using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechList.DataAccess.Abstract;
using TechList.DataAccess.Repositories;
using TechList.Entities.Concrete;

namespace TechList.DataAccess.EntityFramework
{
    public class EfNotebookDal : GenericRepository<Notebook>, INotebookDal
    {
    }
}
