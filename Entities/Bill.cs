using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Feterreteria_Console.Entities
{
    public class Bill
    {
        public int NroFact {get; set; }
        public DateOnly Date {get; set; }
        public int IdCustomer {get; set;}
        public int TotalBill {get; set;}
        public List<DetailBill> DetailBills { get; set; }
    }
}