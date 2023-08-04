using aula_poo01;
using System;
using System.Globalization;


Triangulo x, y;
double p, areaX, areaY;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X:");

x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y:");

y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

areaX = x.Area();
areaY = y.Area();

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));



if (areaY > areaX)
{
    Console.WriteLine("Maior área: Y");
}
else
{
    Console.WriteLine("Maior área: X");
}

