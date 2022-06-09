// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int numN = int.Parse(Console.ReadLine());
int numM = 1;

void PrintNumbersDown(int m, int n)
{
    if (m == (n - 1)) return;
    PrintNumbersDown(m, n + 1);
    Console.Write($"{n} ");
}

PrintNumbersDown(numN, numM);