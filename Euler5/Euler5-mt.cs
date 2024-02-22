/* 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

We are going to achieve this by testing the divisability of our number after increasing it. We always have to increase
it for atleast the highest Divisor we have.
 */

public class Program {
    public static void Main(string[] args) {
        Governor.init(10, 10000);
        Console.WriteLine(Governor.final_num);
    }

    //correct solution 232792560
}

public static class Governor {
    static List<Thread> workers = new();
    static object currentLock = new();
    static object findLock = new();
    static long current = 20;
    static bool found = false;
    public static long final_num = 0;

    public static void init(int workers_count, int size) {
        for(int i = 0; i < workers_count; i++) {
            workers.Add(new Thread(() => {
                bool selfFound = false;
                while(!found) {
                    long i;
                    long start;
                    lock(currentLock) {
                        start = current;
                        current += size;
                    }
                    i = start;
                    while(i < start + size - 20 && !selfFound) {
                        selfFound = divByAll(i);
                        if(selfFound) {
                            lock(findLock) {
                            if(i == 23279256){
                            Console.WriteLine("FOUND IT");
                            }
                                if(found || final_num != 0) {
                                    return;
                                } else {
                                    found = true;
                                    final_num = i;
                                    return;
                                }
                            }
                        }
                        i += 20;
                    }
                }
            }));
        }
        workers.ForEach((x) => {x.Start();});
        workers.ForEach((x) => {x.Join();});
    }

    static bool divByAll(long n){
        long allDivisable = 0;
        int num = 20;
        while(allDivisable == 0 && num > 0){
            allDivisable += n % num;
            num--;
        }
        return allDivisable == 0;
    }
}
