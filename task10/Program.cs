// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

metka: Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine()), num1 = num;
if (num < 0) num *= -1;
if (num < 100 || num >= 1000)
{
    Console.WriteLine("Это не трёхзначное число");
    goto metka;
}
int result = SecondDigitOfThree(num);
Console.WriteLine($"вторая цифра числа {num1} -> {result}");

int SecondDigitOfThree(int number)
{
    return (number / 10) % 10;
}


