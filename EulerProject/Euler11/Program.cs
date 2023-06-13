namespace Euler11;

public enum Direction {
  Right,
  Down,
  UpLeft,
  UpRight
}

class Euler11
{
  public static void Main(String[] args){
    Table t = new Table();
    int max = 0;
    while(t.cursor.position < 400)
    {
      
      var temp = getMax(t);
      max = Math.Max(max, temp);
      t.cursor.rightWithLineBreak();
    }
    // Console.WriteLine(max);
  }

  // returns the maximum product of all directions from the given table
  private static int getMax(Table table)
  {
    int max = 0;
    foreach(Direction d in Enum.GetValues(typeof(Direction)))
    {
      int[] temp = TryInvoke(d, table);
      max = Math.Max(max, ArrayProduct(temp));
      Console.WriteLine($"{d} at {table.cursor.position}");
      ArrayPrint(temp);
    }
    Console.WriteLine("----------------");
    return max;
  }

  // Returns an array of values or an empty array, if an error was thrown
  public static int[] TryInvoke(Direction d, Table t) {
    try
    {
      switch (d)
      {
        case Direction.Right : return FourAdjacent.FourInARow(t); 
        case Direction.Down : return FourAdjacent.FourDown(t);
        case Direction.UpLeft : return FourAdjacent.FourUpLeft(t);
        case Direction.UpRight : return FourAdjacent.FourUpRight(t);
          default: throw new NotSupportedException($"Case {d} not supported");
      }
    }
    catch (System.Exception)
    {
      return new int[0] {};
    }
  }

  public static void ArrayPrint(int[] array)
  {
    Console.Write(@"{");
    foreach (int item in array)
    {
      Console.Write($"{item}, ");
    }
    Console.Write(@"}" + "\n");
  }

  private static int ArrayProduct(int[] array)
  {
    int product = 1;
    foreach (var item in array)
    {
      product *= item;
    }
    Console.WriteLine(product);
    return product;
  }
}
