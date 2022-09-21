//while
Console.WriteLine("Indica un numero ");

int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine("==============Inicio de tablas=========");
while (i <= 10)
{
    Console.WriteLine(i * num);
    i++;

}


//do while

Console.WriteLine("\n==============Ej 2=========");
int p = 0;
int Result = 0;
Console.WriteLine("Dime un numero :");
int numDW = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("=================== Contadores!!!=====================" +
    "");
if (numDW > 0)
{
    do
    {
        Result += p;
        p++;
    } while (p <= numDW);
}
else
{
    do
    {
        Result += p;
        p--;

    } while (p >= numDW);
}
Console.WriteLine(Result);


//for

Console.WriteLine("Alto: ");
int altura = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ancho: ");
int anchura = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Relleno:  (True o False)");
bool relleno = Convert.ToBoolean(Console.ReadLine());


if (relleno == false)
{
    for (int x = 1; x <= altura; x++)
    {
        for (int j = 1; j <= anchura; j++)
        {
            if ((x == 1 || x == altura) || (j == 1 || j == anchura))
            {
                Console.Write(" * ");
            }
            else
            {
                Console.Write("   ");
            }
        }
        Console.WriteLine(" ");
    }
}
else
{
    for (int x = 1; x <= altura; x++)
    {
        for (int j = 1; j <= anchura; j++)
        {
            Console.Write(" * ");
        }
        Console.WriteLine(" ");
    }
}

