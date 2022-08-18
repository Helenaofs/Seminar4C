

// Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите два числа:");
int[] array = new int[2];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int PowNumber(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}

Console.WriteLine(PowNumber(array[0], array[1]));
