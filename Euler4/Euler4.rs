// find the largest palindromic product of any two 3-digit numbers
fn main() {
    let a:Vec<i32> = (1..999).collect();
    let b:Vec<i32> = (1..999).collect();
    let mut products:Vec<i32> = Vec::new();
    let a_iter = a.iter();
    for num_a in a_iter {
        let b_iter = b.iter();
        for num_b in b_iter {
            products.push(num_a * num_b);
        }
    }
    let res = products
        .iter()
        .filter(|x|
        is_palindrome(x))
        .max();
    println!("{}", res.unwrap());
}

fn is_palindrome(x: &i32) -> bool {
    let mut iter: usize = 0;
    let digits:Vec<u8> = to_vec(*x);
    let end = digits.len() -1;
    let mut res = true;
    while iter < end {
        res = res & (digits[iter] == digits[end - iter]);
        iter += 1;
    }
    res
}

fn to_vec(x: i32) -> Vec<u8> {
    let mut n = x;
    let mut res:Vec<u8> = Vec::new();
    while n > 0 {
        res.push((n % 10) as u8);
        n = (n as f32 / 10 as f32).floor() as i32;
    }
    res
}
