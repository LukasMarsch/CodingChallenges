{-main = do
    content <- readFile "data.txt"
    print content
   -- print . map readInt . lines $ content
   -- print(parse(lines content))
   -- largestAdj (parse(lines content))
   -- print(parse(lines content))-}

readInt :: [Char] -> Int
readInt = read

parse :: [[Char]] -> [Int]
parse [] = []
parse (x:xs) = (charToInt x) ++ (parse xs)

charToInt :: [Char] -> [Int]
charToInt [] = []
charToInt (x:xs) = (read [x]) : charToInt xs

largestAdj :: [Int] -> Int
largestAdj [] = 0
largestAdj [x] = x
largestAdj (x:xs)
    | product (x : (take 12 xs)) > maxTail = product (x : (take 12 xs))
    | otherwise = maxTail
    where maxTail = largestAdj xs

product' :: [Int] -> Int
product' [] = 1
product' [x] = x
product' (x:xs) = x * (product' xs)