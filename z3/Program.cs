Console.Clear();
Console.Write("Введите цифру обозначающую день недели: ");
int n = Convert.ToInt32(Console.ReadLine()); // Ввод числа
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись:(!\nВведите цифру обозначающую день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
     if    (n == 1)
    Console.Write("no");
else if (n == 2)
    Console.Write("no");
else if (n == 3)
    Console.Write("no");
else if (n == 4)
    Console.Write("no");
else if (n == 5)
    Console.Write("no");
else if (n == 6)
    Console.Write("yes");
else 
    Console.Write("yes");
