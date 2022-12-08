// Напишите программу, которая принемает на вход число и выдат сумму цифр в числе

Console.Write("Введите число: ");
String numberStrN = Console.ReadLine();
int numberN = Convert.ToInt32(numberStrN);

int SumNumber(int numberN)
{
    int count = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine($"Результат: {sumNumber}");