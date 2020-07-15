using DIServices.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIServices
{
    public class BetterProductService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>()
            {
                new ProductViewModel{ID=1, Name="Better Pen Drive"},
                new ProductViewModel{ID=2, Name="Better Memory Card"},
                new ProductViewModel{ID=3, Name="Better Mobile Phone"},
                new ProductViewModel{ID=4, Name="Better Tablet"},
                new ProductViewModel{ID=5, Name="Better Desktop PC"},
            };
        }
    }
}
