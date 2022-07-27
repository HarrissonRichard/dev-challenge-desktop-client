using Refit;
using RestClientLibray.Dtos;
using RestClientLibray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientLibray.Repository
{
    public interface IRekwestProductRepository
    {

        [Post("/products")]
        Task<ProductModel> CreateProduct([Body] ProductDto product, [Header("TENANT-ID")] string tenant, [Header("APPLICATION-ID")] string appid);

        [Put("/products/{id}")]
        Task<ProductModel> UpdateProduct(int id, [Body] ProductDto product, [Header("TENANT-ID")] string tenant, [Header("APPLICATION-ID")] string appid);

    }
}
