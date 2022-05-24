// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] nums = new int[10];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(100, 999);
    Console.Write(nums[i] + " ");
}
int countPositive = 0;
for (int i = 0; i < nums.Length; i++)
{
    if(nums[i] % 2== 0) countPositive += 1;
}
Console.WriteLine();
Console.WriteLine($"Число четных = {countPositive}");

