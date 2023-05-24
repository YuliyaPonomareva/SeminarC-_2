// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int EnterDigit()
{
    Console.WriteLine("Введите трёхзначное число: ");
    int n = int.Parse(Console.ReadLine()!);
    return n;
}
int FirstDigit (int n)
{
    int num = n / 10;
    return num;
}

int MiddleDigit (int num)
{
    int res = num % 10;
    return res;
}

void FindMiddle (int res)
{
    
    Console.WriteLine("Вторая цифра этого числа: " + res);
}

int n = EnterDigit();
int num = FirstDigit(n);
int res = MiddleDigit(num);
FindMiddle(res);