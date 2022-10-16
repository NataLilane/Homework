
// Задача 1.  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[]CreatRendomArray(int size, int minValue, int maxValue)
{
    int[]array = new int [size];
    for(int i = 0; i < size; i++)
    {
    array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    
    if(array[i] % 2 == 0)
    count ++;
    return count;
}

Console.Write("Input the number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRendomArray(size, min, max);
ShowArray(myArray);
int res = EvenNumbers(myArray);
Console.WriteLine("number of even numbers is " + res);

// задача 2.  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[]CreatRendomArray(int size, int minValue, int maxValue)
{
    int[]array = new int [size];
    for(int i = 0; i < size; i++)
    {
    array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOfOdd(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    if(array[i] % 2 == 1)
    sum += array[i];
    return sum;
}

Console.Write("Input the number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRendomArray(size, min, max);
ShowArray(myArray);
int res = SumOfOdd(myArray);
Console.WriteLine(res);

// задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[]CreatArray(int size) 
{
    double[]array = new double [size];

    for(int i = 0; i < size ; i++) 
    {
        Console.Write($"input a {i +1} elements of array: ");
        double nextNumber = Convert.ToDouble(Console.ReadLine());   

       array[i] = (nextNumber);
    }
    Console.Write("Complete! ");

    return array;
}

void ShowArray(double[]array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

double Difference(double[]array)
{
    double dif = 0;
    double max = array[0];
    double min = array[0];
   
    for(int i = 0; i < array.Length; i++)

        if(array[i] < min) min =  array[i]; 
         else 
            if(array[i] > max) max = array[i];
        
        dif = max - min;
        return dif;
}

Console.Write("Input the number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreatArray(size);
ShowArray(myArray);
double difference = Difference(myArray);
Console.WriteLine("The difference between the maximum and minimum number is " + difference);

























