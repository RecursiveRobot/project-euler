// Returns all the prime factors of a number
// Example: 315 = 3 * 3 * 5 * 7
// Returns: [3, 3, 5, 7]
pub fn prime_factors(mut n: i64) -> Vec<i64> {
    let mut factors = Vec::new();
    let mut d = 2;
    while n > 1 {
        if n % d == 0 {
            factors.push(d);
            n /= d;
        }
        else {
            d += 1;
        }
        // Short-circuit once we reach the square root of n
        if d * d > n {
            // The remaining n is a prime factor
            if n > 1 {
                factors.push(n);
            }
            break;
        }
    }
    factors
}


#[cfg(test)]
mod test {
    use super::*;

    #[test]
    fn test_solution() {
        let primes = prime_factors(600851475143);
        let solution = primes.iter().max().unwrap().to_owned();

        assert_eq!(solution, 6857);
    }
}