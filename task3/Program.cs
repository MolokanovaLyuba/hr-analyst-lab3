// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

using System.Reflection.Metadata;

int Prompt(string message)
{
    Console.Write(message);//Выводим приглашение ко вводу
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);//Приводим к числу 
    return result;//Возвращаем результат 
}
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int [Length];//Объявляем массив
    Random random = new Random();
    for (int i=0;i<Length;i++)
    {
        array[i] = random.Next(minValue, maxValue +1);
    }
    return array;
}
void PrintArray(int[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
int Length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt ("Конечное значение, для диапазона случайного числа:");
int[] array = GenerateArray(Length, min, max);
PrintArray(array); 
