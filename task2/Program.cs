// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
System.Console.WriteLine("Enter number M: ");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number N: ");
int n = int.Parse(Console.ReadLine());
SumNumbers(m, n, 0);



void SumNumbers(int m, int n, int sum)
{
    if (m > n)
    {
       System.Console.WriteLine(sum);
       return;
    }
    else
    sum =+ sum + (m++);
    SumNumbers(m, n, sum);        
}