// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// создать базовый массив

int[] CreateArray(int[] array, int length)
{
    for (int i = 0; i < length; i++)
    {
        Random arrayValues = new Random();
        array[i] = arrayValues.Next(-9, 10);
    }
    return array;
}
// вывод массива
int[] ArrayOutput(int[] array, int length)
{
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[length - 1]);
    Console.Write("]");
    return array;
}

// построение нового массива
int[] CreateAdditionalArray(int[] array, int length)
{
    int newArrayLength;
    if (length % 2 == 0)
    {
        newArrayLength = length / 2;
    }
    else
    {
        newArrayLength = (length / 2) + 1;
    }
    int[] newArray = new int[newArrayLength];
    int i = 0;
    int j = length - 1;
    while (i < newArrayLength)
    {
        newArray[i] = array[i] * array[j];
        i++;
        j--;
    }
    if (length % 2 != 0) { newArray[newArrayLength - 1] = array[newArrayLength - 1]; }
    return newArray;
}

Console.Write("Задайте длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] ourArray = new int[arrayLength];
CreateArray(ourArray, arrayLength);
Console.Write("Ваш массив: ");
ArrayOutput(ourArray, arrayLength);
int additArrayLength;
if (arrayLength % 2 == 0)
{
    additArrayLength = arrayLength / 2;
}
else
{
    additArrayLength = (arrayLength / 2) + 1;
}
int[] additionalArray = new int[additArrayLength];
additionalArray = CreateAdditionalArray(ourArray, arrayLength);
Console.WriteLine();

Console.Write("Массив с произведением парных чисел: ");
ArrayOutput(additionalArray, additArrayLength);