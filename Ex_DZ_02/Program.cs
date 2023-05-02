// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
int max = A ;
int min  = B;

if(A < B) max = B; 
    Console.Write($"max -> ");  
    Console.Write(max);
    Console.WriteLine();
    
   if(A < B) min = A;
    Console.Write($"min -> ");  
    Console.Write(min);




  
  
    


    
