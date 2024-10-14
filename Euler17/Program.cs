using System.Text;

public class Program {

    public static void Main() {
        int counter = 0;
        init();
        Console.WriteLine(d[11]);
        for (int i = 1; i <= 1000; i++) {
            string s = ToString(ToList(i));
            Console.WriteLine(s);
            counter += s.Length;
        }
        Console.WriteLine(counter);
    }

    static Dictionary<int, string> d = new Dictionary<int, string>();

    private static void init() {
        d.Add(0, "");
        d.Add(1, "one");
        d.Add(10, "ten");
        d.Add(100, "onehundred");
        d.Add(1000, "onethousand");

        d.Add(11, "eleven");
        d.Add(12, "twelve");
        d.Add(13, "thirteen");
        d.Add(14, "fourteen");
        d.Add(15, "fifteen");
        d.Add(16, "sixteen");
        d.Add(17, "seventeen");
        d.Add(18, "eighteen");
        d.Add(19, "nineteen");
        
        d.Add(2, "two");
        d.Add(20, "twenty");
        d.Add(200, "twohundred");

        d.Add(3, "three");
        d.Add(30, "thirty");
        d.Add(300, "threehundred");

        d.Add(4, "four");
        d.Add(40, "forty");
        d.Add(400, "fourhundred");

        d.Add(5, "five");
        d.Add(50, "fifty");
		d.Add(500, "fivehundred");
		d.Add(6, "six");
		d.Add(60, "sixty");
		d.Add(600, "sixhundred");
		d.Add(7, "seven");
		d.Add(70, "seventy");
		d.Add(700, "sevenhundred");
        d.Add(8, "eight");
        d.Add(80, "eighty");
        d.Add(800, "eighthundred");

        d.Add(9, "nine");
        d.Add(90, "ninety");
        d.Add(900, "ninehundred");

        d.Add(-1, "and");
    }

    private static List<int> ToList(int number) {
        double dnum = Convert.ToDouble(number);
        List<int> digits = new List<int>((int) Math.Log10(number) + 1);

        while(dnum > 0) {
            dnum /= 10;
            digits.Add((int) Math.Round(10 * (dnum % 1)));
            dnum = Math.Floor(dnum);
        }
        digits.Reverse();
        return digits;
    }

    private static string ToString(List<int> digits) {
        foreach(int i in digits)
            Console.Write(i);
        Console.Write(": ");
        StringBuilder sb = new StringBuilder();
        int len = digits.Count();
        for(int i = 1; i <= len; i++) {
            //teen block
            if((int) Math.Pow(10, len-i) == 10 && digits[i-1] == 1) {
                sb.Append(d[digits[i-1] * 10 + digits[i]]);
                return sb.ToString();
            }
            // normal digit
            else {
                sb.Append(d[digits[i-1] * (int) Math.Pow(10, len-i)]);
            }

            // "and" Block
            if(len-i == 2 && (digits[len - 1] != 0 | digits[len - 2] != 0)) {
                sb.Append(d[-1]);
            } else if(len-i == 2 && (digits[len - 1] == 0 && digits[len-2] == 0)) {
                return sb.ToString();
            }
        }
        return sb.ToString();
    }
}
