namespace amicable;
public class Program {
    public static void Main(string[] Args) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        int n = 2;
        while(n < 10000) {
            int p = SumOfDivisors(n);
            if(p > 1)
                numbers.Add(n, p);
            n++;
        } 
        Console.WriteLine(SumOfAmicableNumbers(numbers));
    }

    private static int SumOfDivisors(int n) =>
        Enumerable.Range(1, n/2).Where(x => n % x == 0 && x != n).Sum();

    private static int SumOfAmicableNumbers(Dictionary<int, int> numbers) {
        HashSet<int> sum = new HashSet<int>();
        int temp;
        foreach(var valuePair in numbers) {
            if(numbers.TryGetValue(valuePair.Value, out temp)) {
                if(temp == valuePair.Key && valuePair.Value != temp) {
                    sum.Add(valuePair.Key);
                }
            }
        }
        foreach(var i in sum)
            Console.WriteLine(i);
        return sum.Sum();
    }
}
