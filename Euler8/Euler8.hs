main = do
    content <- readFile "data.txt"
    print content
   -- print . map readInt . lines $ content
   -- print(parse(lines content))
   -- largestAdj (parse(lines content))
   -- print(parse(lines content))

readInt :: [Char] -> Int
readInt = read

parse :: [[Char]] -> [Int]
parse [] = []
parse (x:xs) = (charToInt x) ++ (parse xs)

charToInt :: [Char] -> [Int]
charToInt [] = []
charToInt (x:xs) = (read [x]) : charToInt xs

largestAdj :: [Int] -> Int
largestAdj (x:xs)
    | x* head xs > maxTail = x * head xs
    | otherwise = maxTail
    where maxTail = largestAdj xs