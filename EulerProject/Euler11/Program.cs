namespace Euler11;

enum Directions : Func<FourAdjacent, int[]>
{
    Func<FourAdjacent, int[]> right = f => f.FourInARow(),
    Func<FourAdjacent, int[]> down  = f => f.FourDown(),
    Func<FourAdjacent, int[]> upright = f => f.FourUpRight(),
    Func<FourAdjacent, int[]> upleft  = f => f.FourUpLeft()
}

class Euler11
{
  public static void Main(String[] args){
    var t = new Table();
    var f = new FourAdjacent(t);
    int max = 0;
    while(t.cursor.value() < 400)
    {
      max = Math.Max(max, getMax(f));
      t.cursor.rightWithLineBreak();
    }
    Console.WriteLine(max);
  }

  // returns the maximum product of all directions from the given field
  private int getMax(FourAdjacent field)
  {
    int[] up = TryInvoke(Directions.up, field);
    int[] right = TryInvoke(Directions.right, field);
    int[] upleft = TryInvoke(Directions.upleft, field);
    int[] upright = TryInvoke(Directions.upright, field);

    int max = ArrayProduct(up);
    max = Math.max(ArrayProduct(right), max);
    max = Math.max(ArrayProduct(upleft), max);
    max = Math.max(ArrayProduct(upright), max);
    return max;
  }

  // Returns an array of values or an empty array, if an error was thrown
  public int[] TryInvoke(Func<FourAdjacent, int[]> function, FourAdjacent fourAdjacent) {
    int[] result;
    try
    {
      result = function(fourAdjacent);
    }
    catch (System.Exception)
    {
      int[] result = new int[0];
    }
    return result;
  }

  private int ArrayProduct(int[] array)
  {
    int product = 1;
    Array.ForEach(array, x => product *= x);
    return product;
  }
}
