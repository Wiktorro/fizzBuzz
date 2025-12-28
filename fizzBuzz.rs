
const N : i32 = 14; // CONSTS MUST BE COMPILE TIME KNOWN
const remainder3 : i32 = N % 3;
const remainder5 : i32 = N % 5;
/*  
*/
fn f64_div_rem(x: i64, m: i64) -> (i64, i64) {
    // strawman implementation; might not have the best possible accuracy
    let rem = x % m;
    let div = (x - rem) / m;
    (div, rem)   // satisfies  x == div * m + rem
}
fn main() {
    let mut volatile : bool = true; // only with mut are mutable AND MODIFIABLE IN LIFETIME
    for number in 0..=20 {
        // simple LET vars are const by default , name .._var IS CRUCIAL
        let remainder3_var : i32 = number % 3;
        let remainder5_var : i32 = number % 5;
        
        if remainder5_var == 0 && true { // AND TRUE is placeholder to prove && works
            if remainder3_var == 0 {
                println!("{}", "FizzBuzz");    
            }
            else { println!("Buzz"); }  // brackets NECESSARY
        } else if remainder3_var == 0 {
            println!("Fizz"); // same as println! with newline \n
        }
        else {
            println!("{}", number);
        }
        volatile = false;
    }
    println!("{}", volatile);
}
