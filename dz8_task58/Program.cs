// Задайте две матриц. Напишите программу которая будет находить проиведения двух матриц.


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


void InputMaxi(int[, ] maxi)
{
    for (int k = 0; k < maxi.GetLength(0); k++)
    {
        for (int m = 0; m < maxi.GetLength(1); m++)
        {
            maxi[k, m] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{maxi[k, m]} \t");
        }
        Console.WriteLine();
    }
}



Console.Clear();
Console.Write("Введите размер матрицы 1: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Mатрица 1: ");
InputMatrix(matrix);

Console.Write("Введите размер матрицы 2: ");
int[] cool = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] maxi = new int[cool[0], cool[1]];
Console.WriteLine("Матрица 2: ");
InputMaxi(maxi);

Console.Write($"{matrix[i * k]} {maxi[j * m]}");

