
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Input a fist nomber: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second nomber: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine("Min nomber is " + b + " and " + " Max nomber is " + a);
}
else
{
  Console.Write("Min nomber is " + a + " and " + " Max nomber is " + b);  
}

// Задача 2.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input a first nomber: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second nomber: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third nomber: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;
    if(a > b)
    {
      max = a;  
    }
     else
    {
        max = b;
    }

        if(max > c)
        {
            Console.WriteLine("Max nomber is " + max);
        }
        else
        {
            Console.WriteLine("Max nomber is " + c);
        }


//Задача 3.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n%2 ==0)
{
    Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}


// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;
if(N <= 1)
{
    Console.Write("Incorrect value");
}

while(current <= N)
{
    Console.Write(current + " ");
    current = current + 2;

}





























