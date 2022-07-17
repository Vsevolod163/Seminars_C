/* int FindBiggerDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec) return ed;
    else return dec;

}

int number = new Random().Next(10,100);
int digit = FindBiggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {digit}");
*/

/* bool IsKratno(int n1, int n2)
{
    if(n1 % n2 == 0) return true;
    else return false;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool kratno = IsKratno(num1, num2);

Console.WriteLine(kratno);
*/
/*
// программа, которая берет трехзначное число и удаляет вторую цифру
int Number (int num)
{
    int first = num / 100;
    int end = num % 10;
    int final = first * 10 + end;
    return final;
}

int number = new Random().Next(100, 1000);
int result = Number(number);
Console.WriteLine($"Заданное число {number}, Результат {result}");\
*/
/*
// Задача 2 кратность на 7 и 23
bool IsKratno(int n1)
{
    if(n1 % 7 == 0 && n1 % 23 == 0) return true;
    else return false;
}

Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

bool kratno = IsKratno(num1);

Console.WriteLine(kratno);
*/

/* Задача 3 Проверяет является ли число квадратом другого
bool IsSquare(int n1, int n2)
{
    if(n1 ==  n2 * n2 || n1 * n1 == n2) return true;
    else return false;
}
 
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool square = IsSquare(num1, num2);

Console.WriteLine(square);
*/