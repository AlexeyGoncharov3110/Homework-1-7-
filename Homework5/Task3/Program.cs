Console.WriteLine("Введите размер массива");
bool isParsedSize = int.TryParse(Console.ReadLine(), out int sizeArray);
if (!isParsedSize)
{
    Console.WriteLine("Вы ввели не корректные данные");
    return;
}
double[] array = new double[sizeArray];
FillArray(array);
PrintArray(array);
double maximumArrayNumber = MaximumArrayNumber(array);
double minimumArrayNumber = MinimumArrayNumber(array);
Console.WriteLine();
Console.WriteLine(maximumArrayNumber);
Console.WriteLine(minimumArrayNumber);
double theDifferenceBetweenMaximumAndMinimumNumber = maximumArrayNumber-minimumArrayNumber;
Console.WriteLine(theDifferenceBetweenMaximumAndMinimumNumber);
double MinimumArrayNumber(double[] arr)
{
    int i = 0;
    double min = arr[i];
    while (i < arr.Length)
    {
        if (arr[i] < min) min = arr[i];
        i++;
    }
    return min;
}
double MaximumArrayNumber(double[] arr)
{
    int i = 0;
    double max = arr[i];
    while (i < arr.Length)
    {
        if (arr[i] > max) max = arr[i];
        i++;
    }
    return max;
}
void FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.NextDouble() * (100 - 1);
    }
}
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}