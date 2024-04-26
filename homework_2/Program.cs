//напишите метод FindMax, который принимает на вход три числа
//и выдаёт максимальное из этих чисел.

int a = 44;
int b = 78;
int c = 16;


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
