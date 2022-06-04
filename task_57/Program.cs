// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

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

// void NumberOfNumbers(int[,] array)
// {
//     int count = 0;
//     int[] oneDimArray = new int[array.GetLength(0) * array.GetLength(1)];
//     int k = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             oneDimArray[k] = array[i, j];
//             Console.Write(oneDimArray[k] + " ");
//             k++;
//         }
//     }
//     Array.Sort(oneDimArray);
//     int [] sortArr = oneDimArray.Distinct().ToArray();
//     int columnsNew = sortArr.Length;
// }

void FrequencyList(int[,] arr)
{
    int[] listar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int count = 0;
    for (int k = 0; k < listar.Length; k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (listar[k] == arr[i, j])
                    count++;
            }
        }
        if (count != 0)
        {
            Console.WriteLine($"{listar[k]} встречается {count} раз");
        }
        count = 0;
    }
}

int[,] arrayResult = GetArray(3, 3);
PrintArray(arrayResult);
Console.WriteLine();
FrequencyList(arrayResult);