/*
Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] SortRowInDescOrder(int[,] matrix)//сортировка строк по убыванию значения
{
    
    int[,] result=new int[matrix.GetLength(0), matrix.GetLength(1)];
    
    for (int s = 0; s < matrix.GetLength(0); s++)
    {
       
        /* 
        подфункция сортировки одромерного массива методом вставки.

        Внешний цикл начинает работу со второго элемента массива. 
        Запоминаем значение второго элемента массива. 
        Во внутреннем цикле сравниваем каждый предыдущий элемент массива с текущим и, 
        при необходимости, меняем их местами до тех пор, пока не дойдем до начала цикла
        или пока не встретится элемент более текущего. В результате массив отсортируется по убыванию.
        */
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int j = i;
            while (j > 0 && result[s,j - 1] < matrix[s,i])
            {
                result[s,j] = result[s,j - 1];
                j--;
            }
            result[s,j] = matrix[s,i];
        }

    }


    return result;
}







int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int range=Prompt("enter matrix value generator range: ");
int[,] matr=FillMatrix(r,c,range);
System.Console.WriteLine("Generated matrix is: ");
PrintMatrix(matr);


System.Console.WriteLine($"Matrix with row values sorted in descending order:  ");
PrintMatrix(SortRowInDescOrder(matr));



