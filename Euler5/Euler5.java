public class Euler5 {
    public static void main(String[] args) {
        boolean found = false;
        long i = 0;
        while(!found) {
            i += 20;
            found = div_by_all_20(i);
        }
        System.out.println(i);
    }

    private static boolean div_by_all_20(long x) {
        int rest = 0;
        int i = 1;
        while (rest == 0 && i <= 20) {
            rest += x % i;
            i++;
        }
        return rest == 0;
    }
}
