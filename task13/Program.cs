// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

metka:
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;

if (num < 0) num *= -1;
if (num < 100)
{
    Console.WriteLine("У этого числа нет третьей цифры");
    goto metka;
}
ThirdDigit(num);

void ThirdDigit(int number)
{
while (num >= 1000) num /= 10;
int result = num % 10;
Console.WriteLine($"Третья цифра числа {num1} -> {result}");
}