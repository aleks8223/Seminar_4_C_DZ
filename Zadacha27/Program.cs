// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе {totalResult(number)}");

int totalResult(int number)
{
    int count = Convert.ToString(number).Length;
    int temp = 0;
    int res = 0;

    for (int i = 0; i < count; i++)
    {
        temp = number - number % 10;
        res = res + (number - temp);
        number = number / 10;
    }
return res;
}