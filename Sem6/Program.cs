
// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int PositiveNumbers(int num)
{
    int count = 0;
    for(int i = 0; i < num; i++) 

    {
        Console.Write($"input a  elements: ");
        int nextNumber = Convert.ToInt32(Console.ReadLine());
        
            if(nextNumber > 0) count ++;
    }

return count;
}


Console.WriteLine("Input amount of elements: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = PositiveNumbers(a);
Console.Write($"Number of positive elements is {b}");

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2

Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2-b1) / (k1-k2);
double y = k1 * ((b2-b1) / (k1-k2)) + b1;
Console.WriteLine($"Coordinates of point x is {x}");
Console.WriteLine($"Coordinates of point y is {y}");












