-- find the Prime factors of 600851475143

import Data.List

primeFactorsOf :: Int -> [Int]
primeFactorsOf n = (nub . unfoldr (2 `factorOutOf`)) n
  where k `factorOutOf` n
		| n < 2          = Nothing
		| n `mod` k == 0 = Just (k, n `div` k)
		| otherwise      = (k+1) `factorOutOf` n

main :: IO()
main = print $ maximum $ primeFactorsOf 600851475143
