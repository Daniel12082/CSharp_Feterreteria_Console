using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Feterreteria_Console.Entities
{
    public class DetailBill
    {
        public int Id {get; set; }
        public int NroBill { get; set; }
        public int IdProduct { get; set; }
        public int Amount {get; set;}
    }
}