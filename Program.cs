/*
0zadacha. Перевернуть маасив.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(minValue, maxValue + 1);
   
   return array;
}

void ReverseArray(int[] array)
{
   for(int i = 0, j = array.Length -1; i < j; i++, j--)
   {
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
   }
}

void ShowArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");

   Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);
*/

/*
//1z. 1 Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
bool TreangleCheck(int a, int b, int c)
{
    return (a < b + c && b < a + c && c < a + b);
}
Console.WriteLine("Treangle ceck Program");
Console.Write("input a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("input c = ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(TreangleCheck(a,b,c) ? "YES it is treangle":"NO, it is not" );
*/
/*
//2z. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
void Fibonachchi(int a, int b, double[] array)
{
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("input N = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input b = ");
int b = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Fibonachchi(a, b, array);
ShowArray(array);
*/
/*
//3z.Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] CopyMas(int[] mas)
{
    int[] array = new int[mas.Length];
    for (int i = 0; i < mas.Length; i++)
        array[i] = mas[i];
    return array;
}
void ShowMas(int[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length; i++)
    {
        if (i != mas.Length - 1) Console.Write($"{mas[i]}:");
        else Console.Write($"{mas[i]}]");
    }
    Console.WriteLine();
}
int[] SetMas(int size, int min, int max)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
        mas[i] = new Random().Next(min, max+1);
    return mas;
}
Console.WriteLine("Program Copy Mas");
Console.Write("Input size = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input MIN value = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input MAX value = ");
int max = Convert.ToInt32(Console.ReadLine());
int[] mas1 = SetMas(size,min,max);
ShowMas(mas1);
int[] mas2 = CopyMas(mas1);
ShowMas(mas2);
*/

/*
//MyrepozCSDz006.
//Zadacha43.2.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double numberX = (b2 - b1)/(k1 - k2);
double numberY = k1 * numberX + b1;
	
Console.WriteLine($"Точка пересечения двух прямых: {numberX},{numberY}");
*/
/*
//Zadacha. 41.1.Nesmog.
int volume = 5;  // кол-во ввода чисел
int count = 0;

while (volume > 0)
{
    Console.Write("Введите число:   ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0) count++;
    volume--;
}

Console.WriteLine($"Количество чисел больше 0: {count}");
*/
//Gotovo!
