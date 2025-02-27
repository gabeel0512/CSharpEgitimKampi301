using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.BusinessLayer.Abstact
{
    public interface IProductService: IGenericService<Product>
    {
        List<object> TGetProductWithCategory();
    }
}
