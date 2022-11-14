// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
System.Console.WriteLine();

Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine()!);
int len = NumberLen(num);
SumNumbers(num, len);

int NumberLen(int a) // Функция подсчета цифр в числе
{
    int len = 0;
    while (a > 0)
    {
        a /= 10;
        len++;
    }
    return len;
    
}

void SumNumbers(int num, int len) // Функция вывода суммы цифр в числе
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine(sum);
}
