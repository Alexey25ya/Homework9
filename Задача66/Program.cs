// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
M=M-1;
int SumNumbers( int M, int N)
{
   
if (N ==M)
{
return 0;
}
return N + SumNumbers(M, N-1);
}
Console.WriteLine("Сумма натуральных элементов в промежутке от M до N равна "+SumNumbers(M, N));