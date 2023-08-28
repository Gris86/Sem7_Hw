// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int col=int.Parse(Console.ReadLine()!);

int[,] array=Getarray(rows, col);
Printarray(array);
average(array);


int[,] Getarray(int m, int n){
int[,] massive=new int[m,n];
    for(int i=0; i<m; i++){
        for(int j=0; j<n; j++) massive[i,j]=new Random().Next(1, 50);
    }
    return massive;
}

void Printarray(int[,] array){

    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


void average(int[,] array){
    double aver=0;
Console.Write($"Среднее арифметическое каждого столбца: ");
for(int i=0; i<array.GetLength(0);i++){
    aver=0;
    for(int j=0; j<array.GetLength(1);j++){
        aver+=array[i,j];
    }
    Console.Write($"{aver/array.GetLength(1):F1} ");
}

}