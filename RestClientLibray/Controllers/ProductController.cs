using Refit;
using RestClientLibray.Models;
using RestClientLibray.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientLibray.Controllers
{
   public class ProductController
    {

        public static async Task<List<ProductModel>> GetProducts()
        {
            string url = ConfigurationManager.AppSettings["API_LOCAL_URL"];
            var req = RestService.For<ILocalProductRepository>(url);

            var response = await req.GetProducts();
            return response.Data;
        }

        public static async Task<ProductModel> CreateLocalProduct(ProductModel product)
        {
            string url = ConfigurationManager.AppSettings["API_LOCAL_URL"];
            var req = RestService.For<ILocalProductRepository>(url);
            var createdProduct = await req.CreateProduct(product);
            return createdProduct;
        }
        public static async Task <ProductModel> UpdateLocalProduct(ProductModel product)
        {
            string url = ConfigurationManager.AppSettings["API_LOCAL_URL"];
            var req = RestService.For<ILocalProductRepository>(url);  
            var updatedProduct = await req.UpdateProduct(product.Id, product);
            return updatedProduct;
        }

        public static async Task<ProductModel> CreateRemoteProduct(ProductModel product)
        {
            string url = ConfigurationManager.AppSettings["API_REMOTE_URL"];
            string tenant = ConfigurationManager.AppSettings["TENANT-ID"];
            string appid = ConfigurationManager.AppSettings["APPLICATION-ID"];
            var req = RestService.For<IRekwestProductRepository>(url);
            var createdProduct = await req.CreateProduct(product.ToDto(), tenant, appid);
            return createdProduct;
        }
        public static async Task<ProductModel> UpdateRemoteProduct(ProductModel product)
        {
            string url = ConfigurationManager.AppSettings["API_REMOTE_URL"];
            string tenant = ConfigurationManager.AppSettings["TENANT-ID"];
            string appid = ConfigurationManager.AppSettings["APPLICATION-ID"];
            var req = RestService.For<IRekwestProductRepository>(url);
            var updatedProduct = await req.UpdateProduct(product.RemoteId, product.ToDto(), tenant, appid);
            return updatedProduct;
        }

    }
}
