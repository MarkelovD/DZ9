//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
// Console.WriteLine("введите конечное число");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(n));
// string PrintNumbers(int end)
// {
//     if (end == 1) return end.ToString();
//     return (end + " " + PrintNumbers(end - 1));
// }

//Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
// Console.WriteLine("введите стартове число");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("введите конечное число");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"сумма чисел в диапазоне от {m} до {n} = "+ PrintNumbers(m,n));
// int PrintNumbers(int numb,int numb2){
//     if (numb2 == 1) return numb;
//     return (numb+PrintNumbers(numb+1,numb2-1));}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 //Даны два неотрицательных числа m и n.
 Console.WriteLine("введите стартове число");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите конечное число");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintAkkerman(m,n));
int PrintAkkerman(int numb1,int numb2){
    if (numb1 == 0) return numb2+1;
    if (numb1>0 && numb2==0) return PrintAkkerman(numb1-1,1);
    else   return PrintAkkerman(numb1-1,PrintAkkerman(numb1,numb2-1));
    }
