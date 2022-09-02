// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 365");
int number = Convert.ToInt32(Console.ReadLine());

int n = number % 7;
int m = number % 6;

if(n == 0) Console.WriteLine(number + " день - Воскресенье");
if(m == 0) Console.WriteLine(number + " день - Суббота");
else Console.WriteLine(number + " день - Рабочий")
