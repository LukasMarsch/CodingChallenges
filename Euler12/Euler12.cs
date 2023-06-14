namespace Euler12;

class Program
{
  public static void Main(String[] args)
  {
    Stack<uint> triangleNums = new Stack<uint>();
    uint i = 1;
    triangleNums.Push(i);
    while(i < 1000)
    {
      i++;
      triangleNums.Push(i + triangleNums.Peek());
    }
    try
    {
      while(triangleNums.Peek() != null)
      {
        Console.Write($"{triangleNums.Pop()}, ");
      }   
    }
    catch (System.Exception)
    {
      Console.Write("\nfinished");
    }

  }
}
