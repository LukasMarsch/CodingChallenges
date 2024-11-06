using System.Numerics;

namespace factorial;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine(sumOfDigits(factorial(100)));
    }

    private static BigInteger factorial(BigInteger n) {
        if(n == 0) 
            return new BigInteger(1);
        if(n > 0)
            return BigInteger.Multiply(n, factorial(n-1));

        throw new IndexOutOfRangeException("n is negative");
    }

    private static int sumOfDigits(BigInteger i) {
        BigInteger sum = new BigInteger(0);
        BigInteger temp;
        while(i > 0) {
            i = BigInteger.DivRem(i, 10, out temp);
            sum += temp;
        }
        if(BigInteger.Subtract(sum, new BigInteger(Math.Pow(10, 31))) > 0) {
            throw new FormatException("Result too big for 32 bit integer");
        } else {
            return (int)sum;
        }
    }
}
