namespace Program;

public static class Finder {
    public static long[,]? memo;

    public static void Main() {
        Console.WriteLine(Find(20, 20));
    }

    public static long Find(long x, long y) {
        if(null == memo) {
            memo = new long[x+1,y+1];
            Array.Clear(memo);
        }

        if(memo[x,y] != 0)
            return memo[x,y];

        if(x == 0 | y == 0) 
            return 1;

        memo[x, y] = Find(x-1, y) + Find(x, y-1);
        memo[y, x] = memo[x,y];
        return memo[x,y];
    }
}
