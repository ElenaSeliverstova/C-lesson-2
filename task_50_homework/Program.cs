// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int FindNum(int[,] array)
{
    Console.WriteLine("Введите адрес элемента для поиска в массиве (2 числа через пробел): ");
    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int inputRow = arr[0];
    int inputColumn = arr[1];
    int num = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if (row == inputRow && column == inputColumn)
            {
                Console.WriteLine($"Результат поиска = {num = array[row, column]}");
            }
        }
    }
    return num;
}

int[,] arrayResult = GetArray(4, 4);
Console.WriteLine("Исходный массив: ");
PrintArray(arrayResult);
FindNum(arrayResult);

