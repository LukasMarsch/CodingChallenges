/* The sum of the squares of the first ten natural numbers is,

1^2+2^2+...+10^2 = 385

The square of the sum of the first ten natural numbers is,^

(1+2+...+10)^2 = 55^2 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .

3025-385 = 2640

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 
This is really just some simple math 
*/

static int sumOfSquares(int numbers){
    int sum = 1;
    for(int count = 0; count >= numbers; count++){
        sum += (int)Math.Pow((double)count, (double)2);
        Console.WriteLine(sum);
    }
    return sum;
}

static double squareofSums(int numbers){
    int sum = 1;
    for(int count = 0; count >= numbers; count++){
        sum += count;
    }
    return Math.Pow((double)sum, (double)2);
}

static double compareSquareSums(int numbers){
    double resSqoS = squareofSums(numbers);
    int resSuoS = sumOfSquares(numbers);
    return resSqoS - resSuoS;
}

Console.WriteLine(compareSquareSums(100));