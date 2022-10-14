// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// a

Console.Write("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int i = 1;
int res = 1;
while(i <= numB)
{
res = res * numA;
i++;
}

Console.WriteLine($"The result is {res}");

//b

Console.Write("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int res = 1;
for(int i = 1; i <= numB; i++)
{
    res = res * numA;
}

Console.WriteLine($"The result is {res}");

// Задача 2. : Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumbers(int num)
{
    int sum = 0;
    int digit = 0;
    
    while(num > 0)
    {
    
        digit = num % 10;
        sum = sum + digit;
        num = num / 10;
    }
return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"The sum of the digits in a number {number} is {sumNumbers}");

// Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[]CreatNewArray(int size)
{
    int[]array = new int [size];

    for(int i = 0; i < size ; i++) 
    {
        Console.Write("input a number number: ");
        int nextNumber = Convert.ToInt32(Console.ReadLine());   

       array[i] = (nextNumber);
    }

    return array;
}

void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("input numbers of alements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatNewArray(size);
ShowArray(newArray);












