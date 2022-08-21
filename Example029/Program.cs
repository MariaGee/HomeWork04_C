//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]        6, 1, 33 -> [6, 1, 33]

// int[] EnteringArray(int number)
// {
//     int[] arr = new int[number];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 10);
//     }
//     return arr;
// }

void ArrayInputAndOutput(int number)
{
    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + "  ");
    }
}

Console.WriteLine("Был задан массив: ");
ArrayInputAndOutput(8);

