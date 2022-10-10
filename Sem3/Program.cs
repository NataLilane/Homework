
// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrome(int num)
{
  int  x = num / 10000;
  int  y = num / 1000 % 10;
  int  z = num % 100 / 10;
  int  w = num % 10;

  if(x == w && y == z)
  
  
    return true;
    else
    return false;
    
}
Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Palindrome(number);
if (result == true)
Console.WriteLine("Yes");
else
Console.WriteLine("No");

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistans(double x, double x1, double y, double y1, double z, double z1)
{
    double num = 0;
    num = (x1 - x) * (x1 - x) + (y1 - y) * (y1 - y) + (z1 - z) * (z1 -z);
    num = Math.Sqrt(num);
    return num;
    
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x1-coordinate: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1-coordinate: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z-coordinate: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1-coordinate: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double findDistans = FindDistans(x, x1, y, y1, z, z1);
Console.WriteLine($"Distance between points is {findDistans}");

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ShowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 3);
        Console.Write(n + " ");
        count ++;
    }
}

Console.Write("Inpun a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);






























