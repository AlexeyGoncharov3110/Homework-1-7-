Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int count = CountArray(i);
int[] binaryNumberArray = BinaryNumber(i, count);
PrintArray(binaryNumberArray);
int CountArray(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 2;
        count++;
    }
    return count;
}
int[] BinaryNumber(int num, int count)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[array.Length - 1 - i] = num % 2;
        num = num / 2;
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
