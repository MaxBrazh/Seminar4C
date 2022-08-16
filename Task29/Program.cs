//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using static System.Console;
Clear();
string arrayString = ReadLine();
string[] massString = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
if (massString.Length == 8)
{
int[] array = GetArrayFromString(massString); 
WriteLine($"[{String.Join(",",array)}]");  
}
else
WriteLine("Длина массива не равна 8!");



int[] GetArrayFromString(string[] massString) 
{     
int[] result= new int [massString.Length];   
for (int i = 0; i < result.Length; i++)     
{         
    result[i] = int.Parse(massString[i]);     
}     
return result; 
}