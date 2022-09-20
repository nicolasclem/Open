
//Ej N°1
Console.WriteLine("=========*****EJ N°1*****=======");

Console.WriteLine("Dime tu nombre: ");
string name = Console.ReadLine();
Console.WriteLine("Dime tu edad:");
int age =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cual es tu peso actual :  (kg, grs)");
float pesoActual = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Tu nombre es " + name +" tienes " +age+ " años de edad"+ " y tu peso actual es de " + pesoActual +" kg");

//Ej N°2
Console.WriteLine("=========*****EJ N°2*****=======");

//coche

int puertas = 2;
    int ruedas = 4;
    string marca = "Toyota";
    bool itv = false;

// mesa

    float peso = 12.850f;
    int largo = 235;//en centimetros;
    string material = "madera";
    string color = "Marron";


Console.WriteLine("Nuestro coche tiene: " + puertas + " puertas "+ ruedas  + " ruedas "+ " es marca " + marca + " y el estadod e ITV es : " + itv);

Console.WriteLine("Descripcion de mi mesa : " + peso + "kg " + largo + "cm " + " es de :  " + material + " color: " + color);


//Ej N°3

int num = 15;
char a = 'b';


int num1 = 20;
char b = 'a';

Console.WriteLine("=========*****EJ N°3*****=======");

Console.WriteLine(num >= 18);
Console.WriteLine(num1 >= 18);
Console.WriteLine(a == 'a');
Console.WriteLine(b == 'a');
Console.WriteLine((num1 >=18)&&(b=='a'));
Console.WriteLine((num1 >= 18) || (a == 'a'));
