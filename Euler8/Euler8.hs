main = do
    content <- readFile "data.txt"
    print . map readInt . lines $ content

readInt :: [Char] -> Int
readInt = read