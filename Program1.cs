// Даны два числа. Найдите среднее арифметическое кубов и среднее арифметическое модулей этих чисел.
Console.Write("Введите x1=");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2=");
int b = Convert.ToInt32(Console.ReadLine());
double x = (Math.Pow(a,3) + Math.Pow(b,3) / 2);
double y = Math.Sqrt(Math.Abs(a) * Math.Abs(b));
Comsole.Write($"среднее арифметическое: {x}");
Comsole.Write($"площадь геометрическое: {y}");