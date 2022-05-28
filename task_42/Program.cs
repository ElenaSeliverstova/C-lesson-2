// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Ввведите число ");
int numDec = int.Parse(Console.ReadLine());
Console.Write("Ввведите основание системы счисления ");
int baseNum = int.Parse(Console.ReadLine());

int d10 = 1;
long result = 0;
while(numDec != 0)
{
    result = result + numDec % baseNum * d10;
    numDec /= baseNum;
    d10 = d10 * 10;
}

Console.WriteLine(result);