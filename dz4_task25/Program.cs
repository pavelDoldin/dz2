Console.Clear();
int Exponentiation(int numberA, int numberB)
{
int result = 1;
for(int i=1; i <= numberB; i++)
    {
    result = result * numberA;
    }
    return result;
}

Console.Write("Введите число 1-ое: ");
string numberStrA = Console.ReadLine();
int numberA = int.Parse(numberStrA);

Console.Write("Введите число 2-ое: ");
string numberStrB = Console.ReadLine();
int numberB = int.Parse(numberStrB);

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);
