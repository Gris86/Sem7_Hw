//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// позиция i = 4, j = 2 -> такой позиции нет
// позиция i = 1, j = 0 -> 5

Console.WriteLine("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int col=int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер строки элемента массива: ");
int rowsFind=int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца элемента массива: ");
int colFind=int.Parse(Console.ReadLine()!);


double[,] array=Getarray(rows, col);
Printarray(array);
PrintarrayFind(array, rowsFind, colFind);


double[,] Getarray(int m, int n){
double[,] massive=new double[m,n];
    for(int i=0; i<m; i++){
        for(int j=0; j<n; j++) massive[i,j]=new Random().NextDouble()*10.0;
    }
    return massive;
}

void Printarray(double[,] array){

    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]:F2} ");
        }
        Console.WriteLine();
    }
}

void PrintarrayFind(double[,] array, int m, int n){

    if((m>=array.GetLength(0))||(n>=array.GetLength(1)))
        Console.WriteLine($"позиция i = {m}, j = {n} -> такой позиции нет");
    else 
        Console.WriteLine($"позиция i = {m}, j = {n} -> {array[m,n]:F2}");
}