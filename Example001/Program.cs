// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillMatrix(double[,] table)
{
    for(int i=0; i < table.GetLength(0); i++)
    {
        for(int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = Math.Round(new Random().NextDouble()*10 - 3, 1);
        }
    }
}
void PrintMatrix(double[,] table)
{
    for(int i=0; i < table.GetLength(0); i++)
    {
        for(int j=0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
try
{
    Console.WriteLine("Введите размерность матрицы");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    double[,] matrix = new double[n, m];
    FillMatrix(matrix);
    PrintMatrix(matrix);
}
catch
{
    Console.WriteLine("Вводите только числа");
}