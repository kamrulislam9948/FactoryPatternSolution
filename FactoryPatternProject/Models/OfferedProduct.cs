using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternProject.Models
{
    public class OfferedProduct : IProduct
    {
        public OfferedProduct() { }
        public OfferedProduct(int id, string name, decimal price, double priceCut, DateTime offerEnd)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.PriceCut = priceCut;
            this.OfferEnd = offerEnd;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double PriceCut { get; set; }
        public DateTime OfferEnd { get; set; }
        public override string ToString()
        {
            return $"{Name} - regular price {Price:0.00}\nSpecial offer {(Price - (decimal)PriceCut):0.00}  till {OfferEnd:MMM dd, yyyy}";
        }
    }
}
