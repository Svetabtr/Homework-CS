/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.(необязательная)
m = 2, n = 3 -> A(m,n) = 29
*/

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {Akkerman(n,m)}");


int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else
    {
        if (n != 0 && m == 0) return Akkerman(n - 1, 1);
        else
        {
            return Akkerman(n - 1, Akkerman(n, m - 1));
        }
    }
}