main = do
    print (multiples 999)


multiples a = sum [x | x <- [1..a], mod x 3 == 0 || mod x 5 == 0]
