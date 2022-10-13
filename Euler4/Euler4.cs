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
