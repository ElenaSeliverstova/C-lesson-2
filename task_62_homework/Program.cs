// Задача 62: Заполните спирально массив 4 на 4.

int N = 4;
int[,] array = new int[N, N];

int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = N;

for (int i = 0; i < array.Length; i++)
{
    array[row, col] = i + 1;
    if (--gran == 0)
    {
        gran = N * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    col += dx;
    row += dy;
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
