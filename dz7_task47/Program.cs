// Задайте двухмерный массив, размером MxN заполненный случайными 
// вещественными числами.

void ArrayRandomNumbers(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (10 - 1) + 1;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 1) + " \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[m, n];
ArrayRandomNumbers(numbers);
PrintArray(numbers);