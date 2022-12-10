// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


System.Console.WriteLine("Введите число, возводимое в степень");
int num_1 = inputNumber();
System.Console.WriteLine("Введите число - степень");
int num_2 = inputNumber();
System.Console.WriteLine($"{num_1} в степени {num_2} = {Pow(num_1, num_2)}");





int Pow(int num1, int num2)
{
    int count = 1;
    for (int i = 0; i < num2; i++)
    {
        count *= num1;
    }
    return count;
}

int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.WriteLine("Введите число");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}