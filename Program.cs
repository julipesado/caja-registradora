const string NombreComercio = "KIOSCO JULI";
const decimal DescuentoAlto = 0.10m;
const decimal DescuentoMedio = 0.05m;
const decimal DescuentoEfectivo = 0.10m;
const decimal RecargoCredito = 0.15m;
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
            Console.WriteLine();
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

decimal subtotal = total;
decimal descuento = 0;

if (subtotal > 50000)
{
    descuento = subtotal * DescuentoAlto;
}
else if (subtotal > 20000)
{
    descuento = subtotal * DescuentoMedio;
}

decimal totalConDescuento = subtotal - descuento;
decimal recargo = 0;
bool medioPagoValido = false;
do
{
    Console.WriteLine();
    Console.WriteLine("Medio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Débito");
    Console.WriteLine("3 - Crédito");
    Console.Write("Opción: ");
    string medioPago = Console.ReadLine();
    switch (medioPago)
    {
        case "1":
            decimal descuentoEfectivo = totalConDescuento * DescuentoEfectivo;
            descuento += descuentoEfectivo;
            totalConDescuento -= descuentoEfectivo;
            medioPagoValido = true;
            break;

        case "2":
            medioPagoValido = true;
            break;

        case "3":
            recargo = totalConDescuento * RecargoCredito;
            totalConDescuento += recargo;
            medioPagoValido = true;
            break;

        default:
            Console.WriteLine("Opción inválida, ingresá de nuevo.");
            break;
    }

} while (!medioPagoValido);



Console.WriteLine();
for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();
Console.WriteLine($"       {NombreComercio}");
for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();
Console.WriteLine($"Cajero: {nombreCajero}");
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {subtotal}");
Console.WriteLine($"Descuento: {descuento}");
Console.WriteLine($"Recargo: {recargo}");

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();
Console.WriteLine($"TOTAL: {totalConDescuento}");
for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();


Console.ReadLine();