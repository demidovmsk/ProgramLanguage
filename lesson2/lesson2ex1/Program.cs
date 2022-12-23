// Напишите программу, которая выводит случайное число
// из отрезка [18, 99] и показывает наибольшую цифру числа.
// 78 -> 8 12-> 2 85 -> 8

Random random = new Random();
int randomNumber = random.Next(10,100);

int LastDigit = randomNumber % 10;
int firstDigit = randomNumber / 10 % 10;

//double tmp = (double)randomNumber / 10;

//Console.WriteLine(tmp);

Console.WriteLine(randomNumber);

if(LastDigit > firstDigit)
{
    Console.WriteLine(LastDigit);
}
else
{
    Console.WriteLine(firstDigit);
}