fn main() {
    let mut x = 20;
    while !divisible_till_20(&x) {
        x += 20;
    }
    println!("We have a number: {}", x);
}

fn divisible_till_20(x: &u64) -> bool {
    let mut is_divisible = true;
    let mut i = 1;
    while is_divisible && i <= 20 {
        is_divisible = x % i == 0;
        i += 1;
    }
    is_divisible
}
