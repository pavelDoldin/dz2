// Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю
// ввести числа и вывести их на экран.

Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите 8 чисел: ");
    int x = Convert.ToInt32(Console.ReadLine()); 
    array[i] = x;
}

Console.WriteLine($"[{string.Join(", ", array)}]");

