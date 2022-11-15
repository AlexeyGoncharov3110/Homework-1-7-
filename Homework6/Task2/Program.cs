Console.WriteLine("Введите число b1");
bool isParsedNum1 = double.TryParse(Console.ReadLine(), out double b1);
if (!isParsedNum1)
{
    Console.WriteLine("Не правильно введенны данные , повторите ввод");
}
Console.WriteLine("Введите число k1");
bool isParsedNum2 = double.TryParse(Console.ReadLine(), out double k1);
if (!isParsedNum2)
{
    Console.WriteLine("Не правильно введенны данные , повторите ввод");
}
Console.WriteLine("Введите число b2");
bool isParsedNum3 = double.TryParse(Console.ReadLine(), out double b2);
if (!isParsedNum3)
{
    Console.WriteLine("Не правильно введенны данные , повторите ввод");
}
Console.WriteLine("Введите число k2");
bool isParsedNum4 = double.TryParse(Console.ReadLine(), out double k2);
if (!isParsedNum4)
{
    Console.WriteLine("Не правильно введенны данные , повторите ввод");
}

if ( k1 == k2 ||b1 == b2)
{
    Console.WriteLine("Не правильно введены данные, прямые не пересекаются");
}
else
{
    (double, double) intersectionCoordinates = IntersectionCoordinates(b1, k1, b2, k2);
    (double, double) IntersectionCoordinates(double num1, double num2, double num3, double num4)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        return (x, y);
    }
    Console.WriteLine($"Координаты точки пересечения [{intersectionCoordinates.Item1} ; {intersectionCoordinates.Item2}]");
}
 