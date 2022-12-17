// Задайте двухмернный массив из целых чисел. Найдите среднее арифметическое элементов в каждом сталбце.


void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[, ] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summa += matrix[i, j];
        }
        Console.WriteLine($"Столбец {j + 1} = {summa / matrix.GetLength(0)}");
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
ReleaseMatrix(matrix);