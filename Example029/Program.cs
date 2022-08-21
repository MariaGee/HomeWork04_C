//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]        6, 1, 33 -> [6, 1, 33]

int[] numbers = new int[8];

int[] EnteringArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

int[] ArrayOutput(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "  ");
    }
    return array;
}

numbers = EnteringArray(numbers);
Console.WriteLine("Был задан массив: ");
numbers = ArrayOutput(numbers);

