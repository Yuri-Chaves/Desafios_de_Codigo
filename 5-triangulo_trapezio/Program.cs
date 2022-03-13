using System.Globalization;


NumberFormatInfo provider = new NumberFormatInfo();
provider.NumberDecimalSeparator = ".";
provider.NumberGroupSeparator = ",";
provider.NumberGroupSizes = new int[] { 2 };
provider.NumberDecimalDigits = 1;

double a, b, c, perimetro, area;
string strPerimetro, strArea;
string[] valor = Console.ReadLine().Split(" ");

NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
nfi.NumberDecimalDigits = 1;

a = Convert.ToDouble(valor[0], provider);
b = Convert.ToDouble(valor[1], provider);
c = Convert.ToDouble(valor[2], provider);


if (IsTriangle(a, b, c))
{
    perimetro = a + b + c;
    strPerimetro = perimetro.ToString("N", nfi);
    Console.WriteLine($"Perimetro = {strPerimetro}");
}
if (!IsTriangle(a, b, c))
{
    area = ((a + b) * c) / 2;
    strArea = area.ToString("N", nfi);
    Console.WriteLine($"Area = {strArea}");
}


static bool IsTriangle(double a, double b, double c)
{
    if (a % b < c && a + b > c)
    {
        return true;
    }
    if (b % c < a && b + c > a)
    {
        return true;
    }
    if (b % a < c && b + a > c)
    {
        return true;
    }
    if (c % b < a && c + b > a)
    {
        return true;
    }
    return false;
}
Console.ReadKey();
