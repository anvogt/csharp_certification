// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void Function(int M, int N)
{
    Console.Write(Aсkerman(M, N)); 
}

int Aсkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Aсkerman(M - 1, 1);
    }
    else
    {
        return (Aсkerman(M - 1, Aсkerman(M, N - 1)));
    }
}

int numberM = ReadInt("Введите число M: ");
int numberN = ReadInt("Введите число N: ");
Function(numberM, numberN);
