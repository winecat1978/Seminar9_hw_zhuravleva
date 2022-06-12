// git remote add origin https://github.com/winecat1978/Seminar9_hw_zhuravleva.git
// git branch -M main
// git push -u origin main

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

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

void PrintNumbers (int N, int M)
{
    if(M <= N)
    {
        PrintNumbers(N-1,M);
        Console.Write($"{N} ");
    }
}

string messageN = "Введите N: ";
string messageM = "Введите M: ";
int N = GetNumber(messageN);
int M = GetNumber(messageM);
PrintNumbers(N,M);