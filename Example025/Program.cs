//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)      2, 4 -> 16

int[] numbers = new int[2];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Введите " + (i+1) + " число:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int result = 1;
for (int j = 0; j < numbers[1]; j++)
{
    result = result * numbers[0];
}

Console.WriteLine("Число " + numbers[0] + " в " + numbers[1] + " степени = " + result);