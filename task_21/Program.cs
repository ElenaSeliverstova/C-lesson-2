// программа принимает на вход координаты 2 точек
// находит расстояние между ними в 2D пространстве

Console.Write("введите координату Х точки 1: ");
int x1 = int.Parse(Console.ReadLine ());

Console.Write("введите координаты Y точки 1: ");
int y1 = int.Parse(Console.ReadLine ());

Console.Write("введите координаты X точки 2: ");
int x2 = int.Parse(Console.ReadLine ());

Console.Write("введите координаты Y точки 2: ");
int y2 = int.Parse(Console.ReadLine ());

Console.WriteLine("координаты точки 1 (" + x1 + ";" + y1 + ")");
Console.WriteLine("координаты точки 2 (" + x2 + ";" + y2 + ")");

double res = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1) * (y2 - y1));
Console.WriteLine("расстояние равно = " + res);