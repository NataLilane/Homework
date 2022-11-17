// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
}

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNums(N);

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNum(int M, int N)
{
    if(M < N)
    {
     return N + SumNum(M, N - 1);
    }
    if(M > N)
    { return N + SumNum(M, N + 1);
    }
    if(M == N)
    { 
        return M;
    }
    return 1;
}

Console.WriteLine("Input a number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of the numbers between m and n is: {SumNum(m,n)}");

// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FuncAk(int m, int n)
{
    if (m == 0)
    {
     return n + 1;
    }
    
      if ((m > 0) && (n == 0))
      {
       return FuncAk(m - 1, 1);
      }
    else
        return FuncAk(m - 1, FuncAk(m, n - 1));
}
 
Console.Write("Input a number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Function is {FuncAk(m,n)}");






