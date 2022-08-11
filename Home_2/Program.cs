// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите Ваше число");
int arg = Convert.ToInt32(Console.ReadLine());

if(arg < 0) arg = arg * -1;

if(arg < 100)
{
    Console.WriteLine("В Вашем числе нет третьей цифры");
    
}
else if(arg < 1000)
{
    Console.WriteLine("Третья цифра в Вашем числе - " + (arg % 10));
}
else 
{
    int n = 10;
    int m = 1;
    int result = arg / 10;

    while(result > 0)
    {
        
        result = result / 10;
        n = n * 10;
        m = m * 10;
    }
    
    Console.WriteLine("Третья цифра в Вашем числе - " + (arg % (n/100) / (m/100)));
}