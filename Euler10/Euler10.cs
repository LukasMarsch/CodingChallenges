/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.

Simple sieve of eratosthenes. Just remove all the n*k you looked at and sum up what remains. (with some caveats)
*/

/// Implementation of the sieve of Eratosthenes for finding all the primes up to
/// a given number (MAX in this case).
/// From the command line:
///   Step 1 (Compile): csc PrimesSieve.cs
///   Step 2 (Run):     .\PrimesSieve
public class PrimesSieve {
  static void Main() {
    const int MAX = 2000000;
    // Create an array of boolean values indicating whether a number is prime.
    // Start by assuming all numbers are prime by setting them to true.
    bool[] primes = new bool[MAX + 1];
    for (int i=0; i<primes.Length; i++) {
      primes[i] = true;
    }
		
    // Loop through a portion of the array (up to the square root of MAX). If
    // it's a prime, ensure all multiples of it are set to false, as they
    // clearly cannot be prime.
    for (int i=2; i<Math.Sqrt(MAX)+1; i++) {
      if (primes[i-1]) {
        for (int j=(int) Math.Pow(i,2); j<=MAX; j+=i) {
          primes[j - 1] = false;
        }
      }
    }

    // Output the results
    int count = 0;
    long sum = 0;
    for (int i = 2; i < primes.Length; i++) {
      if (primes[i - 1]) {
        sum += i;
        count++;
      }
    }
    Console.WriteLine($"There are {count} primes up to {MAX}");
    Console.WriteLine($"The sum is {sum}");
  }
}