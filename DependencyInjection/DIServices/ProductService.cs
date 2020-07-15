using DIServices.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIServices
{
    public class ProductService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>()
            {
                new ProductViewModel{ID=1, Name="Pen Drive"},
                new ProductViewModel{ID=2, Name="Memory Card"},
                new ProductViewModel{ID=3, Name="Mobile Phone"},
                new ProductViewModel{ID=4, Name="Tablet"},
                new ProductViewModel{ID=5, Name="Desktop PC"},
            };
        }
    }
}
