/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Введите любое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
Number = Math.Abs(Number);

if (Number < 100)
{
    Console.WriteLine("Третьей цифры у числа нет");
}

else if (Number >= 100 & Number <= 999)
{
    int ThirdDigit = Number % 10;
    Console.WriteLine($"Третья цифра данного числа - {ThirdDigit}");
}

else if (Number > 999)
{
    while (Number > 999)
    {
        Number = Number / 10;
    }
    int ThirdDigit = Number % 10;
    Console.WriteLine($"Третья цифра данного числа - {ThirdDigit}");
}
