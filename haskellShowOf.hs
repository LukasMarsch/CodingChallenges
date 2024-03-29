main = do
    print (qst x)
    print (qst x)

x = [5,3,7,8,9,4,2,6,4,7,6,5,2,3,4,1,7,9]

qst [] = []
qst (x:xs) = lower ++ [x] ++ higher
    where lower = qst [a | a <- xs, a <= x]
          higher = qst [a | a <- xs, a > x]

msort x   = mmerge ((msort a), (msort b))
    where (a, b) = msplit x

mmerge (x, []) = x
mmerge ([], y) = y
mmerge ((x:xs), (y:ys))
    | x < y     = x : (mmerge (xs, (y:ys)))
    | otherwise = y : (mmerge ((x:xs), ys))

msplit x   = (take n x, drop n x)
    where n = div (length x) 2


fibs = 0 : 1 : zipWith (+) fibs (tail fibs)
