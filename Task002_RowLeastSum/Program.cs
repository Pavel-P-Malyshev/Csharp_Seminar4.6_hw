/*
Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка
*/



int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}



int[,] FillMatrix(int rows, int columns, int range)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j]=new Random().Next(1,range+1);

        }

    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} [{i},{j}] ");

        }
        Console.WriteLine();
    }

}

int LeastRowSum(int[,] matrix)
{
    int leastRowSum=0;
    int currentRowSum=0;
    int leastSumRowIndex=0; 

    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            leastRowSum+=matrix[0,j];

        }

    //Console.WriteLine($"least row 0  sum={leastRowSum}");

    
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentRowSum+=matrix[i,j];
            

        }
        
        //Console.WriteLine($"current row [{i}] sum={currentRowSum}");
        if (currentRowSum<leastRowSum)
        {
            leastRowSum=currentRowSum;
            leastSumRowIndex=i;
        }

        currentRowSum=0;
    }
    
   return leastSumRowIndex;
}







int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int range=Prompt("enter matrix value generator range: ");
int[,] matr=FillMatrix(r,c,range);
System.Console.WriteLine("Generated matrix is: ");
PrintMatrix(matr);


System.Console.WriteLine($"Row index (starting from zero) of least elements sum is:  {LeastRowSum(matr)}");





