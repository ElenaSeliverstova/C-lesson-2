// Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.

Console.Write("Введите M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int numN = int.Parse(Console.ReadLine());

void PrintNumbersUp(int m, int n)
{
    if (n == (m - 1)) return;
    PrintNumbersUp(m, n - 1);
    Console.Write($"{n} ");
}

void PrintNumbersDown(int m, int n)
{
    if (m == (n - 1)) return;
    PrintNumbersDown(m, n + 1);
    Console.Write($"{n} ");
}

if (numN > numM)
{
    PrintNumbersUp(numM, numN);
}
else
{
    PrintNumbersDown(numM, numN);
}