namespace amicable;
public class Program {
    public static void Main(string[] Args) {
        Dictionary<int, List<int>> numbers = new Dictionary<int, List<int>>();
        int n = 2;
        List<int> temp = new List<int>(0);
        while(n < 10000) {
            int p = SumOfDivisors(n);
            if(numbers.TryGetValue(p, out temp)) {
                temp.Add(n);
            } else {
                numbers.Add(p, new List<int>(){n});
            }
            n++;
        } 
        Console.WriteLine(SumOfAmicableNumbers(numbers));
    }

    private static int SumOfDivisors(int n) =>
        Enumerable.Range(1, n-1).Where(x => n % x == 0 && x != n).Sum();

    private static int SumOfAmicableNumbers(Dictionary<int, List<int>> numbers) {
        int sum = 0;
        foreach(var vp in numbers) {
            Console.WriteLine($"{vp.Key}: {vp.Value.ToString()}");
            if(vp.Value.Count() > 1) {
                sum += vp.Key;
            }
        }
        return sum;
    }
}
