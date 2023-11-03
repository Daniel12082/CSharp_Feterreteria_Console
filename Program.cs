using CSharp_Feterreteria_Console.Features;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.Clear();
        LinQ Function = new LinQ();
        Console.WriteLine("Menu Ferreterias");
        Console.WriteLine("1. Listar Productos");
        Console.WriteLine("2. Listar ProductosCon Menos Del Stock Minimo");
        Console.WriteLine("3. Productos Que Deben Comprarse");
        Console.WriteLine("4. Facturas Del Mes De Enero");
        Console.WriteLine("5. Detella Factura");
        Console.WriteLine("6. Total De Inventario");
        Console.WriteLine("7. Salir");
        Console.WriteLine("Ingrese Una Opcion");
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:
                Function.PrintInventories();
                break;
            case 2:
                Function.PrintInvMinStock();
                break;
            case 3:
                Function.BuyProduct();
                break;
            case 4:
                Function.CompareMonth();
                break;
            case 5:
                Function.DetailBill();
                break;
            case 6:
                Function.TotalInventory();
                break;
            case 7:
                Console.WriteLine("Gracias Por Usar El Programa");
                break;
            default:
                Console.WriteLine("Opcion No Valida");
                break;
        
        }
        // Function.PrintInventories();
        // Function.PrintInvMinStock();
        // Function.BuyProduct();
        // Function.CompareMonth();
        // Function.TotalInventory();
    }
}