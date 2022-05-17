// напишите программу, которая выводит случайное 3-х значное число и удаляет вторую цифру этого числа
int num = new Random().Next(100, 1000);

Console.WriteLine("Число = " + num);
string text = num.ToString();
Console.WriteLine("Модификация трехзначного числа: " + num + "-> " + text[0] + text [2]);

int num2 = (num / 100) * 10 + num % 10;
Console.WriteLine("Модификация трехзначного числа: "+ num + "-> " + num2);
