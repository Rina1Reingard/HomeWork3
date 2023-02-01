/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


int Number(string message)
{
    int number = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out number))
        {
            if(number > 0)
                {break;
                }
        }
        else
        {
            Console.WriteLine("Ввели не число или некорректное число. Повторите ввод");
        }
    }
    return number;
}

int number2 = Number ("Введите число");

for (int i = 1; i <= number2; i++)
{
    Console.Write($"{i*i*i}, ");
}