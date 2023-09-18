//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt(string message)
{
    Console.Write(message);//Выводим приглашение ко вводу
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);//Приводим к числу 
    return result;// Возвращаем результат  
}
int SumAllDigit(int number)
{
    int result = 0;
    while(number>0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = Prompt ("Введите число:");
Console.WriteLine ($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");
