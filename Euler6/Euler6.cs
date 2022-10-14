/* The sum of the squares of the first ten natural numbers is,

1^2+2^2+...+10^2 = 385

The square of the sum of the first ten natural numbers is,^

(1+2+...+10)^2 = 55^2 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .

3025-385 = 2640

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 
This is really just some simple math and that's why we're going to use the Math class :D
*/
using System;
class compareSquaresAndSums {
    public static void Main()
    {
        int numbers = 100;
        double sqros = squareOfSums(numbers);
        double sumos = sumOfSquares(numbers);
        Console.WriteLine(sqros - sumos);
        //correct answer is 25164150
    }
    static double sumOfSquares(int numbers){
        double sum = 0;
        for(int count = 0; count <= numbers; count++){
            sum += Math.Pow(count, 2.0);
        }
        return sum;
    }

    static double squareOfSums(int numbers){
        double sum = 0;
        for(int count = 1; count <= numbers; count++){
            sum += count;
        }
        return Math.Pow(sum, 2.0);
    }
}