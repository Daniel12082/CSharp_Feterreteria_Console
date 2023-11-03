using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CSharp_Feterreteria_Console.Entities;
using System.Drawing;
using BetterConsoleTables;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharp_Feterreteria_Console.Features
{
    public class LinQ
    {
        List<Product> _products = new (){
            new(){Id=1, Name="screw", PriceUnit=500, Amount=300, StockMax=500, StockMin=100},
            new(){Id=2, Name="hammer", PriceUnit=1500, Amount=50, StockMax=400, StockMin=100},
            new(){Id=3, Name="wrench", PriceUnit=800, Amount=400, StockMax=600, StockMin=200},
            new(){Id=4, Name="nails", PriceUnit=300, Amount=1000, StockMax=1200, StockMin=800},
            new(){Id=5, Name="screwdriver", PriceUnit=600, Amount=350, StockMax=550, StockMin=150},
            new(){Id=6, Name="drill", PriceUnit=2000, Amount=150, StockMax=60, StockMin=50},
            new(){Id=7, Name="pliers", PriceUnit=700, Amount=250, StockMax=450, StockMin=150},
            new(){Id=8, Name="saw", PriceUnit=1800, Amount=180, StockMax=380, StockMin=80},
            new(){Id=9, Name="sander", PriceUnit=1200, Amount=100, StockMax=300, StockMin=50},
            new(){Id=10, Name="tape measure", PriceUnit=400, Amount=500, StockMax=700, StockMin=300},
            new(){Id=11, Name="paint brush", PriceUnit=300, Amount=20, StockMax=600, StockMin=200},
            new(){Id=12, Name="glue", PriceUnit=200, Amount=800, StockMax=1000, StockMin=500},
            new(){Id=13, Name="level", PriceUnit=900, Amount=150, StockMax=350, StockMin=100},
            new(){Id=14, Name="socket set", PriceUnit=1500, Amount=10, StockMax=250, StockMin=50},
            new(){Id=15, Name="paint roller", PriceUnit=400, Amount=300, StockMax=500, StockMin=200},
            new(){Id=16, Name="ladder", PriceUnit=3000, Amount=50, StockMax=150, StockMin=20},
            new(){Id=17, Name="tarp", PriceUnit=600, Amount=200, StockMax=400, StockMin=100},
            new(){Id=18, Name="circular saw", PriceUnit=2500, Amount=5, StockMax=200, StockMin=50},
            new(){Id=19, Name="gloves", PriceUnit=100, Amount=500, StockMax=800, StockMin=300},
            new(){Id=20, Name="rake", PriceUnit=350, Amount=400, StockMax=1, StockMin=200},
        };
        List<Bill> _bills = new(){
            new(){ NroFact =1234,Date = new DateOnly(2023, 11, 01), IdCustomer = 1, TotalBill=5000},
            new Bill { NroFact = 1235, Date = new DateOnly(2023, 11, 01), IdCustomer = 2, TotalBill = 6000 },
            new Bill { NroFact = 1236, Date = new DateOnly(2023, 01, 03), IdCustomer = 3, TotalBill = 7000 },
            new Bill { NroFact = 1237, Date = new DateOnly(2022, 02, 04), IdCustomer = 4, TotalBill = 8000 },
            new Bill { NroFact = 1238, Date = new DateOnly(2023, 03, 07), IdCustomer = 5, TotalBill = 9000 },
            new Bill { NroFact = 1239, Date = new DateOnly(2015, 11, 06), IdCustomer = 6, TotalBill = 10000 },
            new Bill { NroFact = 1240, Date = new DateOnly(2023, 05, 08), IdCustomer = 7, TotalBill = 11000 },
            new Bill { NroFact = 1241, Date = new DateOnly(2018, 11, 08), IdCustomer = 8, TotalBill = 12000 },
            new Bill { NroFact = 1242, Date = new DateOnly(2023, 01, 25), IdCustomer = 9, TotalBill = 13000 },
            new Bill { NroFact = 1243, Date = new DateOnly(2023, 11, 10), IdCustomer = 10, TotalBill = 14000 }
        };
        List<DetailBill> _detailBills = new(){
            new() { Id= 1, NroBill = 1234, IdProduct =1, Amount=4},
            new() { Id= 2, NroBill = 1234, IdProduct =2, Amount=2},
            new() { Id= 3, NroBill = 1243,IdProduct =4, Amount=20},
            new() { Id= 4, NroBill = 1243,IdProduct =5, Amount=10},
            new() { Id= 5, NroBill = 1242,IdProduct =2, Amount=2},
            new() { Id= 6, NroBill = 1239,IdProduct =7, Amount=24},
            new() { Id= 7, NroBill = 1240,IdProduct =11, Amount=10},
            new() { Id= 8, NroBill = 1238,IdProduct =12, Amount=2},
            new() { Id= 9, NroBill = 1236,IdProduct =2, Amount=4},
            new() { Id= 10, NroBill = 1242,IdProduct =24, Amount=6}
        };
        public void PrintInventories()
        {
            Console.WriteLine("LIST OF PRODUCTS");
            var table = new Table("ID","Name","Amount","Price");
            _products.ForEach(x => table.AddRow(x.Id,x.Name,x.Amount,x.PriceUnit));
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());
        }

        public void PrintInvMinStock()
        {
            var PrInvMinStock = (from x in _products where x.Amount < x.StockMin select x).ToList();
            Console.WriteLine("PRODUCTS ABOUT TO RUN OUT");
            var table = new Table("ID","Name");
            PrInvMinStock.ForEach(x => table.AddRow(x.Id,x.Name));
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());
        }

        public void BuyProduct()
        {
            Console.WriteLine("PRODUCTS THAT NEED TO BE PURCHASED");
            var PrInvMinStock = (from x in _products where x.Amount < x.StockMin select x).ToList();
            var table = new Table("ID","Name","Amount","Buy");
            PrInvMinStock.ForEach(x => table.AddRow(x.Id,x.Name,x.Amount,x.StockMax - x.Amount));
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());
        }
        public void CompareMonth()
        {
            var DateMin = (from x in _bills where x.Date.Month == 1 && x.Date.Year == 2023 select x).ToList();
            Console.WriteLine("Invoices from January 2023");
            var table = new Table("Nro Bill","Date","ID Customer","TotalBill");
            DateMin.ForEach(x => table.AddRow(x.NroFact,x.Date,x.IdCustomer,x.TotalBill));
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());
        }

        public void GetProductsFromReceipt()
        {
            Console.WriteLine("Put the number of the receipt: ");
            int number = Convert.ToInt32(Console.ReadLine());
            var list = (from q in _detailBills
                        join w in _detailBills
                        on q.NroBill equals w.NroBill
                        join e in _products on q.IdProduct equals e.Id
                        where w.NroBill == number
                        select new
                        {
                            IdProduct = q.IdProduct,
                            Amount = q.Amount,
                            Bill = q.NroBill,
                            Name = e.Name,
                            PriceUnit = e.PriceUnit,
                            Total = q.Amount * e.PriceUnit
                        }).ToList();
            if (_detailBills.Any(x => x.NroBill == number))
            {
                Console.WriteLine($"The products of the receipt number {number}");
                var table =  new Table("ID Product","Amount","Name","Price Unit","Total");
                list.ForEach(x=> table.AddRow(x.IdProduct,x.Amount,x.Name,x.PriceUnit,x.Total));
                table.Config = TableConfiguration.UnicodeAlt();
                Console.WriteLine(table.ToString());
            } else {
                Console.WriteLine($"The receipt number {number} does not exist");
            }
        }

        public void TotalInventory()
        {
            var total = 0;
            Console.WriteLine("TOTAL INVENTORY");
            var table = new Table("Name", "Amount", "Price Unit", "Total");
            foreach (var item in _products)
            {
                table.AddRow(item.Name, item.Amount, item.PriceUnit, item.PriceUnit * item.Amount);
                total += (item.Amount * item.PriceUnit);
            }
            table.Config = TableConfiguration.UnicodeAlt();
            Console.WriteLine(table.ToString());
            Console.WriteLine($"The total value of the inventory is: {total}");
        }
    }
}