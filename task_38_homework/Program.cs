// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] nums = new int[10];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 99);
    Console.Write(nums[i] + " ");
}

int Max = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > Max) Max = nums[i]; 
}
Console.WriteLine();
Console.WriteLine($"Максимальное число массива: {Max}");

int Min = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] < Min) Min = nums[i]; 
}
Console.WriteLine($"Минимальное число массива: {Min}");
Console.WriteLine($"Разница между максимальным и минимальным: {Max - Min}");