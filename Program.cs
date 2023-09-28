// Найти площадь кольца, внутренний радиус которого равен r, а внешний - заданному числу R.
Console.Write("Введите внутренний радиус =");
double r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите внешний радиус =");
double r2 = Convert.ToInt32(Console.ReadLine());
double s = Math.PI * (Math.Pow(r2, 2) - Math.Pow(r1, 2));
Console.Write($"Площадь кольца ={s}");
