//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
//на само себя).● 4 -> 16 ● -3 -> 9 ● -7 -> 49 /

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;
double sqr2 = Math.Pow(number, 2);
Console.WriteLine($"квадрат {number} = {sqr}");
 Console.WriteLine($"квадрат {number} = {sqr2}");