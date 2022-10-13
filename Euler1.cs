/* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.

The very obvious solution is to just count them all by hand and add them i mean... How many can there be?

Let's get serious though. To find multiples of something you could divide and see if the result is a whole number
for (int i=0; i<1000; i++){
    if(isInt(i/3) OR isInt(i/5)){
        sum += i;
    }
}
This would probably work, but we have a far more elegant than trying to divide.
This mathematical operator is called modulo and looks like this %
It does division but leaves away all multiples of the divisor. So 3%2 = 0.5 instead of 1.5
We still have to do a very boring loop to try every goddam number from 0 to 1000
 */

int sum = 0;
for(int currentNumber=0; currentNumber<1000; currentNumber++){
    if(currentNumber%3==0 || currentNumber%5==0){
        sum+=currentNumber;
    }
}
Console.WriteLine(sum);