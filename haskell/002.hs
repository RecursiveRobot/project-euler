answer = sum $ takeWhile (< 4000000) $ filter even fibs

fibs = fst <$> iterate (\(a,b) -> (b,a+b)) (1,2)