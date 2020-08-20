using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.ServiceReference1;

namespace WebApplication.Controllers
{
    public class ProductController : ApiController
    {
        private static List<string> _products { get; set; }

		private static List<string> products
        {
			get
            {
				if (_products == null)
                {
                    _products = new List<string>();
                }
                return _products;
            }
        }

        public string GetString(string name)
        {
            return "Hello " + name;
        }

        [HttpGet]
        public bool AddProduct(string name)
        {

            return new Service1Client().AddProduct(name);
        }

        [HttpGet]
        public string[] GetProducts()
        {
            return new Service1Client().GetProducts();
        }

        [HttpGet]
		public string TestSoap(int value)
		{
            return new Service1Client().GetData(value);
		}

    }


}
