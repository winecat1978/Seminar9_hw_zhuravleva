// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 

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

int AkkermanFunction (int N, int M)
{
    if (N==0) return M+1;
    if ((N!=0) && (M == 0))
    {
        return AkkermanFunction(N-1, 1);
    }
    if ((N > 0) && (M > 0))
    {
        return AkkermanFunction(N-1, AkkermanFunction(N,M-1));
    }
    return AkkermanFunction(N,M);
}


string messageN = "Введите N: ";
string messageM = "Введите M: ";
int N = GetNumber(messageN);
int M = GetNumber(messageM);

int result = AkkermanFunction(N,M);
Console.WriteLine(result);