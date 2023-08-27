/* Напишите программу, которая принимает число и выдает
количество цифр в числе
*/
Console.WriteLine("введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Quantity (int number)
{
    int count = 0;
    while (number > 0)
    {
        count ++;
        number = number / 10; 
    }
    return count;
}
Console.WriteLine(Quantity(userNumber));