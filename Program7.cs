// стр 20 № 8
Console.Write("Введите a =");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b =");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c =");
double c = Convert.ToDouble(Console.ReadLine());
double n = 0;
if (a > 0) { n = n + 1; }
if (b > 0)  { n = n + 1; }
if (c > 0)  { n = n + 1; }
Console.WriteLine($"Количество положительных чисел {n}");
