// создать массив из 8 чисел, заполнить значениями 0 и 1 в произвольном порядке

int[] arr = new int[8];
int[] PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write(array[i]);
    }
    return array;
}
PrintArray(arr);
