using RestClientLibray.Dtos;
using RestClientLibray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientLibray
{
   public static class DtoExtension
    {

        public static ProductDto ToDto(this ProductModel product)
        {
            return new ProductDto(
                product.Id,
                product.Identifier,
                product.Description,
                product.DescriptionEN,
                product.Price,
                product.Unit,
                product.AvailableSTK,
                product.Vat,
                product.Inactive,
                product.ComponentType
            );
        }
    }
}
