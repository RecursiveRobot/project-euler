fn fibo(n: i32) -> i32 {
    match n {
        0 => 1,
        1 => 1,
        n => fibo(n - 1) + fibo(n - 2),
    }
}

#[cfg(test)]
mod test {
    use super::*;

    #[test]
    fn test_solution() {
        let solution = 
            (1..)
                .map(fibo)
                .take_while(|&x| x < 4_000_000)
                .filter(|&x| x % 2 == 0)
                .sum::<i32>();

        assert_eq!(solution, 4613732);
    }
}