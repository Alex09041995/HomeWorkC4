Console.WriteLine("Данная программа автоматически задаёт массив из 8 случайных элементов в диапозоне от -100 до 100, и выводит их на экран.");

int[] array = new int[8];
var random = new Random();

for(int i = 0; i < array.Length; i++)
   array[i] = random.Next(-100, 100);

var str = string.Join(" ", array);

Console.WriteLine($"Созданный автоматически данной программой массив из 8 случайных элементов, является следующим: [{string.Join(", ", array)}]");