//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System.Globalization;

Console.WriteLine("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int col=int.Parse(Console.ReadLine()!);

double[,] array=Getarray(rows, col);
Printarray(array);


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