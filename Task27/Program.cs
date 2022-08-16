//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using static System.Console;
Clear();

Write("Введите число");
string numberAstr = Convert.ToString(ReadLine());
 
int[] array = GetArrayFromString(numberAstr); 
result = SummArray(array);
Write($"Сумма цифр введенног числа = {result}");


int SummArray(int[] array)
{
int n = array.Length;
int result = 0;
for (int i = 0; i < n-1; i++)
    result = result + array[i];
return result;
}


int[] GetArrayFromString(string arrayString)
{     
    string[] massString = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result= new int [massString.Length];
    for (int i=0; i<result.Length; i++)
        result[i] = int.Parse(massString[i]);  
    return result; 
}