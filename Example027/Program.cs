//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11     82 -> 10    9012 -> 12

Console.WriteLine("Введите, пожалуйста, число");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int res = 0;
    while (num > 0)
    {
        int i = num % 10;
        num = num / 10;
        res = res + i;
    }
    return res;
}

Console.WriteLine("Сумма цифр в числе = " + Sum(number));