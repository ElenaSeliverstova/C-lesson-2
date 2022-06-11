// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26 

Console.Write("Введите A: ");
int Num1 = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int Num2 = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int NumN = int.Parse(Console.ReadLine());

void NewArray(int num1, int num2, int n)
{
    if (n == 2) return;
    int sum = num1 + num2;
    Console.Write($"{sum} ");
    num1 = num2;
    num2 = sum;
    NewArray(num1, num2, n - 1);
    return;
}

Console.Write($"{Num1} {Num2} ");
NewArray(Num1, Num2, NumN);