// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

metka: Console.WriteLine("Введите день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Вы точно знаете сколько дней в неделе?");
    goto metka;
}
else
{
    bool result = Week(number);
    Console.WriteLine(result ? "выходной" : "не выходной");
}
bool Week(int num)
{
    return num == 6 || num == 7;
}