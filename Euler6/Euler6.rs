fn main() {
    let lim = 100;

    let mut sum_of_squares = 0;
    let mut square_of_sums = 0;
    for i in 0..lim+1 {
        sum_of_squares += i * i;
    }

    for i in 0..lim+1 {
        square_of_sums += i;
    }
    square_of_sums = square_of_sums * square_of_sums;
    println!("{}", square_of_sums - sum_of_squares);
}
