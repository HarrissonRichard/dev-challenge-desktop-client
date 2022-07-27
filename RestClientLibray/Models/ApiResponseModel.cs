using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientLibray.Models
{
   public class ApiResponseModel
    {
        public int Total { get; set; }
        public List<ProductModel> Data { get; set; }
    }
}
