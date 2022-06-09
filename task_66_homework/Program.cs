// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int numN = int.Parse(Console.ReadLine());

int SumRec(int m, int n)
{
    int sum = n;
    if (m == n) return sum;
    else return sum += SumRec(m, n - 1);
}

Console.WriteLine(SumRec(numM, numN));