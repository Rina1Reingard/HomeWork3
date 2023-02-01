/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/


int Palindrome(string message)
{
    int number = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out number))
        {
            if(number > 9999 && number < 100000)
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

int pali = Palindrome ("Введите пятизначное число");

if (pali/10000 == pali%10 && (pali/1000)%10 == (pali%100)/10)
{
    Console.WriteLine($"число {pali} является палиндромом");
}
else
{
    Console.WriteLine($"число {pali} не является палиндромом");
}
