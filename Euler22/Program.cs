namespace names;

public class Program {
    public static void Main(string[] Args) {
        List<string> names = frp("names.txt");
        names.Sort();
        int sum = 0;
        for(int i = 0; i < names.Count; i++) {
            sum += alphapos(names, i);
        }
        Console.WriteLine(sum);
    }

    //read text file
    private static List<string> frp(string p) {
        FileStream fs = new FileStream(p, FileMode.Open);
        StreamReader reader = new StreamReader(fs);
        List<string> namesList = new List<string>((int)fs.Length);
        while(!reader.EndOfStream) {
            string? t = reader.ReadLine();
            if(t == null) {
                break;
            } else {
                namesList.Add(t);
            }
        }
        return namesList;
    }

    //calculate alphabetical Value
    public static int alphaVal(string s) {
        short sum = 0;
        foreach(byte b in s) {
            sum += (short)(b-64);
        }
        return sum;
    }

    //multiply order position with alphaval
    public static int alphapos(IList<string> list, int i) => (i+1) * alphaVal(list[i]);
}
