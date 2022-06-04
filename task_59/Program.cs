// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


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

int GetMinValueMatrix(int[,] matrix, out int indexJ, out int indexI)
{
    indexI = 0;
    indexJ = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
    return min;
}
int[,] CutLeastElementCross(int[,] matrix)
{
    int min = GetMinValueMatrix(matrix, out var indexJ, out var indexI);
    Console.WriteLine($"Минимальное значение массива = {min}\nРяд - {indexI + 1}, столбец - {indexJ + 1}");
    Console.WriteLine();

    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int flagI;
            int flagJ;
            if (i >= indexI) flagI = 1;
            else flagI = 0;

            if (j >= indexJ) flagJ = 1;
            else flagJ = 0;

            resultMatrix[i, j] = matrix[i + flagI, j + flagJ];
        }
    }
    return resultMatrix;
}

var matrix1 = GetArray(5, 5);
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = CutLeastElementCross(matrix1);
PrintArray(matrix2);