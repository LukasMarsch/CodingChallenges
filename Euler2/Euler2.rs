// find the sum of all even fibonacci numbers that are below 4.000.000

fn main() {
    let start = std::time::Instant::now();
    let max = 4000000;
    let mut stack = Vec::new();
    stack.push(1);
    stack.push(2);

    while stack.last().unwrap() < &max {
        let temp = stack.pop().unwrap();
        let new = stack.last().unwrap() + temp;
        stack.push(temp);
        stack.push(new);
    }
    println!("Time: {}e-6 s", start.elapsed().subsec_micros());
    println!("Sum: {}", stack[0..stack.len()-1].iter().filter(|y| *y % 2 == 0).sum::<u32>());
    // correct answer ist 4613732
}
