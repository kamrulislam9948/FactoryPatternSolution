using FactoryPatternProject.Demo;
using FactoryPatternProject.Factories;
using FactoryPatternProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new Factory();
            FactoryDemo demo = new FactoryDemo(factory);
            demo.TestFactoryWithPromoProduct();
            Console.WriteLine();
            demo.TestFactoryWithOfferedroduct();
            Console.ReadLine();
        }
    }
}


