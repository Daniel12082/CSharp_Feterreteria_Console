using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Feterreteria_Console.Entities
{
    public class Product
    {
        public int Id {get; set; }
        public string Name {get; set; }
        public int PriceUnit  {get; set; }
        public int Amount {get; set; }
        public int StockMin {get; set;}
        public int StockMax {get; set; }
    }
}