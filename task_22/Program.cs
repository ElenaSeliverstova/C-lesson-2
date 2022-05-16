// программа принимает на вход число N
// выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("введите число N");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("|{0,10}|{1,10}|", "число", "квадрат");
for (int i = 1; i <= num; i++)
{
    Console.WriteLine("|{0,10}|{1,10}|", i, i*i);
}
