// стр 20 № 6
Console.Write("Введите m =");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите n =");
double n = Convert.ToDouble(Console.ReadLine());
if (m != n)
{
    if (m > n) { n = m; }
    else { m = n; }
}
else { m = 0; n = 0; }
Console.WriteLine($"m ={m}, n ={n}");
