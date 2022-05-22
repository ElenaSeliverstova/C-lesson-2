// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] nums = new int[12];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(-9, 9);
    
}
Console.WriteLine();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = "не содержит";
for (int i = 0; i < nums.Length; i++)
{
   if (nums[i] == num)
   {
       result = "содержит";
       break;
   }

   }
   string st = string.Join(", ", nums);
   Console.WriteLine(st);
   Console.WriteLine(result);