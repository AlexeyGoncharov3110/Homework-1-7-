Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
double [] fibonachi= Fibonachi(number);
PrintArray(fibonachi);
double [] Fibonachi(int num)
{
    double [] array = new double[num];
    array[0]=1;
    array[1]=1;
    for (int i = 2; i < array.Length; i++)
    {
      array[i]= array[i-1]+ array[i-2]; 
    }
    return array;
}
void PrintArray(double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}


