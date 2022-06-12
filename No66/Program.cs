// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetNumber (string msg)
{
    Console.WriteLine(msg);
    string value_from_console = Console.ReadLine();
    if(int.TryParse(value_from_console, out int num))
    {
        if (num > 0) return num;
        else 
        {
            Console.WriteLine("Введите положительное число.");
        }
    }
    else 
    {
        Console.WriteLine("Введите число.");
    }
    return num;
}

int SummaChisel (int M, int N)
{
    if (M != N)
    {
       M = SummaChisel(M,N-1) + N;
    }
    return M;
}

string messageN = "Введите N: ";
string messageM = "Введите M: ";
int N = GetNumber(messageN);
int M = GetNumber(messageM);
int res = SummaChisel(M,N);
Console.WriteLine($"Сумма элементов между ними равна {res}");