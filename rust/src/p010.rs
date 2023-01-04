fn primes_below_n(n: i64) -> Vec<i64> {
    let mut primes = Vec::new();
    let mut sieve = vec![true; n as usize];
    for i in 2..n {
        if sieve[i as usize] {
            primes.push(i);
            let mut j = i*i;
            while j < n {
                sieve[j as usize] = false;
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
        let primes = primes_below_n(2_000_000);
        let solution = primes.iter().sum::<i64>();

        assert_eq!(solution, 142913828922);
    }
}