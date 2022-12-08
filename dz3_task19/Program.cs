// задача 19
// Напишите программу, которая принемает на вход пятизначное число и проверяет его,
// является ли оно палиндромом.

Console.Clear();
Console.Write("Введите любое число: "); //Нахождения палиндропа любого числа
int n = Convert.ToInt32(Console.ReadLine());
int result = n;
int newNumber = 0, i = Convert.ToString(n).Length -1;
while (i >= 0)
{
    newNumber = newNumber + (n % 10 * Convert.ToInt32(Math.Pow(10, i)));
    n = n / 10;
    i--;
}
Console.WriteLine(newNumber == result);
/*
// Чесно списал
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int n1 = n / 10000;
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;

if (n1 == n5 && n2 == n4)
    Console.WriteLine("yes");
else 
    Console.WriteLine("no");
*/