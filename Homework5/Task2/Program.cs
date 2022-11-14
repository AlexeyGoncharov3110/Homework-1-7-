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
int sumOfElementsInOddPositions= SumOfElementsInOddPositions(array);
Console.WriteLine();
Console.WriteLine(sumOfElementsInOddPositions);
int SumOfElementsInOddPositions(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2!=0) sum=sum +arr[i];
    }
    return sum;
}
void FillArray( int []arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= random.Next(-100,100);
    }
}
void PrintArray( int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}