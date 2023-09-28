// Известна длина окружности. Найти площадь круга, ограниченного этой окружностью.
Console.Write("Введите длину окружности =");
double q = Convert.ToDouble(Console.ReadLine());
double s = Math.Pow((1 / 2), 2) / Math.PI;
Console.Write($"Площадь вписанного круга ={s}");