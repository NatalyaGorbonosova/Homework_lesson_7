// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
void FillMatrix(int[,] table)
{
    for(int i=0; i < table.GetLength(0); i++)
    {
        for(int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(0, 20);
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
void SortArray(int[] array)
{
    for(int k = 0; k < array.Length - 1; k++)
    {
        int posMax = 0;
        for(int i = 1; i < array.Length - k; i++)
        {
           if(array[i] > array[posMax]) posMax = i;
        }
        int temporary = array[posMax];
        array[posMax] = array[array.Length - 1 - k];
        array[array.Length - 1 - k] = temporary;
    }
}
void ArrayInMatrix(int[] array, int[,] table)
{
    int k = 0;
    for(int i = 0; i < table.GetLength(0); i++)
    {
        for(int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = array[k];
            k++;
        }
    }
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
    SortArray(arr);
    ArrayInMatrix(arr, matrix);
    Console.WriteLine();
    PrintMatrix(matrix);   
    
}
catch
{
    Console.WriteLine("Вводите только числа");
}