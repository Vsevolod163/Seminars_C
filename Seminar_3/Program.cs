/* Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void ShowDiaposon(int quart)
{
    while(quart < 1 || quart > 4)
    {
        Console.Write("Uncorrect input! Try again here: ");
        quart = Convert.ToInt32(Console.ReadLine());
    }
    
    if(quart == 1) Console.WriteLine("x > 0, y > 0");
    if(quart == 2) Console.WriteLine("x < 0, y > 0");
    if(quart == 3) Console.WriteLine("x < 0, y < 0");
    if(quart == 4) Console.WriteLine("x > 0, y < 0");
}

Console.Write("Input number of quart: ");
int quartNum = Convert.ToInt32(Console.ReadLine());

ShowDiaposon(quartNum);


// Task 2 Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int ShowQuart(int x, int y)
{
    while(x == 0 || y == 0)
    {
        Console.Write("The point is on the axis! Try again: ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
    }
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
}

Console.Write("Input x: ");
int coordinateX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int coordinateY = Convert.ToInt32(Console.ReadLine());

int numbquart = ShowQuart(coordinateX, coordinateY);
Console.Write ("Данная точка в четверти " + numbquart)
*/
/* Task 3 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double distance (int x1, int y1, int x2, int y2)
{
    double Pif = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return Pif;
}

Console.Write("Input x1: ");
int coordinateX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int coordinateY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int coordinateX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int coordinateY2 = Convert.ToInt32(Console.ReadLine());


double Distance = distance(coordinateX1, coordinateX2, coordinateY1, coordinateY2);
Console.Write("The distanse is " + Distance);
*/
/* Task 4 Напишите программу, которая принимает на вход число (N) и выдаёт последовательность квадратов чисел от 1 до N. (void)

void Numbers(double N)
{
    int current = 1;
    while (current <= N)
    {
        double quad = current * current;
        Console.Write(quad + " ");
        current ++;
    }    


} 
Console.Write("Input number: ");
double num = Convert.ToDouble(Console.ReadLine());
Numbers(num);
*/

