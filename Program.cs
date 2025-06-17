using System.Diagnostics;

Console.WriteLine("Ingrese una cadena de caracteres: ");
string cadena = Console.ReadLine();

int longitud = cadena.Length;

Console.WriteLine("Longitud: " + longitud);

Console.WriteLine("Ingrese otra cadena de caracteres: ");
string cadena2 = Console.ReadLine();

string concatenado = cadena + " " + cadena2;

string subcadena = cadena2.Substring(0, cadena2.Length / 2);

Console.WriteLine("----------CALCULADORA--------");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicacion");
Console.WriteLine("4. Division");

string operacion;
bool bandera;
int op;

do
{
    Console.Write("Seleccione la operacion a realizar: ");
    operacion = Console.ReadLine();
    bandera = int.TryParse(operacion, out op);
} while (op > 4 || op < 1 || !bandera);

Console.Write("Ingrese el primer numero: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
int n2 = int.Parse(Console.ReadLine());
int resultado;

switch (operacion)
{
    case "1":
        resultado = n1 + n2;
        Console.WriteLine($"La suma de {n1} y de {n2} es {resultado}");
        break;
    case "2":
        resultado = n1 - n2;
        Console.WriteLine($"La resta de {n1} y de {n2} es {resultado}");

        break;
    case "3":
        resultado = n1 * n2;
        Console.WriteLine($"La multiplicacion de {n1} y de {n2} es {resultado}");

        break;
    case "4":
        resultado = n1 / n2;
        Console.WriteLine($"La division de {n1} y de {n2} es {resultado}");

        break;
}

foreach (char letra in cadena)
{
    Console.WriteLine(letra);
}

Console.Write("Ingrese la palabra que desea buscar: ");
string palabra = Console.ReadLine();

if (cadena.Contains(palabra))
{
    Console.WriteLine("Si contiene.");
}
else
{
    Console.WriteLine("No contiene.");
}

cadena = cadena.ToUpper();
cadena = cadena.ToLower();


string cadenaSeparar = "ivan,matias,plata";
string[] cadenaSeparada = cadenaSeparar.Split(',');

Console.Write(cadenaSeparada);


