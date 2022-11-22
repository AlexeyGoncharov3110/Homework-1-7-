int[,] matrix = new int[10, 10]
{
    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
};
PrintMatrix(matrix);
Console.WriteLine();
FillMatrix(1, 1);
PrintMatrix(matrix);
void FillMatrix(int row, int col)
{
    if (matrix[row, col] == 0)
    {
        matrix[row, col] = 2;
        FillMatrix(row - 1, col);
        FillMatrix(row , col-1);
        FillMatrix(row + 1, col);
        FillMatrix(row , col+1);
    }
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == 0)
                Console.Write($" ");
            if(matr[i,j]==2)
            Console.Write($"V");
            else
                Console.Write($" + ");
        }
        Console.WriteLine();
    }
}
