// **Задача 26:**

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

using static System.Console;
Clear();
WriteLine("Введите число");
WriteLine(FunctionCount (Convert.ToInt32(ReadLine())));

int FunctionCount (int n)
{
    int result = 0;

while (n > 0)
    {
        n /= 10;
        result ++;
    }

    return result;
}
