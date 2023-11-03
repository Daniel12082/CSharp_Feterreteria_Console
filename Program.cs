using CSharp_Feterreteria_Console.Features;

internal class Program
{

    private static void Main(string[] args)
    {
        var option = 0;
        while (option != 7){
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
        option = Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:
                Console.Clear();
                Function.PrintInventories();
                Console.WriteLine("\nPresione Enter Para Continuar");
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                Function.PrintInvMinStock();
                Console.WriteLine("\nPresione Enter Para Continuar");
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                Function.BuyProduct();
                Console.WriteLine("\nPresione Enter Para Continuar");
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Function.CompareMonth();
                Console.WriteLine("\nPresione Enter Para Continuar");
                Console.ReadKey();
                break;
            case 5:
                Console.Clear();
                // Function.DetailBill();
                break;
            case 6:
                Console.Clear();
                Function.TotalInventory();
                Console.WriteLine("\nPresione Enter Para Continuar");
                Console.ReadKey();
                break;
            case 7:
                Console.Clear();
                Console.WriteLine("Gracias Por Usar El Programa");
                Console.WriteLine("\nPresione Enter Para Continuar");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Opcion No Valida");
                break;
        }
        }
    }
}