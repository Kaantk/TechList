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
    public class IComputerManager : IComputerService
    {
        private readonly IComputerDal _computerDal;

        public Task TAddAsync(Computer entity)
        {
            throw new NotImplementedException();
        }

        public Task TDeleteAsync(Computer entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Computer>> TGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Computer> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task TSaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Computer entity)
        {
            throw new NotImplementedException();
        }
    }
}
