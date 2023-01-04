import Common
answer = sum $ filter (\n -> n `hasFactor` 3 || n `hasFactor` 5) [1..999]