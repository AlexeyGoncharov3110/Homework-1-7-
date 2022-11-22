Console.WriteLine("Введите колличество чисел");
bool isParsedNum = int.TryParse(Console.ReadLine(), out int number);
if (!isParsedNum)
{
    Console.WriteLine("Не правильно введенны данные , повторите ввод");
}

Console.WriteLine("Введите числа");
int sumPositivNumber = SumPositivNumber(number);
Console.WriteLine(sumPositivNumber);
int SumPositivNumber(int size)
{
    int[] array = new int[size];
    int moreThanZero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int dig = 0;
        bool isParsedDig = false;
        while (!isParsedDig)
        {
            isParsedDig = int.TryParse(Console.ReadLine(), out dig);
            if (!isParsedDig)
            {
                Console.WriteLine("Не правильно введенны данные , повторите ввод");
            }
            else
            {
                array[i]=dig;
                if (array[i]> 0) moreThanZero = moreThanZero + array[i];
            }
        }
    }
    return moreThanZero;
}

