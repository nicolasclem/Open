//ej 1 leccion 5
//if

Console.WriteLine("Nombre: ");
string name = Console.ReadLine();

Console.WriteLine("Email: ");
string email = Console.ReadLine();

Console.WriteLine("Cupon: ");
bool cupon = Convert.ToBoolean(Console.ReadLine());

float price = 100f;
float desc = 0.15f;//desc del 15%

if (cupon)
{
    price = price - (price * desc);

    Console.WriteLine($"Hola  {name} ,el precio final aplicando su descuento  es de: $ {price}, enviaremos la oferta a : {email}");
}
else
{
    Console.WriteLine($"Hola  {name} ,el precio final es de: $ {price}, enviaremos la oferta a : {email}");
}

// ejer  N2  leccion 5
int i = 0;
List<string> lenguaje = new List<string>() { "JavaScript", "Kotlin", "C#" };


Console.WriteLine("Los Lenguajes  que Enseñamos: ");
foreach (var item in lenguaje)
{
    
    i++;
    Console.WriteLine($" {i}-{item}");
}
Console.WriteLine("Selecciona el lenguaje que mas te gusta!!");
string? eleccion = Console.ReadLine();

switch (eleccion)
{
    case "1":
        Console.WriteLine($"Enviaremos  toda la informacion a tu correo  sobre nuestro cursos de: {lenguaje[0]}");
        break;
    case "2":
        Console.WriteLine($"Enviaremos  toda la informacion a tu correo  sobre nuestro cursos de: {lenguaje[1]}");
        break;
    case "3":
        Console.WriteLine($"Enviaremos  toda la informacion a tu correo  sobre nuestro cursos de: {lenguaje[2]}");
        break;
    default:
        Console.WriteLine($"Opcion no encontrada , debes colocar los valores del 1  al  {i}");
        break;
}