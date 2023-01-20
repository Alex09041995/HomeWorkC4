Console.WriteLine("Данная программа принимает на вход два числа: (A и B), и возводит число A в натуральную степень числа B.");

Console.Write("Введите любое число А: ");
int anyNumberA = Convert.ToInt32(Console.ReadLine());
string anyNumberTextA = Convert.ToString(anyNumberA);

Console.Write("Введите любое число B: ");
int anyNumberB = Convert.ToInt32(Console.ReadLine());
string anyNumberTextB = Convert.ToString(anyNumberB);

int Exponentiation(int anyNumberA, int anyNumberB){
    int result = 1;
    for(int i = 1; i <= anyNumberB; i++){
    result = result * anyNumberA;
    }
    return result;
}

int exponentiation = Exponentiation(anyNumberA, anyNumberB);
Console.WriteLine($"Введённое число А, возведённое в натуральную степень введённого числа B, равняется: {exponentiation}");