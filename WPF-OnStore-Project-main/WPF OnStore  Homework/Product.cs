using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OnStore__Homework {
    public class Product {

        // Private Fields

        private Guid _productId;
        private string? _productName;
        private string? _productImageUrl;
        private double _productPrice;

        // Properties


        public Guid Id { get { return _productId; } set { _productId = value; } }
        public string? Name { get { return _productName; }
            set {
                if (value!.Length > 1) _productName = value;
                else throw new Exception("Product name can't be lower than 2 symbol !");
            }
        }
        public string? ImageUrl { get { return _productImageUrl; } set { _productImageUrl = value; } }
        public double Price { get { return _productPrice; } 
            set {
                if (value != 0) _productPrice = value;
                else throw new Exception("Product price can't be 0 amount");
            }
        }
        public string ShowPrice { get { return "$" + _productPrice.ToString(); } }

    }
}
