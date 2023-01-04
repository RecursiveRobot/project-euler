fn find_pythagorean_triplet_for(n: i32) -> (i32, i32, i32) {
    let solutions: Vec<(i32, i32, i32)> = 
        (1..n).flat_map(|a| 
            (1..n).flat_map(move |b| 
                (1..n).map(move |c| (a,b,c))))
        .filter(|(a,b,c)| a*a + b*b == c*c && a + b + c == n)
        .collect();

    solutions[0]
}

#[cfg(test)]
mod test {
    use super::*;

    #[test]
    fn test_solution() {
        let (a,b,c) = find_pythagorean_triplet_for(1000);

        assert_eq!(a * b * c, 31875000);
    }
}