// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

Console.Write("Введите число: ");
int sum = int.Parse(Console.ReadLine());

int SumNumber(int number)
{
    int result = 0;
    if (number == 0) return 0;
    result = number % 10 + SumNumber(number/10);
    return result;
}

Console.WriteLine(SumNumber(sum));
