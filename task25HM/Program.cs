/*  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/
Console.WriteLine("Введите числа А и Б");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int ProductOfNumber(int a, int b)
{
    int product = 1;
    for(int i = 1; i <= b; i++)
    {
        product = product * a;
    }
    return product;
}
Console.WriteLine($" Число {numberA} в степени {numberB} равно {ProductOfNumber(numberA, numberB)}");