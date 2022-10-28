main = do
    content <- readFile "data.txt"
    print . map readInt . lines $ content
    print(parse(lines content))

readInt :: [Char] -> Int
readInt = read

parse :: [[Char]] -> [Int]
parse [] = []
parse (x:xs) = (charToInt x) ++ (parse xs)

charToInt :: [Char] -> [Int]
charToInt [] = []
charToInt (x:xs) = (read [x]) : charToInt xs
