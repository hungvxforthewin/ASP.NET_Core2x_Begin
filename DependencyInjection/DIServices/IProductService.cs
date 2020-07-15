using DIServices.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIServices
{
    public interface IProductService
    {
         List<ProductViewModel> GetAll();
    }
}
