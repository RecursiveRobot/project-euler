answer = product $ reqFactors [] [1..20]

-- Iterate through the list and divide successive numbers by the found factor
-- This builds up the factor list (including multiples), which can be returned
reqFactors :: [Int] -> [Int] -> [Int]
reqFactors factorList [] = factorList
reqFactors factorList (x:xs) = reqFactors (x : factorList) ((\n -> if n `mod` x == 0 then n `div` x else n) <$> xs)