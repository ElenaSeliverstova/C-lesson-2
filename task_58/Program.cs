// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] MultiArray(int[,] array1, int[,] array2)
{
    int[,] product = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                product[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return product;
}

int[,] array1 = GetArray(2, 2);
Console.WriteLine("Массив № 1: ");
PrintArray(array1);

int[,] array2 = GetArray(2, 2);
Console.WriteLine("Массив № 2: ");
PrintArray(array2);

int[,] newarray = MultiArray(array1, array2);
Console.WriteLine("Произведение матриц: ");
PrintArray(newarray);