// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


printArray(func(inputNumber()));




int[] func(int num)
{
    int[] myArray = new int[num];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(100);
    }
    return myArray;
}

void printArray(int[] arr)
{
    System.Console.WriteLine($"[{String.Join(", ", arr)}]");
}

int inputNumber()
{
    int number;
    string text;

    while (true)
    {
        Console.WriteLine("На сколько элементов создать массив?");
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
