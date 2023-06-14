/* By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number? 

prime numbers are very compute-intensive and very interesting for cyber-security
we will utilize the factorization to calculate our primes*/

using System.Collections;
class Primes{
    public static void Main(){
        Console.WriteLine(factorize(10001));
        //correct answer is 104743
    }

    static long factorize(int input){
        DateTime beginning = DateTime.Now;
        ArrayList Primes = new ArrayList();
        long counter = 2;
        Primes.Add(counter);
        while(Primes.Count < input){
            counter += 1;
            bool divisable = true;
            foreach(long currentPrime in Primes){
                divisable = (counter%currentPrime==0);
                if(divisable){
                    break;
                }
            }
            if(!divisable){
                Primes.Add(counter);
            }
        }
        Console.WriteLine(Primes.Count);
        TimeSpan end = DateTime.Now - beginning;
        Console.WriteLine(end);
        return (long)Primes[Primes.Count-1];
    }
}