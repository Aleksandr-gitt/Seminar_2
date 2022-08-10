// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите Ваше число");
int arg = Convert.ToInt32(Console.ReadLine());

if(arg < 0)
{
    arg = arg * -1;
}

int len = Convert.ToString(arg).Length;

if(len > 2)
{
    string result = Convert.ToString(arg);
    Console.WriteLine("Третье число в Вашей цифре - " + result[2]);
}
else
{
    Console.WriteLine("В Вашем числе нет третьей цифры");
}
