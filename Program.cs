// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();

Console.WriteLine("Введите число: ");
double number = double.Parse(Console.ReadLine()!);
double digit = 1;

while (digit <= number){
    double cube = Math.Pow(digit,3);
    Console.Write($"{cube}, ");
    digit++;
}
