//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
Console.WriteLine("введите конечное число");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(n));
string PrintNumbers(int end)
{
    if (end == 1) return end.ToString();
    return (end + " " + PrintNumbers(end - 1));
}
