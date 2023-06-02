using System.Collections.Generic;
/* 
Challenge:
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.

The very obvious solution is to just count them all by hand and add them i mean... How many can there be?

Let's get serious though. To find multiples of something you could divide and see if the result is a whole number
for (int i=0; i<1000; i++){
    if(isWholeNumber(i/3) OR isWholeNumber(i/5)){
        sum += i;
    }
}
This would probably work, but we have a far more elegant than trying to divide.
This mathematical operator is called modulo and looks like this "%"
It does division but leaves away all multiples of the divisor. So 3%2 = 0.5 instead of 1.5
We would still need to have to do a very boring loop to try every goddam number from 0 to 1000
for(int i = 0; i < 1000; i++) {
    if(i % 3 == 0 || i % 5 == 0) sum += i;
}

We can also find all multiples by adding the factor to 0:
0+3 = 3
3+3 = 6
6+3 = 9
...
this requires less iterations, in fact only 20-30% as many, butt:
we have a whole bunch of other problems, like checking wether a number is a multiple of 3 and 5 at the same time
 */
 class Euler1 {
    static void Main(String[] args) {
        DateTime start = DateTime.Now;
        HashSet<Int32> list = new HashSet<Int32>();
        foreach(int i in multiOfN(1000, 3)) {
            list.Add(i);
        }
        foreach(int i in multiOfN(1000, 5)) {
            list.Add(i);
        }

        int sum = list.Aggregate(1, (s, n) => s + n);
        Console.WriteLine("Sum of all multiples of 3 and 5 till 1000 is: " + sum);
        Console.WriteLine(DateTime.Now - start + " time");
        // correct answer is 233168    
    }

    static List<Int32> multiOfN(int size, int factor) {
        List<Int32> multiples = new List<Int32>();
        for(int i = factor; i < size; i+=factor) multiples.Add(i);
        return multiples;
    }


}

