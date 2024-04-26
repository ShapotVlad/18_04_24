//напишите метод FindMax, который принимает на вход три числа
//и выдаёт максимальное из этих чисел.


Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число ");
int c = Convert.ToInt32(Console.ReadLine());




int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine(max);


