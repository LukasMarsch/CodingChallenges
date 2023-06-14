/*
 * The triangle Numbers are a sequence of numbers. Each consists of the sums of all previous numbers. triangleNum(3) = 1 + 2 + 3; triangleNums(6) = 1 + 2 + 3 + 4 + 5 + 6
 * we can simplify this a little bit and say each number consists of its predecessor triangle num + itself triangleNum(2345) = triangleNum(2344) + 2345;
 * 
 * Now we need to find every divisor of these numbers.
 * There isn't a great way to do this but we can again simplify it a little but with a set<tuple<uint, list<uint>>
 * if we know triangleNum(1000) is divisible by 250250, we can look up what divisors we found for 250250 and can just add them to our list of divisors
 */
namespace Euler12;

using System.Collections;

class Program
{
  static Hashtable cache;
  public static void Main(String[] args)
  {
    cache = new Hashtable();
    Stack<uint> triangleNums = new Stack<uint>();
    uint i = 1;
    triangleNums.Push(i);
    uint numOfDivisors = 0;
    while(numOfDivisors < 500)
    {
      i++;
      triangleNums.Push(i + triangleNums.Peek());
      numOfDivisors = getNumOfDivisors(triangleNums.Peek());
    }
    Console.Write($"{triangleNums.Pop()} -> {numOfDivisors} Divisors");
  }

  private static uint getNumOfDivisors(uint n) 
  {
    HashSet<uint> divisors = new HashSet<uint>();
    for (uint i = (uint) Math.Floor((double)n/2); i > 0;  i--)
    {
      if(n % i == 0)
      {
        try{
          cache.Add(i, getDivisors(i));
        }
        catch(ArgumentException ex){
          //Console.WriteLine(ex.ToString());
        }
        finally
        {
          divisors.UnionWith((IEnumerable<uint>) cache[i]);
          divisors.Add(i);
        }
      }
    }
    return (uint) divisors.Count;
  }

  private static HashSet<uint> getDivisors(uint n)
  {
    HashSet<uint> divisors = new HashSet<uint>((int)Math.Floor(Math.Sqrt(n)));

    for(uint i = 1; i < (uint) Math.Floor(n/2.0); i++)
    {
      if( n % i == 0)
      {
        if(cache.ContainsKey(i))
        {
          divisors.UnionWith((IEnumerable<uint>) cache[i]);
        }
        else
        {
          cache.Add(i, getDivisors(i));
          divisors.UnionWith((IEnumerable<uint>)cache[i]);
        }
        divisors.Add(i);
      }
    }
    return divisors;
  }
}
