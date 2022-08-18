//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();

Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

int result = SummArray(number);
WriteLine($"Сумма цифр введенного числа = {result}");

int SummArray(int number)
{
    int razryad = digitCount(number);
    int n = razryad;
    int result = 0;
    int i = 1;
    while (i <= n)
    {
        result = result + (number %  MyPow(10, razryad)) / MyPow(10, razryad-1);
        razryad--;
        i++;
    }
    return result;
}


int digitCount(int number)
{
    int i = 0;
    while (number != 0)
    {
        number /= 10;  
        i++;
    }
    return i;
}


int MyPow(int a, int n)
{
    int myresult = 1;
    for (int i = 0; i < n; i++)
    myresult *= a;
    return myresult;
}