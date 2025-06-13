using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using TechList.Business.Abstract;
using TechList.DataAccess.Abstract;
using TechList.Entities.Concrete;

namespace TechList.Business.Concrete
{
    public class IInventoryManager : IInventoryService
    {
        private readonly IInventoryDal _inventoryDal;

        public async Task TAddAsync(Inventory entity)
        {
            // Aynı demirbas numarası oncesinde kayıtlı mı kontrolu
            var existingInventory = await _inventoryDal.GetByIdAsync(entity.AssetNo);

            if (existingInventory != null)
                throw new Exception($"{entity.AssetNo} demirbaş numarası sistemde kayıtlıdır.");

            // Demirbas ismi nullable kontrolu
            if (string.IsNullOrEmpty(entity.AssetName))
                throw new Exception("Demirbaş ismi alanı boş geçilemez.");

            // Demirbas seri numarası nullable kontrolu
            if (string.IsNullOrEmpty(entity.SerialNumber))
                throw new Exception("Demirbaş seri numarası boş geçilemez.");

            // Demirbas bina ismi kontrolu
            if (string.IsNullOrEmpty(entity.BuildingName))
                throw new Exception("Demirbaş ismi alanı boş geçilemez.");

            // Demirbas marka ve ozellikleri kontrolu
            if (string.IsNullOrEmpty(entity.BrandModelSpecs))
                throw new Exception("Demirbaş marka ve özellikleri boş geçilemez.");

            entity.Status = true;
            entity.IsDeleted = false;
            entity.CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            entity.CreatedDate = DateTime.Now;
            entity.UpdatedDate = DateTime.Now;

            await _inventoryDal.AddAsync(entity);
        }

        public Task TDeleteAsync(Inventory entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Inventory>> TGetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Inventory> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task TSaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(Inventory entity)
        {
            throw new NotImplementedException();
        }
    }
}
