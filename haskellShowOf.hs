main = do
    print (qst x)

qst [] = []
qst (x:xs) = lower ++ [x] ++ higher
    where lower = qst [a | a <- xs, a <= x]
          higher = qst [a | a <- xs, a > x]

x = [5,3,7,8,9,4,2,6,4,7,6,5,2,3,4,1,7,9]
