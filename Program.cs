using CSharp_Feterreteria_Console.Features;

internal class Program
{

    private static void Main(string[] args)
        {
        try{
            var option = 0;
        while (option != 7){
        Console.Clear();
        LinQ Function = new LinQ();
        Console.WriteLine("Hardware Store Menu");
        Console.WriteLine("1. List Products");
        Console.WriteLine("2. List Products with Less than Minimum Stock");
        Console.WriteLine("3. Products to be Purchased");
        Console.WriteLine("4. Invoices from January");
        Console.WriteLine("5. Invoice Details");
        Console.WriteLine("6. Total Inventory");
        Console.WriteLine("7. Exit");
        Console.WriteLine("Enter an Option");
        option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Clear();
                Function.PrintInventories();
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                Function.PrintInvMinStock();
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                Function.BuyProduct();
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Function.CompareMonth();
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadKey();
                break;
            case 5:
                Console.Clear();
                Function.GetProductsFromReceipt();
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadKey();
                break;
            case 6:
                Console.Clear();
                Function.TotalInventory();
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadKey();
                break;
            case 7:
                Console.Clear();
                Console.WriteLine("Thank You for Using the Program");
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
            }
        }
        
        }catch(Exception){
            Console.WriteLine("Invalid Option");
        }
    }
}