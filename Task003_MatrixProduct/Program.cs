/*
Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] product=new int[matrix1.GetLength(0),matrix2.GetLength(1)]; 

        
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                product[i,j]+=matrix1[i,k]*matrix2[k,j]; 
            }
                       

        }
        
               
    }
    
   return product;
}







int r1=Prompt("enter matrix1 rows number: ");
int c1=Prompt("enter matrix1 columns number: ");


int r2=Prompt("enter matrix2 rows number: ");
int c2=Prompt("enter matrix2 columns number: ");


while(c1!=r2)
{
    System.Console.WriteLine("Your cannot multiply these matrices! Matrix1 columns number must be equal to Matrix2 rows number. ");
    r1=Prompt("enter matrix1 rows number: ");
    c1=Prompt("enter matrix1 columns number: ");

    r2=Prompt("enter matrix2 rows number: ");
    c2=Prompt("enter matrix2 columns number: ");

}

int range1=Prompt("enter matrix1 value generator range: ");
int[,] matr1=FillMatrix(r1,c1,range1);
int range2=Prompt("enter matrix2 value generator range: ");
int[,] matr2=FillMatrix(r2,c2,range2);

System.Console.WriteLine("Generated matrix1 is: ");
PrintMatrix(matr1);

System.Console.WriteLine("Generated matrix2 is: ");
PrintMatrix(matr2);


System.Console.WriteLine($"Matrix1 and Matrix2 multiplication product is:  ");
PrintMatrix(MatrixProduct(matr1,matr2));




