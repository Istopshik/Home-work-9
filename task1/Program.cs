// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
System.Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine();
Result(number);

void Result(int number)
{
    if (number == 0)
    {
        return;
    }
    else
    {
        System.Console.Write($"{number}, ");
        Result(number - 1);
    }
}