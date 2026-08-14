const string NombreComercio = "KIOSCO JULI";
Console.WriteLine($"=== {NombreComercio} ===");
Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta.");

Console.Write("Nombre del producto: ");
string nombreProducto = Console.ReadLine();
Console.Write("Precio: ");
decimal precioProducto = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Producto cargado: {nombreProducto} - ${precioProducto}");


Console.ReadLine();