// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

// Console.Write("Введите число");
// int Count(int number)
// {
//    int i;
//    int result = 1;
//    int p = 10;
//    for(int i = 10; p > 9; i = i + 10)
//    {
//        p = number / i;
//        result = result + i;
//    }
//    return result;
// }
// int Count = Convert.ToInt32(Console.ReadLine());
// int goal = Count(number);
// Console.WriteLine($"Количество цифр {goal}");


Console.WriteLine("введите число ");
int number = int.Parse(Console.ReadLine());
int count = 0;
Console.Write($"количество цифр в числе {number} = ");
while (number > 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine(count);