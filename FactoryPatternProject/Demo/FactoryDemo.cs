using FactoryPatternProject.Factories;
using FactoryPatternProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternProject.Demo
{
    public class FactoryDemo
    {
        private readonly IFactory factory;
        public FactoryDemo(IFactory factory)
        {
            this.factory = factory;
        }
        public void TestFactoryWithPromoProduct()
        {
            var products = new[] {
                    factory.Create<PromoProduct>(1, "Paper Weight", 90.00M, 20, 82.00M),
                    factory.Create<PromoProduct>(2, "Desk Calender", 170.00M, 10, 145.00M),
                    factory.Create<PromoProduct>(3, "James Clip 50 pc Box", 50.00M, 20, 45.00M),
                };
            foreach (var p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }
        public void TestFactoryWithOfferedroduct()
        {
            var products = new[]{ 
                factory.Create<OfferedProduct>(1, "Denim Fit Pants", 1900.00M, 170.00, new DateTime(2023, 4, 30)),
                factory.Create<OfferedProduct>(2, "T-Shirt", 1400.00M, 150.00, new DateTime(2023, 4, 20)),
                factory.Create<OfferedProduct>(3, "Casual Shirt", 1100.00M, 130.00, new DateTime(2023, 4, 22))
            };
            foreach (var p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
