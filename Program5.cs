// стр 20 №4
Console.Write("Введите x =");
double x=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y =");
double y = Convert.ToDouble(Console.ReadLine());
if (x > y) { y = x + y / 2; }
else { y = x * y * 2; }
if (x > y) { x = x * y * 2; } 
else { x = x + y / 2; }
Console.WriteLine($"Первое число ={x}, Второе число ={y}");
