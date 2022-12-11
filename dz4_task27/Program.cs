// Напишите программу, которая принемает на вход число и выдат сумму цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 0;
while (n > 0)
{
  int x = n % 10;
  result = result + x;
  n = n /10;
}
Console.WriteLine(result);