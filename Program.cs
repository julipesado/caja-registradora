const string NombreComercio = "KIOSCO JULI";
Console.WriteLine($"=== {NombreComercio} ===");
Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta.");

decimal total = 0;
int cantidadProductos = 0;
bool ventaAbierta = true;

do
{
    Console.WriteLine();
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Opción: ");
    string opcion = Console.ReadLine();


    switch (opcion)
    {
        case "1":
            Console.Write("Nombre del producto: ");
            string nombreProducto = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precioProducto = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Producto cargado: {nombreProducto} -- ${precioProducto}");
            total += precioProducto;
            cantidadProductos++;
            break;

        case "2":
            ventaAbierta = false;
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (ventaAbierta);

Console.WriteLine();
Console.WriteLine($"Productos cargados: {cantidadProductos}");
Console.WriteLine($"Total: ${total}");

Console.ReadLine();