namespace abundance;
public class Program {
    public static void Main(string[] args) {
        // find abundand numbers (max - 12)
        Console.WriteLine(SumOfAllNonSums());
    }

    public static int SumOfDivisors(int n) =>
        Enumerable.Range(1, n/2).Where(x => n%x == 0 && n != x).Sum();
    //public static bool IsAbundand(int n) => SumOfDivisors(n) > n;

    // set with all numbers of 1 - 28123
    public static HashSet<int> numberSet() => Enumerable.Range(1, 28123).ToHashSet();

    //list all abundand numbers
    public static List<int> abundandNumberList() {
        List<int> abundand = new List<int>();
        for(int i = 1; i < 28123; i++) {
            int t = SumOfDivisors(i);
            if(t > i) {
                abundand.Add(i);
            }
        }
        return abundand;
    }

    // find all numbers that are not sums of two abundand numbers (max is 28123)
    // sum of abundand numbers 1 -> end, 2 -> end, etc.
    // remove result from set
    public static int SumOfAllNonSums(int max = 28123) {
        HashSet<int> validNumbers = numberSet();
        List<int> abundandNumbers = abundandNumberList();

        for(int i = 0; i < abundandNumbers.Count; i++) {
            for(int j = i; j < abundandNumbers.Count; j++) {
                validNumbers.Remove(abundandNumbers[i] + abundandNumbers[j]);
            }
        }
        foreach(var s in validNumbers)
            Console.WriteLine(s);
        return validNumbers.Sum();
    }
}
