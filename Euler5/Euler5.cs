/* 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

We are going to achieve this by testing the divisability of our number after increasing it. We always have to increase
it for atleast the highest Divisor we have.
 */
static int findSmallestByAllDivisable(int n){
    bool allDivisable = false;
    int num = 0;
    while(!allDivisable){
        num+=20;
        allDivisable = false;
        for(int i = n; i>0; i--){
            allDivisable = (num%i)==0;
            if(!allDivisable){break;}
        }
    }
    return num;
}
Console.WriteLine(findSmallestByAllDivisable(20));
//correct solution 232792560