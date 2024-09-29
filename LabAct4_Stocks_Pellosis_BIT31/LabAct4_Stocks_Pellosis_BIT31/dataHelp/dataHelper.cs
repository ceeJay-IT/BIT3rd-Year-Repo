using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataHelp
{
    public class dataHelper
    {
        public class Product
        {
            public string prodID { get; set; }
            public string prodName { get; set; }
            public int stocks { get; set; }
            public decimal basePrice { get; set; }

            public Product (string ID, string Name, int Stock, decimal Price)
            {
                prodID = ID;
                prodName = Name;
                stocks = Stock;
                basePrice = Price;
            }

            public decimal SRP => basePrice + (basePrice * 0.15m);

            public void decreaseStock(int quantity)
            { 
                stocks -= quantity;
            }
        }

        public ArrayList _product;

        public dataHelper()
        {
            _product = new ArrayList();
            PopulateData();
        }

        public void PopulateData()
        {
            _product.Add(new Product("MSE", "Mouse", 100, 350));
            _product.Add(new Product("PRN", "Printer Ink", 100, 7500));
            _product.Add(new Product("PRNDT", "Printer Dot Matrix", 100, 5000));
            _product.Add(new Product("MNTRLc", "LCD Monitor", 100, 6500));
            _product.Add(new Product("MNTRLe", "LED Monitor", 100, 7500));
        }

        public ArrayList getProducts()
        {
            return _product;
        }


        public class Calculation
        {
            public ArrayList products;

            public Calculation(dataHelper dataHelper)
            {
                products = new ArrayList();
            }

            public decimal CalculateTotal(List<(Product product, int quantity)> selectedProducts, string membershipType)
            {
                decimal total = 0;
                decimal discount = 0;

                foreach (var item in selectedProducts)
                {
                    var product = item.product;
                    int quantity = item.quantity;
                    total += product.SRP * quantity;
                }

                if (total > 10000)
                {
                    switch (membershipType)
                    {
                        case "Silver":
                            discount = 0.05m;
                            break;
                        case "Gold":
                            discount = 0.10m;
                            break;
                        case "Platinum":
                            discount = 0.15m;
                            break;
                    }
                }
                return total - discount;
            }
        }
    }
}
