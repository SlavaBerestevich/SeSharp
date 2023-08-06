/* 12. Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если второе число не кратно первому, 
то программа выводит остаток от деления
*/
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
{
    Console.WriteLine($"число {number1} кратно {number2}");
}
else 
{
    int number3 = number1 % number2;
    Console.WriteLine($"остаток равен {number3}");
}