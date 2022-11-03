// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// с границами
double[,]NewArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min posible value: ");
    double minValue = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a max posible value: ");
    double maxValue = Convert.ToDouble(Console.ReadLine());
    double [,]array = new double[rows, columns];
    

    for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++)
    {
    double num = new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue)) + new Random().NextDouble();
    array[i, j] = Math.Round(num,2);
    }
    return array;
}

void ShowdArray(double [,]array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i,j] + " ");
    Console.WriteLine();
}
}

double[,]myArray = NewArray();
ShowdArray(myArray);

// без границ

double[,]NewArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double [,]array = new double[rows, columns];
    
    for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++)
    {
    double num = new Random().Next() + new Random().NextDouble();
    array[i, j] = Math.Round(num,2);
    }
    return array;
}

void ShowdArray(double [,]array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i,j] + " ");
    Console.WriteLine();
}
}

double[,]myArray = NewArray();
ShowdArray(myArray);

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,]CreatRandom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

    int[,]array = new int[rows, columns];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next();
        }
    }
return array;
}

void Show2dArray(int [,]array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i,j] + " ");
    Console.WriteLine();
}
}

void ShowNumber(int a, int b, int[,]array)
{
int num = 0;
if(a < array.GetLength(0) && b < array.GetLength(1))
{
    num = array[a, b];
    Console.WriteLine($"Desired number is {num}");

}
    else
    Console.WriteLine("There are no numbers with such indices in the array");

}
Console.WriteLine("Hello!");
int[,]myArray = CreatRandom2dArray();
Console.Write("Enter rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns nomber: ");
int columns = Convert.ToInt32(Console.ReadLine());
Show2dArray(myArray);
ShowNumber(rows, columns, myArray);

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// вар1
int[,]CreatRandom2dArray(int onesize, int twosize)
{
   
    Console.Write("Input a min posible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max posible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
   int[,]array = new int[onesize, twosize];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
return array;
}

void Show2dArray(int [,]array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i,j] + " ");
    Console.WriteLine();
}
}

void ShowArray(double[]array)
{
    for(int r = 0; r < array.Length; r++)
    Console.Write(array[r] + " ");
    Console.WriteLine();
}

double[]ArithNum(int[,]array)
{
    double [] array1 = new double[array.GetLength(1)];
   
        for(int j = 0; j < array.GetLength(1); j++)
    {
        double sred = 0;
        double sum = 0;

            for(int i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i,j];
                sred = sum / (array.GetLength(0));
            }

                 for(int r = 0; r < array.GetLength(1); r++) 
                    array1[r] = sred;
    }
        return array1;
    
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,]myArray = CreatRandom2dArray(rows,columns);
Show2dArray(myArray);
double[]array2 = ArithNum(myArray);
ShowArray(array2);


// вар2

int[,]CreatRandom2dArray(int onesize, int twosize)
{
   
    Console.Write("Input a min posible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max posible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
   int[,]array = new int[onesize, twosize];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
return array;
}

void Show2dArray(int [,]array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i,j] + " ");
    Console.WriteLine();
}
}

void ShowArray(double[]array)
{
    for(int r = 0; r < array.Length; r++)
    Console.Write(array[r] + " ");
    Console.WriteLine();
}


double[]CreatNewArray(int size, double nextNumber) 
{
    double[]array = new double [size];

    for(int i = 0; i < size ; i++) 
    array[i] = nextNumber;
    return array;

}

double ArithNum(int[,]array)
{
     double sred = 0;

     for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;

        for(int i = 0; i < array.GetLength(0); i++)
            
                sum = sum + array[i,j];
                sred = sum / (array.GetLength(0));
        }

    return sred;

}


Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,]myArray = CreatRandom2dArray(rows,columns);
Show2dArray(myArray);
double num = ArithNum(myArray);
double[]array2 = CreatNewArray(columns, num);
ShowArray(array2);















