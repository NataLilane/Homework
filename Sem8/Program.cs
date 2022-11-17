
//  Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,]CreatRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min posible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max posible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,]array = new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
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

void ChangeArray(int[,] array)
{ 
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1) -1; j++)
        
           for(int r = 0; r < array.GetLength(1 -1); r++)
        {
            if(array[i,r] < array[i,r + 1])
            {
                int temp = array[i,r];
                array[i, r] = array[i,r + 1];
                array[i, r + 1] = temp;
          
            }
        }
}

int[,] myArray = CreatRandom2dArray();
Show2dArray(myArray);
ChangeArray(myArray);
Show2dArray(myArray);

//  Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int LineNumber(int[,] array)
{
                int index = 0;
                int minsum = 0;
                
    if(array.GetLength(0) == array.GetLength(1))
    Console.WriteLine("Impossible to continue!");
        else
        for(int i = 0; i < array.GetLength(0); i++)
        {
           int sum = 0;

            for(int j = 0; j < array.GetLength(1); j++) 
            {
            sum += array[i,j];
            }

                if(i == 0) minsum = sum;
                else
                    if(sum < minsum) 
                    {
                        minsum = sum;
                        index = i;
                    }
            
     }
     return index;
     }


int[,] myArray = CreatRandom2dArray();
Show2dArray(myArray);
int ind = LineNumber(myArray);
Console.WriteLine($"The row with the smallest sum of elements is {ind + 1}");

// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] myArray1 = CreatRandom2dArray();
Show2dArray(myArray1);
int[,] myArray2 = CreatRandom2dArray();
Show2dArray(myArray2);


int[,] NewArray (int[,] array1, int[,] array2)
{
    int[,]array = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = 0;
                for (int r = 0; r < array1.GetLength(1); r++)
                {
                    array[i, j] += array1[i, r] * array2[r, j];
                }
            }
        }
    }
    else
    
        Console.WriteLine("The operation is impossible!");

    return array;
}

Console.WriteLine(string.Empty);
Console.WriteLine("New matrix: ");
int[,] myArray3 = NewArray(myArray1, myArray2);
Show2dArray(myArray3);

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreatRandom3dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of pages: ");
    int pages = Convert.ToInt32(Console.ReadLine());

    int[,,]array = new int[rows,columns, pages];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = new Random().Next(10,99);
            }
        
        }
    }
    return array;
}


void Show3dArray(int [,,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            
    
    Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
    Console.WriteLine();
        }
    }
    
}


int[,,] myArray = CreatRandom3dArray();
Show3dArray(myArray);









