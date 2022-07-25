//Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
/*M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
string Numbers(int M, int N)
{
    if (M > N)
    {
        if (M == N)
        {
            return M.ToString();
        }
        return M + " " + Numbers(M - 1, N);
    }
    else
    {
        if (M == N)
        {
            return M.ToString();
        }
        return M + " " + Numbers(M + 1, N);
    }
}

Console.WriteLine(Numbers(M, N));