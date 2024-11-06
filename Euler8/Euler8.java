import java.io.BufferedReader;
import java.io.FileReader;
import java.nio.CharBuffer;

import org.omg.CORBA.CharSeqHolder;

public class Euler8 {
    public static void main(String[] args) {
        
        CharBuffer buf = CharBuffer.allocate(100);
        StringBuilder sb = new StringBuilder();
        BufferedReader br;
        try {
            java.io.FileReader fr = new FileReader("./data.txt");
            br = new BufferedReader(fr);
            
        } catch (Exception e) {
            System.out.println("File not Found!");
            return;
        }
        String loc = "";
        while(loc != null) {
            sb.append(loc);
            try {
                loc = br.readLine();
            } catch (Exception e) {
                System.out.println("End of File!");
            }
        }
        System.out.println(maxProd13(sb.toString()));
    }

    static long maxProd13(String s) {
        long max = 0;
        int len = 13;
        int idx = 0;
        int total = s.length();
        while(idx + len < total) {
            long localPoint = strProd(s.substring(idx, idx+len));
            if(localPoint > max) {
                max = localPoint;
            }
            idx++;
        }
        return max;
    }

    static long strProd(String s) {
        int end = s.length();
        long product = 1;
        for (int i = 0; i < end; i++) {
            product *= (int) s.charAt(i) - 48;
        }
        return product;
    }
}