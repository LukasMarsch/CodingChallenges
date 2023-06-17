// find the sum of all multiples of 3 or 5 between 1 and 1000
use std::time::Instant;

fn main() {
    let start = Instant::now();
    let mut bar = 0;
    let mut sum = 0;
    while bar < 1000 {
        sum += bar;
        bar += std::cmp::min(3 - (bar % 3), 5 - (bar % 5));
    }
    println!("Time\t|\t{}e-6 s", start.elapsed().subsec_micros());
    println!("--------------------------");
    println!("Sum\t|\t{}", sum);
}
