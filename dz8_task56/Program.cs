// Задайте двухмерный массив. Напишите программу которая будет находить 
//строку с наименьшией суммой элементов.

void FillArrayRandomNumbers(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int linesSum = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int columnsSum = int.Parse(Console.ReadLine());

int[,] array = new int[linesSum, columnsSum];
FillArrayRandomNumbers(array);
PrintArray(array);

int minSum = Int32.MaxValue;
int index = 0;
for (int i = 0; i < array.Length; i++) ;
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = (sum + array[i, j]);
        }
        if (sum < minSum)
        {
            minSum = sum;
            index++;
        }
    }
}
Console.WriteLine($"Строка с наименьшей суммой чисел ({minSum}) является строка ({index})");