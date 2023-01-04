#[cfg(test)]
mod test {
    #[test]
    fn test_solution() {
        let solution = 
            (1..=999)
                .filter(|&x| x % 3 == 0 || x % 5 == 0)
                .sum::<i32>();

        assert_eq!(solution, 233168);
    }
}