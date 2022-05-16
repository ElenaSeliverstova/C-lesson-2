// программа по заданному номеру четверти 
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Write("введите цифру от 1 до 4: ");
int xy = int.Parse(Console.ReadLine ());
if (xy == 1)
{
    Console.WriteLine("обе координаты плюс");
}
if (xy == 2)
{
    Console.WriteLine("X минус, Y плюс");
}
if (xy == 3)
{
    Console.WriteLine("X минус, Y минус");
}
if (xy == 4)
{
    Console.WriteLine("X плюс, Y минус");
}
