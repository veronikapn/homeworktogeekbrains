//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindMidleDigit (int number)
{
    int ed = number % 10;
    int hund = number / 100;

    int midle = number - hund * 100 - ed;
    return midle;
}
int randNamber = newRandom().Next(10, 100);
int number = FindMidleDigit(randNamber);
Console.WriteLine(number);