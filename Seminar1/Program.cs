/* Task 1 Напишите программу, которая на вход принимает два числа и 
проверяет, является ли первое число квадратом второго.

int num1, num2;
string result;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
    result = "Yes";
else
    result = "No";

Console.WriteLine(result);
*/

/* Task 2 Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input psitive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++; // то же самое, что и current = current + 1;
}
*/

//1234 / 10 -> 123
//1234 % 10 -> 4

//1234 % 100 -> 34
//1234 / 100 -> 12

// 1234 / 10 % 100 -> 23

// Task 3 Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает последнюю цифру этого числа. (Доделать)
/*
int a = 13523532;

while (a > 999)
{
    a /= 10; // то же самое, что a = a / 10;
}
Console.WriteLine(a);
*/

/* Task 4 Дни недели

Console.Write("Input the number (1 - 7): ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1) Console.WriteLine("Monday");
if (num == 2) Console.WriteLine("Tuesday");
if (num == 3) Console.WriteLine("Wednsday");
if (num == 4) Console.WriteLine("Thursday");
if (num == 5) Console.WriteLine("Friday");
if (num == 6) Console.WriteLine("Saturday");
if (num == 7) Console.WriteLine("Sunday");
*/

/* Task 5 Принимает число и выдает его квадрат

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());

num = num * num;

Console.WriteLine("Result = " + num);
*/