//Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 ->кратно

Random random = new Random();

int randomNumber1 = random.Next(10, 100);
int randomNumber2 = random.Next(1, 10);

Console.WriteLine(randomNumber1);
Console.WriteLine(randomNumber2);

if ((randomNumber1 % randomNumber2) != 0)
{
    Console.WriteLine(randomNumber1 % randomNumber2);
}
else
{
    Console.WriteLine("кратно");
}
