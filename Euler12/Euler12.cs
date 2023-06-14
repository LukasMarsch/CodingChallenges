/*
 * The triangle Numbers are a sequence of numbers. Each consists of the sums of all previous numbers. triangleNum(3) = 1 + 2 + 3; triangleNums(6) = 1 + 2 + 3 + 4 + 5 + 6
 * we can simplify this a little bit and say each number consists of its predecessor triangle num + itself triangleNum(2345) = triangleNum(2344) + 2345;
 * 
 * Now we need to find every divisor of these numbers.
 * There isn't a great way to do this but we can again simplify it a little but with a set<tuple<uint, list<uint>>
 * if we know triangleNum(1000) is divisible by 250250, we can look up what divisors we found for 250250 and can just add them to our list of divisors
 */
namespace Euler12;

class Program
{
  public static void Main(String[] args)
  {
    Stack<uint> triangleNums = new Stack<uint>();
    // HashSet<Tuple<uint, List<uint>> = new HashSet<Tuple<uint, List<uint>>();
    uint i = 1;
    triangleNums.Push(i);
    uint numOfDivisors = 0;
    while(numOfDivisors < 3 && i < 300)
    {
      i++;
      triangleNums.Push(i + triangleNums.Peek());
      Console.WriteLine(getNumOfDivisors(triangleNums.Peek()));
      Console.WriteLine(numOfDivisors);
    }
    Console.Write($"{triangleNums.Pop()} -> {numOfDivisors} Divisors");
  }

  private static uint getNumOfDivisors(uint n) 
  {
    Stack<uint> divisors = new Stack<uint>();
    for (int i = 1; i < (int) Math.Floor((double)n/2); i++)
    {
      if(i % n == 0)
      {
        divisors.Push((uint)i);
        Console.WriteLine(i);
      }
    }
    return (uint)divisors.Count;
  }
}
