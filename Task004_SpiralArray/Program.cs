/*
Задача 4. Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/



int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
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

//алгоритм позамсствовал здесь:
//https://www.haikson.com/programmirovanie/zapolnenie-dvumernoj-matritsyi-po-spirali/
int[,] SpiralArray(int size)
{
    int[,] result=new int[size,size]; 

    int Ibeg = 0;
    int Ifin = 0;
    int Jbeg = 0; 
    int Jfin = 0;
    
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= size*size)
    {
        result[i,j] = k;
        if (i == Ibeg && j < size - Jfin - 1)
        {
            ++j;
        }
        else if (j == size - Jfin - 1 && i < size - Ifin - 1)
        {
            ++i;
        }
        else if (i == size - Ifin - 1 && j > Jbeg)
        {
            --j;
        }
        else
        {
            --i;
        }

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != size - Jfin - 1))
        {
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }
        
    return result;
}






int s=Prompt("enter square matrix size: ");


while(s<2)
{
    System.Console.WriteLine("size too small, reenter size! ");
    s=Prompt("enter square matrix size: ");

}

System.Console.WriteLine("Matrix filled with increasing values spirally is: ");
PrintMatrix(SpiralArray(s));






