int n = 10;
int factorial = Factorial(n);
int Factorial(int n)
{
    if (n == 1)
        return 1;
    else
        return n * Factorial(n - 1);
}
Console.WriteLine(factorial);
