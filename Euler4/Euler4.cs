/* 
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.

Here we present the almighty brute-force. If you don't have the brains, you're gonna have to have to computing power.
Just loop through all numbers and check whether the products are palindromes. store and compare those and find the biggest one, easy?
 */
using System.Collections;

static int reverseNumber(int n){
    int reverse = 0;
    int lastDigit = 0;
    while(n>0){
        lastDigit = n%10;
        n = n-lastDigit;
        n = n/10;
        reverse *= 10;
        reverse += lastDigit;
    }
    return reverse;
}

static bool isPalindrome(int n){
    return (reverseNumber(n)==n);
}

static int? numberMixer(){
    var results = new ArrayList();
    for(Int16 a=999; a>99; a--){
        for(Int16 b=999; b>99; b--){
            //Console.WriteLine(a + " " + b);
            if(isPalindrome(a*b)){
                results.Add(a*b);
            }
        }
    }
    results.Sort();
    int size = results.Count;
    var f = results[size-1];
    return (int?)f;
}

Console.WriteLine($"largest palindrom product from 2 3-digit factors {numberMixer()}");
//correct answer 906609
