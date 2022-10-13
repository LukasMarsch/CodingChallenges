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