using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechList.Business.Abstract;
using TechList.DataAccess.Abstract;
using TechList.Entities.Concrete;

namespace TechList.Business.Concrete
{
    public class INotebookManager : INotebookService
    {
        private readonly INotebookDal _notebookDal;

        public Task TAddAsync(Notebook entity)
        {
            throw new NotImplementedException();
        }

        public Task TDeleteAsync(Notebook entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notebook>> TGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Notebook> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task TSaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Notebook entity)
        {
            throw new NotImplementedException();
        }
    }
}
