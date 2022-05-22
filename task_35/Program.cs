// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] nums = new int[123];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 123);
    Console.Write(nums[i] + " ");
}
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] >= 10 && nums[i] <= 99)
    {
        count ++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество элементов {count}");
