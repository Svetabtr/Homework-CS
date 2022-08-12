/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

//Решение только для пятизначного числа

// Console.Write("Введите пятизначное число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// Number = Math.Abs(Number);

// if (Number/10000 == Number%10 && Number/1000%10==Number/10%10)
// {

//     Console.WriteLine("Это число палиндром!");
// }
// else
// {
//     Console.WriteLine("Это не палиндром");
// }

// Решение для любого числа

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
Number = Math.Abs(Number);

int i = Number;
int count = 0;

while (i > 0)
{

    i = i / 10;
    count = count + 1; //вычислили количество цифр в числе
}

int newNumber = Number;
int st = 0; // дополнительная переменная для возведения в степень 10 
double middle = count / 2; // середина числа
double result = 0;
int Digit = new int();
while (count >= middle && st < middle)
{

    Digit = newNumber % 10;

    result = result + (Digit * Math.Pow(10, count - 1) + Digit * Math.Pow(10, st));
    count = count - 1;
    st = st + 1;
    newNumber = newNumber / 10;

    if (count - 1 == st)
    {
        Digit = (newNumber % 10);
        result = result + Digit * Math.Pow(10, count - 1);
    }
}

if (result == Number)
{
    Console.WriteLine("Это число палиндром!");
}
else
{
    Console.WriteLine("Это не палиндром");
}