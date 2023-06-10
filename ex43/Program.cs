Console.Clear();
Console.Write("Введите k1: ");
double k1 = Double.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
double b1 = Double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = Double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = Double.Parse(Console.ReadLine()!);
double x= 0;
double y= 0;

if ((k1 == k2) && (b1 == b2))
Console.Write("Прямые совпадают");
else if (k1==k2)
Console.Write("Прямые параллельны");
else
{
    
x=(b2-b1)/(k1-k2);
y=(k1*(b2-b1))/(k1-k2)+b1;
x=Math.Round(x, 3);
y=Math.Round(y, 3);
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}
