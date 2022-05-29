// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// 20 мин
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 9);
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

// int[,] SumDiagArray(int[,] array)
// {
//     int n = 0;
//     if (array.GetLength(0) < array.GetLength(1))
//         n = array.GetLength(0);
//     else n = array.GetLength(1);
//     int sum = 0;
//     for (int i = 0; i < n; i++)
//     {
//         sum += array[i, i];
//     }
//     return sum;
// }

int GetSumOfDiag(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i==j) sum += array[i, j];
        }
    }
    return sum;
}

int[,] arrayResult = GetArray(4, 4);
Console.WriteLine("Исходный массив: ");
PrintArray(arrayResult);
Console.WriteLine($"Сумма элементов по основной диагонали = {GetSumOfDiag(arrayResult)}");

