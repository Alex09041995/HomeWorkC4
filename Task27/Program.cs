Console.WriteLine("Данная программа принимает на вход число и выдаёт сумму цифр введённого числа.");

Console.Write("Введите любое число: ");

int argument = int.Parse(Console.ReadLine());
int Sum = 0;
    while (argument > 0)  // Пока (аргумент больше нуля)
    {
    Sum = Sum + argument % 10; // Вычисление остатка от деления левого операнда (argument) на правый (10).
    argument = argument / 10; // Деление левого операнда (argument) на правый (10).
    }

Console.WriteLine("Cумма цифр введённого числа равняется: {0}", (Sum));