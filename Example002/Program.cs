// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
int[] MatrixInArray(int[,] table)
{
    int[] array = new int[table.GetLength(0)*table.GetLength(1)];
    int k = 0;
    for(int i=0; i < table.GetLength(0); i++)
    {
        for(int j=0; j < table.GetLength(1); j++)
        {
            array[k] = table[i, j];
            k++;
        }
    }
    return array;
}
try
{
     Console.WriteLine("Введите размерность матрицы");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[n, m];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    int[] arr = MatrixInArray(matrix);
    Console.WriteLine("Введите позицию элемента");
    int x = Convert.ToInt32(Console.ReadLine());
    if(x < arr.Length) Console.WriteLine($"Элемент с позицией {x} равен {arr[x]}");
    else Console.WriteLine("Элемента с такой позицией нет");
}
catch
{
    Console.WriteLine("Вводите только числа");
}