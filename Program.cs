Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b1 - b2) / (k2 - k1);
double y = (k2 * b1 - k1 * b2) / (k2 - k1);
if(k1 == k2)
{
   Console.Write("Прямые параллельны! ");
}
else
{
   Console.Write($"Точка пересечения прямых: ( {x}; {y} ) ");
}