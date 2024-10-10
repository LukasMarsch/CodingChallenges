using System.Numerics;

public class Program {
    public static void Main(string[] args) {
        BigInteger d = System.Numerics.BigInteger.Pow(new BigInteger(2), 1000);
        BigInteger ten = new BigInteger(10);
        BigInteger sum = 0;
        BigInteger remainder = 0;
        while(d >= 1) {
            d = BigInteger.DivRem(d, ten, out remainder);
            sum += remainder;
        }

        Console.Write(sum);
    }
}
