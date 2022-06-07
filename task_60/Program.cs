// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(10, 100); // как сделать неповторяющиеся?
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{i}{j}{k} = {array[i, j, k]} "," ");                
            }
        }
        Console.WriteLine();
    }
}

int[,,] matrix = GetArray(3, 3, 3);
Console.WriteLine("Трехмерный массив: ");
PrintArray(matrix);
