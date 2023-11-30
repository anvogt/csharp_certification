// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void SumNumbers(int M, int N)
{
    Console.Write(SumFromMToN(M - 1, N));
}

int SumFromMToN(int M, int N)
{
    int result = M;
    if (M == N)
        return 0;

    else
    {
        M++;
        result = M + SumFromMToN(M, N);
        return result;
    }
}

int numberM = ReadInt("Введите число M: ");
int numberN = ReadInt("Введите число N: ");
SumNumbers(numberM, numberN);