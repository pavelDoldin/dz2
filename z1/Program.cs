Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 100;
int n2 = n / 10;
int n3 = n % 10;
    Console.Write(n2 % 10);