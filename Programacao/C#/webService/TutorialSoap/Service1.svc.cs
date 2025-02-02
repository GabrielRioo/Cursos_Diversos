﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TutorialSoap
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class Service1 : IService1
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

		public bool AddProduct(string name)
		{
			products.Add(name);
			return true;
		}

		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public List<string> GetProducts()
		{
			return products;
		}
	}
}
