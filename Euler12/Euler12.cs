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
  // static Hashtable cache;
  public static void Main(String[] args)
  {
    uint prev = 0;
    uint current = 1;
    uint i = 1;
    uint numOfDivisors = 0;
    while(numOfDivisors < 500)
    {
      current = i;
      current += prev;
      numOfDivisors = getNumOfDivisors(current);
      prev = current;
    }
    Console.Write($"{current} -> {numOfDivisors}");
  }

  private static uint getNumOfDivisors(uint n) 
  {
    Stack<uint> divisors = new Stack<uint>();
    for (uint i = (uint) Math.Ceiling((double)n/2) + 1; i > 0;  i--)
    {
      if(n % i == 0)
      {
        divisors.Push(i); 
      }
    }
    divisors.Push(n);
    foreach(uint i in divisors) Console.Write($"{i}, "); Console.Write("\n\n");
    return (uint) divisors.Count;
  }
}
