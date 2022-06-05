// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortArrayMaxMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = j;                                            
            for (int k = j + 1; k < array.GetLength(1); k++)                
            {
                if (array[i, k] > array[i, min]) min = k;    
            }
            int tmp = array[i, j];                                          
            array[i, j] = array[i, min];                            
            array[i, min] = tmp;                                    
        }

    }
    return array;
}

int[,] arrayResult = GetArray(3, 5);
PrintArray(arrayResult);
Console.WriteLine();
int[,] newarr = SortArrayMaxMin(arrayResult);
PrintArray(newarr);