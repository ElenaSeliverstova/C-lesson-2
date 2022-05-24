// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] nums = new int[10];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 9);
    Console.Write(nums[i] + " ");
}

int sumUneven = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (i % 2 != 0) sumUneven += nums[i];
}
Console.WriteLine();
Console.WriteLine($"сумма нечетных = {sumUneven}");