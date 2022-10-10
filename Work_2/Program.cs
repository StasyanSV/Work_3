// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите координаты первой точки: ");
int Xa = int.Parse(Console.ReadLine());
int Ya = int.Parse(Console.ReadLine());
int Za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
int Xb = int.Parse(Console.ReadLine());
int Yb = int.Parse(Console.ReadLine());
int Zb = int.Parse(Console.ReadLine());

Console.WriteLine($"Координаты первой точки: ({Xa},{Xb},{Za}) ");
Console.WriteLine($"Координаты второй точки: ({Ya},{Yb},{Zb}) ");

double distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));

Console.WriteLine($"Расстояние между двумя точками: {Math.Round(distance, 2)}");
