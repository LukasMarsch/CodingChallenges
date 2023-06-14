fibs = 0 : 1 : zipWith (+) fibs (tail fibs)

limiter :: [Int] -> Int
limiter [] = error "leere liste"
limiter [x]
    | x < 4000000 = x
    | otherwise = error "zu groß"
    limiter (x:xs)
    | x > 4000000 = error "zu groß"
    | take 1 xs < 4000000 = limiter xs
    | otherwise = x
