/* Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.*/


int Number = new int();
Console.WriteLine("Введите пятизначное число:");
Number = Convert.ToInt32(Console.ReadLine());

int Number1 = Number / 10000;
int Number2 = Number / 1000 % 10;
int Number3 = Number / 100 % 10;
int Number4 = Number / 10 % 10;
int Number5 = Number % 10;

if (Number1 == Number5 && Number2 == Number4)  // && Если левое выражение не True, то правое не вычисляется
{
    Console.WriteLine("Данное число является палиномом.");
}
else
{
    Console.WriteLine("Это число не палином.");
}