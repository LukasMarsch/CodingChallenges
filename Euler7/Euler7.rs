fn main() {
    println!("{}", factorize(10001));
}

fn factorize(n: u32) -> u32 {
    let mut primes: Vec<u32>  = Vec::<u32>::with_capacity(10001);

    let mut index = 2;
    while primes.len() < n as usize {
        if primes.iter()
                .map(|x| index % x > 0)
                .all(|y| y) {
            primes.push(index);
        }
        index += 1;
    }

    let result = primes.last().unwrap();
    return *result
}
