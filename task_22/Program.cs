// программа принимает на вход число N
// выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("введите число N");
int lenght = Convert.ToInt32(Console.ReadLine ());

for (int i = 1; i <= lenght; i++) 
{
Console.Write(i * i + " ");
}