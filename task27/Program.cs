/* Напишите программу, которая принимает на вход число и выдает сумму чисел в нем
*/
Console.WriteLine("введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int SumOfNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.WriteLine($"Сумма чисел в числе {userNumber} равна {SumOfNumber(userNumber)}");
