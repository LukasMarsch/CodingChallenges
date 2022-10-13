/* The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ? 

So this one seems quite a bit trickier. Especially consider 600851475143 is a long and most operations are only suited for integer sized numbers. But there are still possibilities
that may introduce some computing time but it'll hopefully stay reasonable*/

internal class Program
{
    private static void Main(string[] args)
    {
        static string primfaktorZerlegung(long n)
        {
            string s = "";
            long max = (long)Math.Sqrt(n);
            while (n % 2 == 0)
            {
                s = s + "2";
                n = n / 2;
                if (n > 1) s = s + "*";
                else return s;
            }
            while (n % 3 == 0)
            {
                s = s + "3";
                n = n / 3;
                if (n > 1) s = s + "*";
                else return s;
            }
            while (n % 5 == 0)
            {
                s = s + "5";
                n = n / 5;
                if (n > 1) s = s + "*";
                else return s;
            }
            long primfaktor = 7, increment = 4, letzteZahl = n;
            bool letzteZahlprim = true;
            while (n != 1 && primfaktor <= max)
            {
                if (n % primfaktor == 0)
                {
                    s = s + primfaktor;
                    n = n / primfaktor;
                    letzteZahlprim = false;
                    letzteZahl = n;
                    if (n > 1) s = s + "*";
                }
                else
                {
                    primfaktor = primfaktor + increment;
                    increment = 6 - increment;
                    letzteZahlprim = true;
                }
            }
            if (letzteZahlprim) s = s + letzteZahl;
            return s;
        }
        Console.WriteLine(primfaktorZerlegung(600851475143));
    }
}