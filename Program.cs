// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double [,] Create2dArray ()
{
    Console.WriteLine("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Input minimum: ");
    int MinVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input maximum: ");
    int MaxVal = Convert.ToInt32(Console.ReadLine());

    double [,] created2Array = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i,j] = new Random().Next(MinVal, MaxVal + 1) + new Random().NextDouble();
        }
    }
    return created2Array;
}

void Print2Array (double [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d [i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] new2dArray = Create2dArray();
Print2Array(new2dArray);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
int [,] Create2dArray ()
{
    // Console.WriteLine("Input count of rows: ");
    int rows = new Random().Next(0, 10);
    // Console.WriteLine("Input count of columns: ");
    int columns = new Random().Next(0, 10);

    // Console.WriteLine("Input minimum: ");
    int MinVal = new Random().Next(0, 10);
    // Console.WriteLine("Input maximum: ");
    int MaxVal = new Random().Next(10, 100);
    

int [,] created2Array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i,j] = new Random().Next(MinVal, MaxVal + 1);
        }
    }
    return created2Array;
}

void Print2Array (int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d [i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


    Console.WriteLine("Input number of row of element: ");
    int elemRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of column of element: ");
    int elemCols = Convert.ToInt32(Console.ReadLine()); 




int [,] new2dArray = Create2dArray();
Print2Array(new2dArray);
if (elemRows > new2dArray.GetLength(0) || elemCols > new2dArray.GetLength(1))
{
    Console.WriteLine("Not valid value of number row or column of element");
}
else
{
    Console.WriteLine($"Element of {elemRows} row and {elemCols} column is {new2dArray[elemRows-1,elemCols-1]}");
}
*/


//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] Create2dArray ()
{
    // Console.WriteLine("Input count of rows: ");
    int rows = new Random().Next(0, 10);
    // Console.WriteLine("Input count of columns: ");
    int columns = new Random().Next(0, 10);

    // Console.WriteLine("Input minimum: ");
    int MinVal = new Random().Next(0, 10);
    // Console.WriteLine("Input maximum: ");
    int MaxVal = new Random().Next(10, 100);
    

int [,] created2Array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i,j] = new Random().Next(MinVal, MaxVal + 1);
        }
    }
    return created2Array;
}

void Print2Array (int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d [i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void  Average (int [,] array) {
for (int j = 0; j < array.GetLength(1); j++){
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        average += array[i, j];
    }
    average /= array.GetLength(0);
    Console.Write(average + "; ");
 }
}




int [,] new2dArray = Create2dArray();
Print2Array(new2dArray);
Console.WriteLine();
Average(new2dArray);



