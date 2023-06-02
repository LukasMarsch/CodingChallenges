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

The solution you see here is a custom algorithm consisting of two "bars" on the number scale
    - i3 for all c -> c % 3 == 0
    - i5 for all c -> c % 5 == 0

we increase the i3 bar, and add all the multiples of 3 along the way
we only increase the i5 bar, once it is at least 5 units from i3
this way, if it is exactly 5 apart, we do not need to add i5 to sum, because we added it with i3 already.
these numbers are multiples of 3 and 5 (15, 30, 45, ...)
everything combined, we still O(n), butt significantly less comparisons (~25% less)
so i take that as a w
 */
 
 class Euler1 {
    static void Main(String[] args) {
        ushort n = 1000;
        ushort i3 = 0;
        ushort i5 = 0;
        uint sum = 0;

        
        DateTime start = DateTime.Now;

        while(i5 < n && i3 < n) {
            sum += i3;
            
            if(i5 + 5 <= i3) {
                i5 += 5;
                if(i5 != i3) {
                    sum += i5;
                }
            }
            i3 += 3;
        }

        Console.WriteLine("Time:  " + (DateTime.Now - start).ToString());
        Console.WriteLine("Summe: " + sum);
        // correct answer is 233168    
    }


}

