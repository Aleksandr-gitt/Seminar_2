// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите трехзначное число для получения результата");
int enter = Convert.ToInt32(Console.ReadLine());
if(enter < 0)
{
    enter = enter * -1;
}
    
string qwerty = Convert.ToString(enter);
int arg = Convert.ToInt32(qwerty.Length);
    
if(arg == 3)
{
    Console.WriteLine("Вторая цифра в Вашем числе - " + qwerty[1]);
}
else
{
    Console.WriteLine("Я же просил ввести !!!трехзначное!!! число.");
}
 
