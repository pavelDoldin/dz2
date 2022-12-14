// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2.


Console.Clear();
Console.Write("Введите k и b первой прямой: ");
string[] nambersFirst = Console.ReadLine().Split(" ");
double k1 = double.Parse(nambersFirst[0]);
double b1 = double.Parse(nambersFirst[1]);

Console.Write("Введите k и b второй прямой: ");
string[] nambersSecond = Console.ReadLine().Split(" ");
double k2 = double.Parse(nambersSecond[0]);
double b2 = double.Parse(nambersSecond[1]);

Console.WriteLine((b2 - b1) / (k1 - k2));
Console.WriteLine(k2 * (b2 - b1) / (k1 - k2) + b2);