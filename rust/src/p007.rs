// Returns the first n prime numbers, using the sieve of erosthenes
pub fn first_n_primes(n: usize) -> Vec<i64> {
    let mut primes: Vec<i64> = Vec::new();
    let mut sieve = vec![true; 1_000_000];
    for i in 2..sieve.len() {
        if sieve[i] {
            primes.push(i as i64);
            if primes.len() == n { break; }
            // Mark every multiple of i as non-prime, starting at the square of i (optional optimization)...
            let mut j = i * i;
            while j < sieve.len() {
                sieve[j] = false;
                j += i;
            }
        }
    }
    primes
}

#[cfg(test)]
mod test {
    use super::*;

    #[test]
    fn test_solution() {
        let solution = first_n_primes(10_001).last().unwrap().to_owned();

        assert_eq!(solution, 104743);
    }
}