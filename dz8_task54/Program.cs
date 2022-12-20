// Задайте двух мернный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двухмерного массива.


void FillArrayRandomNumbers(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
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
int linesVol = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = int.Parse(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Рандомный массив");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int a = 0; a < numbers.GetLength(1) - 1; a++)
        {
            int temp = 0;
            if (numbers[i, a] < numbers[i, a + 1]) 
            {
                temp = numbers[i, a];
                numbers[i, a] = numbers[i, a + 1];
                numbers[i, a + 1] = temp;
            }
        }
    }
}


Console.WriteLine();
Console.WriteLine("Упорядоченный массив");
PrintArray(numbers);