// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using static System.Console;
Clear();

Write("Введите число a: ");
int numberA = int.Parse(ReadLine());
Write("Введите число b: ");
int numberB = int.Parse(ReadLine());
int step = MyPow(numberA, numberB);
Write($"Число а в натуральной степени числа b = {step}");


int MyPow(int a, int n)
{
int myresult = 1;
for (int i = 0; i<n; i++)
myresult *= a;
return myresult;
}