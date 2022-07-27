using Refit;
using RestClientLibray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientLibray.Repository
{
    interface ILocalProductRepository
    {

        [Get("/products")]
        Task<ApiResponseModel> GetProducts();

        [Put("/products/{id}")]
        Task<ProductModel> UpdateProduct(int id, [Body] ProductModel product);

        [Post("/products")]
        Task<ProductModel> CreateProduct([Body] ProductModel product);
    }
}
