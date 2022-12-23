// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

Random random = new Random();
int number = random.Next(100,1000);

Console.WriteLine(number);

int firstDigit = number / 100;
int LastDigit = number % 10;
int newDitgit = firstDigit * 10 + LastDigit;

Console.WriteLine(newDitgit);
