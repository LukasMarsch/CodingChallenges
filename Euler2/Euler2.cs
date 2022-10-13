﻿/* Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms. 

Fibonacci Numbers are probably one of the first scenarios where you woul encounter an iteratively called function as the every value except 1 and 2 consist of previous values

So we just need to write a function for producing these Fibonaccis first
static means this function is limited to the scope of this script
int says we will return data of the type int, which is what we expect a fibonacci sum to be
int a and b are the two previous values supplied to our function
We use b as our current Fibonacci, as we always have to integrate the first b and we can't do this with nextFib
Then we just need to check whether it's below 4Mio and if it's evenso we can sum it up
Once we cross the 4Mio. line we don't have to go further just always pass the sum down our whole callstack as we reduce it
*/
static int fibonacciEvenSum(int a, int b, int sum){
    int nextFib = a+b;
    if(b < 4000000){
        if(b%2==0){ sum += b; }
        return fibonacciEvenSum(b, nextFib, sum);
    } else{ return sum; }
}

Console.WriteLine("even fibonacci sum is: " + fibonacciEvenSum(1,2,0));