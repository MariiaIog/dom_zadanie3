/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве. */

int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int xa = getNumberFromUser("Точка А. Координата X: ");
int ya = getNumberFromUser("Точка А. Координата Y: ");
int za = getNumberFromUser("Точка А. Координата Z: ");
int xb = getNumberFromUser("Точка B. Координата X: ");
int yb = getNumberFromUser("Точка B. Координата Y: ");
int zb = getNumberFromUser("Точка B. Координата Y: ");

double GetDistance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double distance = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    return distance;
}

double distance = GetDistance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между точками A и B равно {distance} ");
