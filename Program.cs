
using System;
using System.Runtime.Intrinsics.X86;

public static class Program
{
    public static void Main(string[] args)
    {

        //  Task 1

        //fnFindMaxMin(int.MinValue, int.MaxValue);


        //  Task 2 
        //fnQuadraticEquation();

        // Task 3 
        //fnMagicBox();

    }

    public static void fnFindMaxMin(int max, int min)
    {
        //  Take 5 numbers from user
        //  Print max and min values
        //  Use least number of variables and least number of comparisons

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter number {i}: ");
            int num = int.Parse(Console.ReadLine());

            if (num > max) max = num;
            if (num < min) min = num;
        }
        Console.WriteLine($"Max: {max}, Min: {min}");
    }

    public static void fnQuadraticEquation()
    {
       
        //      For a quadratic equation: ax ^ 2 + bx + c = 0
        //      Take a, b, c values from user
        //      Output if roots are real, complex or equal roots

        Console.WriteLine("Enter Numbers for the quadratic equation (ax^2 + bx + c = 0):");
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            Console.WriteLine("Positive, Two Real Roots");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("Two Equal Roots");
        }
        else
        {
            Console.WriteLine("Negative, Complex Roots");
        }
    }

    public static void fnMagicBox()
    {
        /*
         
            Take an input from user (size n) - accept odd numbers > 1 only 
            Create a matrix order n*n 
            Arrange numbers from 1 -> n*n, in a way where:
            No numbers are repeated 
            Sum of all columns are equal 
            Sum of all rows are equal 
            Output: 
            Number - its row number - its column number 
            Solution to be implemented 
            1 - row = 1, col = (n + 1)/2 
            2 -> n*n
            (num -1) % n 
            if remainder -> row = prev. row - 1 (if r=0, then r=n), col = prev. col - 1 (if c=0, then c=n)
            if no remainder -> row = prev. row +1, col = prev. col
         */

        
        int Size;
        do
        {
            Console.Write("Enter an odd number greater than 1 for the size of the matrix: ");
            Size = int.Parse(Console.ReadLine());

        } while ((Size <= 1 || Size % 2 == 0));
        Console.WriteLine($"The Size of the Matrix will be: {Size}");
        int row = 1;
        int col = (Size + 1) / 2;

        for (int vMatrixNumber=1; vMatrixNumber<= Size * Size; vMatrixNumber++)
        {
          
            if (vMatrixNumber == 1) {

                Console.WriteLine($"{vMatrixNumber} - row = {row}, col = {col}");
                
            }

            if (vMatrixNumber > 1)
            {
                if ((vMatrixNumber - 1) % Size == 0)
                {

                    row = row + 1;
                }
                else
                {
                    row = row - 1;
                    col = col - 1;
                    if (row == 0)
                        row = Size;
                    if (col == 0)
                        col = Size;


                }
                Console.WriteLine($"{vMatrixNumber} - row = {row}, col = {col}");
            }
        }
    }
    

}
