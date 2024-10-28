// 1-1-1991
// 31-12-2000
// 31days in 1, 3, 5, 7, 8, 10, 12
// 30days in 4, 6, 9, 11
// 28days in 2 except leap year
// leap year is any year evenly div by 4 except century except div by 400
// 
// HOW MANY SUNDAYS WERE ON THE FIRST OF THE MONTH
//
// 1 Mon
// 2 Tue
// 3 Wed
// 4 Thu
// 5 Fri
// 6 Sat
// 7 Sun

namespace BruteForce;

public class Program {
    private static HashSet<int> longMonths = new HashSet<int>();
    private static HashSet<int> shortMonths = new HashSet<int>();
    public static void Main(string[] args) {
        init();
        int year = 1900;
        int month = 1;
        int day = 1;
        int dow = 1;
        int counter = 0; 
        bool leap = IsLeapYear(year);

        while(year < 2001) {
            bool dayCarry = false;
            bool monthCarry = false;

            if(year > 1900 && day == 1 && dow == 7) {
                counter += 1;
            }

            //day boundary checker/incrementer
            //it's a long month 31 days
            if(day == 31) {
                day = 1;
                dayCarry = true;
            //it's a short month 30 days
            } else if(shortMonths.Contains(month) && day == 30){
                day = 1;
                dayCarry = true;
            // it's february?
            } else if(month == 2 && day >= 28) {
                // it's feb in a leap year
                if(leap && day == 29) {
                    day = 1;
                    dayCarry = true;
                // or not
                } else if(!leap && day == 28) {
                    day = 1;
                    dayCarry = true;
                } else {
                    day++;
                }
                // it's just a normal day
            } else {
                day += 1;
            }

            // weekday incrementer
            if(dow == 7)
                dow = 1;
            else
                dow++;

            // month incementer
            if(dayCarry) {
                month++;
                month = month % 13;
                if(month == 0) {
                    month = 1;
                    monthCarry = true;
                }
            }
            
            // year incrementer
            if(monthCarry) {
                year++;
            }
        }
        Console.WriteLine(counter);
    }

    static bool IsLeapYear(int year) {
        bool leap = false;
        leap = year % 4 == 0;
        if(year % 100 == 0)
            leap = year % 400 == 0;
        return leap;
    }

    static void init() {
        shortMonths.Add(4);
        shortMonths.Add(6);
        shortMonths.Add(9);
        shortMonths.Add(11);
    }
}
