import Common
answer = maximum $ sieve $ factorsOf 600851475143

factorsOf n = [x | x <- [2..n-1], n `mod` x == 0]