package CaloriesCounting;

import java.io.*;
import java.nio.charset.StandardCharsets;
import java.nio.file.FileSystems;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Random;
import java.util.stream.IntStream;
import java.util.stream.Stream;

import static java.nio.file.StandardOpenOption.CREATE;

public class Main {
    public static void main(String[] args) throws IOException {

        buildFile();

        BufferedReader reader = new BufferedReader(new FileReader("AdventOfCode/CaloriesCounting/calories.txt"));

        Stream<String> stream = reader.lines();
        Iterator<String> iterator = stream.iterator();
        ArrayList<Integer> list = new ArrayList<>();
        IntStream.Builder builder = IntStream.builder();

        while(iterator.hasNext()){
            String current = iterator.next();
            if(current.matches("\\D+")) {
                throw new CharConversionException(current);
            } else
                if(current.matches("\\d+")) {
                    builder.accept(Integer.parseInt(current));
            } else
                if (current.matches("")) {
                    list.add(builder.build().sum());
                    builder = IntStream.builder();
            }
    }
        stream.close();
        int maximum = list.stream().max(Integer::compareTo).get();
        int nummer = list.indexOf(maximum) + 1;
        System.out.println("Fee Nummer " + nummer + " hat mit " + maximum + " die meisten Kalorien an Bord");
    }

    private static void buildFile() throws IOException {
        Path path = FileSystems.getDefault().getPath("AdventOfCode", "CaloriesCounting", "calories.txt");

        IntStream.Builder builder = IntStream.builder();
        Random rand = new Random();
        for (int index = 0; index < 10000000; index++) {
            builder.accept(rand.nextInt(0,100));
        }
        BufferedWriter writer = Files.newBufferedWriter(path, StandardCharsets.UTF_8, CREATE);

        IntStream stream = builder.build();
        stream.forEach(c -> {
            if(0 <= c && c <= 1){
                try {
                    writer.write("\n");
                } catch (IOException e) {
                    throw new RuntimeException(e);
                }
            }
            try {
                writer.write(c+"\n");
            } catch (IOException e) {
                throw new RuntimeException(e);
            }
        });
    }
}
