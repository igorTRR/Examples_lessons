﻿// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("Введите число : ");
int n = int.Parse(Console.ReadLine()!);

int k = 2;
while(k <= n)
{
    Console.Write($"{k}-> ");
    k+= 2;
}