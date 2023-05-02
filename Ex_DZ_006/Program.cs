// Задача 6: Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).

Console.Clear();

Console.WriteLine("Введите число : ");
int n = int.Parse(Console.ReadLine()!);

if(n%2 == 0)
{
    Console.Write($" Yes!-> Четное число");
}
    else
    {
        Console.Write($" No!-> НЕчетное число");
    }


