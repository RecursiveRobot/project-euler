use super::p003::prime_factors;

// Iterate through each element in the factor list and divide successive factors by it.
fn get_unique_factors(mut res: Vec<i64>, remainder: Vec<i64>) -> Vec<i64> {
    if remainder.is_empty() {
        res
    }
    else {
        let head = remainder[0];
        let tail: Vec<i64> = remainder[1..].iter().map(|&x| if x % head == 0 { x / head } else { x }).collect();
        res.push(head);
        get_unique_factors(res, tail)
    }
}

#[cfg(test)]
mod test {
    use super::*;

    #[test]
    fn test_solution() {
        let solution: i64 = get_unique_factors(vec![], (1..=20).collect()).iter().product();

        assert_eq!(solution, 232792560);
    }
}