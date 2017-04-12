using System.Collections.Generic;
using System.Linq;
using MvcAppTestToolsProject.Models;

namespace MvcAppTestToolsProject
{
    public class ProductCalc : IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products) => products.Sum(p => p.Price);
    }
}