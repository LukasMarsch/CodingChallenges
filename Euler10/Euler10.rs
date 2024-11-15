// sum of the primes below 2.000.000

fn main() {
    let max = 2000000;
    let mut sieve = (2..max as u64).zip([false].repeat(max-2 as usize)).collect::<Vec<_>>();
    
    let mut index: usize = 0;
    let mut sum: u64 = 0;
    while index < max-2 {
        // this number is a prime, if the flag is still false
        if !sieve[index].1 {
            // set multiples to true
            let mut j: usize = 2;
            while sieve[index].0 as usize * j < max {
                let multiple = sieve[index].0 as usize * j as usize;
                sieve[multiple-2].1 = true;
                j += 1;
            }
            // since it's a known prime, we can add it to the sum
            sum += sieve[index].0;
        }
        // advance the index
        index += 1;
    }
    println!("{sum}");
}
