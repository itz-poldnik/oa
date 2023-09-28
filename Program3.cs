// Даны два действительных числа х и у. Вычислить их сумму, разность, произведение и частное.
Console.Write("Введите первое число =");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число =");
int y = Convert.ToInt32(Console.ReadLine());
int sum = x + y;
int z = x - y;
int mul = x * y;
double c = Convert.ToDouble(x) / Convert.ToDouble(y);
Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Разность: {z}");
Console.WriteLine($"Произведение: {mul}");
Console.WriteLine($"Частное: {c}");
