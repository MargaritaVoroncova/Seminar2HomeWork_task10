// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int randomNum=new Random( ). Next (100, 999);
int remainder = randomNum%100;
int secondNumber=remainder/10;
Console.WriteLine($" Вторая цифра числа {randomNum} = {secondNumber}");
