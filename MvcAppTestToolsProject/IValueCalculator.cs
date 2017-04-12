using System.Collections.Generic;
using MvcAppTestToolsProject.Models;

namespace MvcAppTestToolsProject
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}