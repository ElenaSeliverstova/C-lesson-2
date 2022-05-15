// Вводим число, проверяем кратно ли одно одновремено 7 и 23
Console.Write("Введите целое число => ");
int num = int.Parse(Console.ReadLine ());
if (num % 7 == 0 && num % 23 == 0) Console.WriteLine("Yes");
else Console.WriteLine("No");