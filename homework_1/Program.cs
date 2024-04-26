//напишите метод, который на вход принимает два числа и выводит, какое число большее,
//а какое меньшее.


Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


if (firstNumber == secondNumber)
        {
            Console.WriteLine($"числа равны");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"первое число больше`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"второе число больше");
        }
        
