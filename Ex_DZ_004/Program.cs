// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.;

Console.Clear();

Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число C: ");
int C = int.Parse(Console.ReadLine()!);

int max = A;

if(B > A) max = B;
     
  if(B < C) max = C;
    Console.Write($"max -> ");  
    Console.Write(max);
   