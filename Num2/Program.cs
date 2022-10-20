/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

/*Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int sum = 0;
while (a > 0)
{
    int num = a / 10;
    a = a / 10;
    sum = sum + num;
    sum++;
}
Console.WriteLine($"сумма цифр {sum}");
*/

/*Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a = 0;
while (num > 0)
    {
        int summa = a / 10;
        a++;
    }
    int sum = 1;
    for (int i = 0; i < sum; i++)
    {
        sum = i / 10;
        i = i / 10;
        sum = sum + a;
    }
Console.WriteLine($"сумма цифр {sum}");*/

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
while (n > 0)
{
     int num = n % 10;
     n = n / 10;
    sum = sum + num; 
}
Console.WriteLine($"сумма цифр {sum}");