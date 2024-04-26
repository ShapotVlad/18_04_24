//напишите метод , который на вход принимает число number и выводит,
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите  число ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number%2;

if (result == 0)
{
   Console.WriteLine($"четное"); 
}
else
{
    Console.WriteLine($"нечетное");
}

 if ((number % 2) == 0)
        {
            Console.WriteLine($"четное");
        }
        else
        {
            Console.WriteLine($"нечетное");
        }
