// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
System.Console.WriteLine();

Console.WriteLine("Введите число A: ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int numB = int.Parse(Console.ReadLine()!);

int result = DegreeNum(numA, numB);

int DegreeNum (int numA,int numB) //ввели функцию, которая будет выводить в степень В
{
    int result = 1;
   int count=0;
   while(count<numB)
    {                     
        result *= numA; 
        count++;
    }
   return result;
}
     
//Console.WriteLine($"{numA} ^ {numB} = " + Math.Pow(numA,numB));

Console.WriteLine("Результат: " + result);
