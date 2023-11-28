namespace Program;

public static class Finder {
    public static void Main() {
        Console.WriteLine(Find(20, 20));
    }

    public static uint Find(uint x, uint y) => (x, y) switch {
        ((uint) 1, _)      => (uint) y,
        (_, (uint) 1)      => (uint) x,
        _           => Find((uint) x-1, (uint) y) + Find((uint) x, (uint) y-1),
    };

}
