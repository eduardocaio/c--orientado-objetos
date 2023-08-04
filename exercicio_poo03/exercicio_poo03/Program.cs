using exercicio_poo03;
using System.Formats.Asn1;
using System.Globalization;


Retangulo retangulo = new Retangulo();


Console.WriteLine("Entre a largura e altura do retângulo:");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = retangulo.Area();

Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));

double perimetro = retangulo.Perimetro();

Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));

double diagonal = retangulo.Diagonal();

Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
