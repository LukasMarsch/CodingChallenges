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
    int maxPos = 0;
    String dir = "";
    while(t.cursor.position < 400)
    {
      Tuple<int, String> temp = getMax(t);
      if(max < temp.Item1)
      {
        max = temp.Item1;
        maxPos = t.cursor.position;
        dir = temp.Item2;
      }
      t.cursor.RightWithLineBreak();
    }
    Console.WriteLine($"{max} is the maximum Product at {maxPos} in direction {dir}");
  }

  // returns the maximum product of all directions from the given table
  private static Tuple<int, String> getMax(Table table)
  {
    int max = 0;
    String dir = "";
    foreach(Direction d in Enum.GetValues(typeof(Direction)))
    {
      List<int> temp = TryInvoke(d, table);
      if(max < ArrayProduct(temp))
      {
        max = ArrayProduct(temp);
        dir = d.ToString();
      }
    }
    return new Tuple<int, String>(max, dir);
  }

  // Returns an array of values or an empty array, if an error was thrown
  public static List<int> TryInvoke(Direction d, Table t)
  {
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
      return new List<int>(0);
    }
  }

  public static void ArrayPrint(ICollection<int> array)
  {
    Console.Write(@"{");
    foreach (int item in array)
    {
      Console.Write($"{item}, ");
    }
    Console.Write(@"}" + "\n");
  }

  private static int ArrayProduct(ICollection<int> array)
  {
    int product = 1;
    foreach (int i in array)
    {
      product *= i;
    }
    // Console.WriteLine(product);
    return product;
  }
}
