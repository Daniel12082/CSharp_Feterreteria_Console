using CSharp_Feterreteria_Console.Features;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.Clear();
        LinQ Function = new LinQ();
        // Function.PrintInventories();
        // Function.PrintInvMinStock();
        Function.BuyProduct();
    }
}