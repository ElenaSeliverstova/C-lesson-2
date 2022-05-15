// программа принимает на вход 2 числа и выводит, является ли второе кратным первому.
// если число 2 не кратно 1, то программа выводит остаток от деления
Console.Write("Введите целое число 1 => ");
int num1 = int.Parse(Console.ReadLine ());
Console.Write("Введите целое число 2 => ");
int num2 = int.Parse(Console.ReadLine ());
Console.WriteLine(num1 % num2 == 0 ? "число " + num1 + " кратно числу " + num2: " остаток от деления " + num1 % num2);
