answer = maximum $ filter isPalindrome [a * b | a <- [100..999], b <- [100..999]]

isPalindrome :: Int -> Bool
isPalindrome n = reverse (show n) == show n