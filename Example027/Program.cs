﻿//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11     82 -> 10    9012 -> 12

Console.WriteLine("Введите, пожалуйста, число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while (number > 0)
{
    int i = number % 10;
    number = number / 10;
    sum = sum + i;
}

Console.WriteLine("Сумма цифр в числе = " + sum);