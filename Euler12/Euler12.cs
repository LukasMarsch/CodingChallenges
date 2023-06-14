/*
 * The triangle Numbers are a sequence of numbers. Each consists of the sums of all previous numbers. triangleNum(3) = 1 + 2 + 3; triangleNums(6) = 1 + 2 + 3 + 4 + 5 + 6
 * we can simplify this a little bit and say each number consists of its predecessor triangle num + itself triangleNum(2345) = triangleNum(2344) + 2345;
 * 
 * Now we need to find every divisor of these numbers.
 * We can simplify our search by realizing every n % i == 0 produces a n/i = k, which has n % k == 0
 * This limits our trial to Sqrt(n) values at maximum
 * And we have blazingly fast results
 */
namespace Euler12;

using System.Collections;

class Program
{
  // static Hashtable cache;
  public static void Main(String[] args)
  {
    uint prev = 0;
    uint current = 1;
    uint i = 1;
    uint numOfDivisors = 0;
    uint max = 0;
    while(numOfDivisors < 500)
    {
      current = i;
      current += prev;
      numOfDivisors = getNumOfDivisors(current);
      prev = current;
      i++;
      if(numOfDivisors > max)
      {
        max = numOfDivisors;
        Console.WriteLine($"[{i}]{current} -> {numOfDivisors}");
      }
    }
    Console.Write($"{current} -> {numOfDivisors}");
  }

  private static uint getNumOfDivisors(uint n) 
  {
    // Stack to store the valid divisors
    Stack<uint> divisors = new Stack<uint>();

    // create an array with all possible divisors
    uint[] arr = new uint[(int) Math.Ceiling(Math.Sqrt(n))];

    // and fill it
    for (uint i = 0; i < arr.Length; i++)
    {
      arr[i] = i + 1;
    }

    // Form a list from it, so we can remove values we don't need to test
    List<uint> iter = new List<uint>(arr);

    if((uint) Math.Sqrt(n) == Math.Sqrt(n))
    {
      divisors.Push((uint) Math.Sqrt(n));
      for(uint i = 1; i < (uint) Math.Sqrt(n); i++)
      {
        if(n % i == 0)
        {
          divisors.Push(i);
          divisors.Push(n/i);
        }
      }
      return (uint) divisors.Count;
    }
    // try every value
    for(uint i = (uint) iter.Count - 1; i > 0; i--)
    {
      if(n % i == 0)
      {
        divisors.Push(i); 
        if(!divisors.Contains((uint) n/i))
        {
          divisors.Push((uint)n/i);
        }
        iter.Remove((uint) n/i);
      }
    }
    // foreach (var item in divisors)
    // {
    //   Console.Write($"{item}, ");
    // }
    // Console.Write("\n\n");
    return (uint) divisors.Count;
  }
}
