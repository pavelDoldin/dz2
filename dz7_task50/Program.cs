﻿// Напишите программу, которая на вход принемает позиции элемента в двухмерном мвссиве
// и возращает значения этого элемента или же указания, что такого элемента нет.

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


void ReleaseMatrix(int[, ] matrix, int x, int y)
{
    if (x >= matrix.GetLength(0) || y >= matrix.GetLength(1) || x < 0 || y < 0)
        Console.WriteLine("К сожалению, Вы ошиблись в координатах");
    else
        Console.WriteLine(matrix[x, y]);
}


Console.Clear();
Console.Write("Введите размеры матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите позицию элемента ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
ReleaseMatrix(matrix, coord[0] - 1, coord[1] - 1);