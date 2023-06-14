namespace Euler12;

class Program
{
  public static void Main(String[] args)
  {
    List<uint> triangleNums = new List<uint>(1000);
    uint i = 1;
    triangleNums.Add(i);
    while(i < 1000)
    {
      i++;
      triangleNums.Add(i + triangleNums[triangleNums.Count - 1]);
    }
    foreach (var item in triangleNums)
    {
      Console.Write($"{item}, ");
    }
  }
}
