using System.Collections.Generic;
using MvcAppTestToolsProject.Models;

namespace MvcAppTestToolsProject
{
    public class ShoppingCart
    {
        private readonly IValueCalculator _calc;

        public ShoppingCart(IValueCalculator calc)
        {
            _calc = calc;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal() => _calc.ValueProducts(Products);
    }
}