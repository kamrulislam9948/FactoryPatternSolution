using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternProject.Models
{
    public class PromoProduct : IProduct
    {
        public PromoProduct() { }
        public PromoProduct(int id, string name, decimal price, int minimumQuantity, decimal bulkPrice)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.MinimumQuantity = minimumQuantity;
            this.BulkPrice = bulkPrice;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int MinimumQuantity { get; set; }
        public decimal BulkPrice { get; set; }


        public override string ToString()
        {
            return $"{Name} - regular price {Price:0.00}\nBuy {MinimumQuantity} @ {BulkPrice:0.00}";
        }
    }
}
