// Задача 63: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num == 1) return;
    num--;
    NaturalNumbers(num);
    Console.Write($"{num} ");
}
NaturalNumbers(number + 1);