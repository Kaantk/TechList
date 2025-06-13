using System.Data;
using FluentValidation;
using TechList.Entities.Concrete;

namespace TechList.Web.Validators
{
    public class InventoryAddValidator : AbstractValidator<Inventory>
    {
        public InventoryAddValidator()
        {
            RuleFor(x => x.AssetNo)
                 .NotEmpty()
                 .WithMessage("Demirbaş numarası boş geçilemez.");

            RuleFor(x => x.AssetName)
                .NotEmpty()
                .WithMessage("Demirbaş ismi boş geçilemez.")
                .NotNull()
                .WithMessage("Demirbaş ismi boş geçilemez.");

            RuleFor(x => x.SerialNumber)
                .NotEmpty()
                .WithMessage("Seri numarası boş geçilemez.")
                .NotNull()
                .WithMessage("Seri numarası boş geçilemez.");

            RuleFor(x => x.BuildingName)
                .NotEmpty()
                .WithMessage("Lokasyon bilgisi boş geçilemez.")
                .NotNull()
                .WithMessage("Lokasyon bilgisi boş geçilemez.");

            RuleFor(x => x.BrandModelSpecs)
                .NotEmpty()
                .WithMessage("Marka, model ve özellikleri boş geçilemez.")
                .NotNull()
                .WithMessage("Marka, model ve özellikleri boş geçilemez.");
        }
    }
}
