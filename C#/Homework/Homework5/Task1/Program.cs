Console.WriteLine("Введите размер массива");
bool isParsedSize = int.TryParse(Console.ReadLine(), out int sizeArray);
if (!isParsedSize)
{
    Console.WriteLine("Вы ввели не корректные данные");
    return;
}
int[] array = new int[sizeArray];
FillArray(array);
PrintArray(array);
int numberOfEvenNumbers = NumberOfEvenNumbers(array);
Console.WriteLine();
Console.WriteLine(numberOfEvenNumbers);
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}
int NumberOfEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}
void FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
}