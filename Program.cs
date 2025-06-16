// See https://aka.ms/new-console-template for more information
string numero = "1234506";
string invertido = "";

int i = 0;

bool bandera = int.TryParse(numero, out i);

if (bandera && i > 0)
{
    foreach (char item in numero)
    {
        invertido = item + invertido;
    }
    Console.WriteLine("El numero invertido es: " + invertido);
}
else
{
    Console.WriteLine("\nLo ingresado no es válido");
}


