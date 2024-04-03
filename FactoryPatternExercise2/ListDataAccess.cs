using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "character model", Price = 500},
                new Product(){Name = "accessory model", Price = 15},
                    new Product(){Name = "building model", Price = 100}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from List");
        }
    }
}
