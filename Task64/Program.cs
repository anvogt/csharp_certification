// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void PrintNumbers(int N, int count)
{
    if (count > N)
    {
        return;
    }
    else
    {
        PrintNumbers(N, count + 1);
        Console.WriteLine(count);
    }
}

int number = ReadInt("Введите число");
int count = 1;
PrintNumbers(number, count);