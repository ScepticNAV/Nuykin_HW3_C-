/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (((number >= -99999) && (number < -9999)) || ((number > 9999) && (number <= 99999)))
                return number;
            else
            {
                Console.WriteLine("В числе не пять цифр. Введите пятизначное число");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
    }
}

void FindPalindrom(int n)
{
    if (((n / 10000) == (n % 10)) & (((n / 1000) % 10) == ((n/ 10) % 10)))
    {
        Console.WriteLine($"Число является палиндромом");
    }

    else
    {  
        Console.WriteLine($"Число не является палиндромом");
    }
   
}

string message1 = "Введите пятизначное число, которое хотите проверить";
int num = GetNumber(message1);
FindPalindrom(num);