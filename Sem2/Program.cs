//  Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int SecondDigit(int num)
{
    int result;
    int dec = num / 10 % 10;
    result = dec;
    return result;
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SecondDigit(number));

//  Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет



int ThirdDigit(int num)
{
    int result;
    while(num > 1000)
        num = num / 10;
    result = num % 10;
    return result;
}
    
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = ThirdDigit(number);
    if(number < 100)
    Console.WriteLine("No third digit");
    else
    Console.WriteLine(ThirdDigit(thirdDigit));


//  Задача 3.Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOff()
{
    Console.Write("Input a number representing the day of the week: ");
    int num = Convert.ToInt32(Console.ReadLine());
   
    if (num == 6 || num == 7)
    Console.WriteLine("Yes");
    else
    Console.WriteLine("No");
 }
DayOff();











