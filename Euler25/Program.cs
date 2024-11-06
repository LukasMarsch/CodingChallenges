using System.Numerics;

namespace fib1000;
public class Program {
    public static void Main() {
        Console.Write(MaxLimitMethod(999));
    }
    public static int MaxLimitMethod(int n) {
        BigInteger maxLimit = BigInteger.Pow(10, n);
        BigInteger x = 1;
        BigInteger y = 1;
        BigInteger tmp = 0;
        int currentIndex = 2;

        while (x.CompareTo(maxLimit) <= 0)
        {
            tmp = x + y;
            y = x;
            x = tmp;
            currentIndex++;
        }
        Console.WriteLine(x);
        return currentIndex;
    }
}
