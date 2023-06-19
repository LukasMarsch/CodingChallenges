// find the largest Prime factor of 600851475143

fn main() {
    let k = factors(600851475143);
    println!("We have a result {}", k.last().unwrap());
}

fn factors(mut n: u64) -> Vec<u64> {
    let mut out = vec![];
    for i in 2..(n+1) {
        while n % i == 0 {
            out.push(i);
            n /= i;
        }
        if n == 1 {break;}
    }
    out
}
