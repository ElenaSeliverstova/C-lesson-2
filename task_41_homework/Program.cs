// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите любое количество положительных и отрицательных чисел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine($"Ваш массив: {String.Join(" ", array)}");

// int CountOfPositive(int [] arr, int count) // я не понимаю:(
// {
int size = array.Length;
int result = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0) result = result + 1;
}
Console.Write($"Количество положительных чисел: {result}");
// }
// int res = int CountOfPositive (int [] array, count);


