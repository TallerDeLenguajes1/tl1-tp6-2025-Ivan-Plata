
Console.Write("Ingrese un numero: ");
float numero = float.Parse(Console.ReadLine());


Console.WriteLine(Math.Abs(numero));
Console.WriteLine(numero * numero);
Console.WriteLine(Math.Sqrt(numero));
Console.WriteLine(Math.Sin(numero));
Console.WriteLine(Math.Cos(numero));
Console.WriteLine((int)numero);

Console.Write("Ingrese el primer numero: ");
float n1 = float.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine("El maximo es: " + Math.Max(n1, n2));
Console.WriteLine("El minimo es: " + Math.Min(n1, n2));