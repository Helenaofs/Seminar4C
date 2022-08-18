// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");

int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumNumber(int number)
{
    int LengthOfNumber = Convert.ToString(num).Length;
    for (int i = 0; i < LengthOfNumber; i++)
    {
        int count = num - num % 10;
        sum = sum + (num - count);
        num = num / 10;
    }
    return sum;
}

Console.WriteLine(SumNumber(num));
