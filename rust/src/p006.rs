#[cfg(test)]
mod test {
    #[test]
    fn test_solution() {
        let sum_of_squares = (1..=100).map(|x| x * x).sum::<i64>();
        let square_of_sum = (1..=100).sum::<i64>().pow(2);
        let solution = square_of_sum - sum_of_squares;

        assert_eq!(solution, 25164150);
    }
}