// Задача 24: сумма чисел от 1 до А
Console.Write("Введите число А = ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum = sum + i;
    // sum += i;
}
 Console.WriteLine("Сумма чисел от 1 до " + number + " = " + sum);
