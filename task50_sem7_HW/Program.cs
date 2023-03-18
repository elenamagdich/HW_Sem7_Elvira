// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по данным индексам такого числа в массиве нет




Console.WriteLine("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];
FillArray(numbers);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-99, 100);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
        {
         Console.Write($"{array[i, j]} ");
        }   
        Console.WriteLine(); 
    }
}


if (rows > numbers.GetLength(0) || columns > numbers.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента {rows} строки и {columns} столбца =  {numbers[rows-1,columns-1]}");
}
PrintArray(numbers);
