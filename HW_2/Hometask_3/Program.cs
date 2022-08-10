/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число дня недели: ");
int WeekDay = Convert.ToInt32(Console.ReadLine());

void Weekend(int dayNumber)
{
    if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Такого дня недели не существует");
    }

    else if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Это ВЫХОДНОЙ!");
    }
    else 
    {
        Console.WriteLine("Это не выходной день");
    }
}
Weekend(WeekDay);
