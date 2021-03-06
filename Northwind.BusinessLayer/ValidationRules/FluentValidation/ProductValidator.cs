using FluentValidation;
using Northwind.EntitiesLayer.Concrete;
namespace Northwind.BusinessLayer.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Boş Geçilemez"); ;
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("0 ve ya 0 dan küçük olamaz"); ;
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.ProductName).Length(2,20);
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(x => x.CategoryId == 1);
            //RuleFor(p => p.ProductName).Must(StartWithA);
        }
        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}