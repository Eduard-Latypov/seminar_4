// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

printArray(func(inputNumber()));




int[] func(int num)
{
    int[] myArray = new int[num];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(2);
    }
    return myArray;
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
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


