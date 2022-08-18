// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите трехзначное число для получения результата");
int enter = Convert.ToInt32(Console.ReadLine());
if(enter < 0) enter = enter * -1;
  
int arg = enter / 10 % 10;
  
Console.WriteLine("Вторая цифра в Вашем числе - " + arg);

 
