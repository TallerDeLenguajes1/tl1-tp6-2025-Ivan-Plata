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
        Console.WriteLine("Resultado: " + resultado);
        break;
    case "2":
        resultado = n1 - n2;
        Console.WriteLine("Resultado: " + resultado);
        break;
    case "3":
        resultado = n1 * n2;
        Console.WriteLine("Resultado: " + resultado);
        break;
    case "4":
        resultado = n1 / n2;
        Console.WriteLine("Resultado: " + resultado);
        break;
}