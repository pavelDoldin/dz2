Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.Write("нет третьей цифры");
else
{ 
    while (n >=100)
        n = n / 10;
    Console.WriteLine(n % 10);
}