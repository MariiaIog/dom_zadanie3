/* Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N. */

int N = new int();
Console.WriteLine("Введите число:");
N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");

int Cube = 1;
while (Cube <= N)
{
    Console.WriteLine(Cube * Cube * Cube + "");
    Cube++;
}
