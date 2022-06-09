// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

Console.Write("Введите A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int numB = int.Parse(Console.ReadLine());

int NumDegree(int a, int b)
{
    if (b == 0) return 1;
    a = a * NumDegree(a, b-1);
    return a;
}

Console.WriteLine(NumDegree(numA, numB));