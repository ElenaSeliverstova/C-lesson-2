// программа принимает на вход координаты точки, где x и y не равны нулю 
// и выдает номер четверти плоскости, в которой находится точка

Console.Write("введите значение Х: ");
int x = int.Parse(Console.ReadLine ());
Console.Write("введите значение Y: ");
int y = int.Parse(Console.ReadLine ());
if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}
