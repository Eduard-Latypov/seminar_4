// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = inputNumber();
System.Console.WriteLine(SumNumbers(num));





int SumNumbers(int number)
{
    int count = 0;
    while (number > 9)
    {
        count += number % 10;
        number /= 10;
    }
    return count + number;
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