fn is_palindrome(n: i32) -> bool {
    let s = n.to_string();
    let r = s.chars().rev().collect::<String>();
    s == r
}

#[cfg(test)]
mod test {
    use super::*;

    #[test]
    fn test_solution() {
        let solution = 
            (100..=999)
                .flat_map(|x| (100..=999).map(move |y| x * y))
                .filter(|&x| is_palindrome(x))
                .max()
                .unwrap();

        assert_eq!(solution, 906609);
    }
}