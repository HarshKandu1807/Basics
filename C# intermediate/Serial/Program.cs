using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serial
{
    public class Product
    {
        public int ID { get; set; }
        public String Name { get; set; }
        [JsonProperty("Amount")]
        public decimal Price { get;set; }
        
        public DateTime Datetime { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product
            {
                ID = 1,
                Name = "Chocolate",
                Price = 30,
                Datetime = DateTime.Now
            };
            String ob = JsonConvert.SerializeObject(prod,Formatting.Indented);
            Console.WriteLine(ob);
            Product ob1 = JsonConvert.DeserializeObject<Product>(ob);
            Console.WriteLine(ob1.ID);
            Console.WriteLine(ob1.Name);
        }
    }
}
