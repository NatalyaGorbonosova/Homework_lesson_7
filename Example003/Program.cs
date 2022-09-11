// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void FillMatrix(int[,] table)
{
    for(int i=0; i < table.GetLength(0); i++)
    {
        for(int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(-10, 10);
        }
    }
}
void PrintMatrix(int[,] table)
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
double[] AverageColum(int[,] table)
{
    double[] avg = new double[table.GetLength(1)];
    for(int j = 0; j < table.GetLength(1); j++)
    {
        int sum = 0;
        for(int i=0; i < table.GetLength(0); i++)
        {
            sum += table[i, j];
        }
        avg[j] = Math.Round(Convert.ToDouble(sum)/table.GetLength(0), 1);
    }
    return avg;
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write(array[array.Length - 1]);
}
try
{
     Console.WriteLine("Введите размерность матрицы");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[n, m];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    double[] averageColum = AverageColum(matrix);
    Console.Write("Среднее арифметическое каждого столбца:  ");
    PrintArray(averageColum);
    
}
catch
{
    Console.WriteLine("Вводите только числа");
}
