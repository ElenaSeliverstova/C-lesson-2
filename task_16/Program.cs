// на вход 2 числа, проверить является ли одно квадартом другого
Console.Write("Введите целое число 1 => ");
int num1 = int.Parse(Console.ReadLine ());
Console.Write("Введите целое число 2 => ");
int num2 = int.Parse(Console.ReadLine ());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine("Yes");
 }
else
{
    Console.WriteLine("No");
 }
