module Main (main) where

distanceWithFormula :: Int -> Int
distanceWithFormula k =
    k * (2 * (l + n + m) + m * (k - 1))
    where
        l = 7
        n = 5
        m = 10

distanceWithLoop :: Int -> Int
distanceWithLoop 0 = 0
distanceWithLoop k =
    2 * (l + n + m) + 2 * m * (k - 1) + distanceWithLoop(k - 1)
    where
        l = 7
        n = 5
        m = 10

main :: IO ()
main = do
    putStrLn . show . distanceWithFormula $ 1   -- 44
    putStrLn . show . distanceWithFormula $ 2   -- 108
    putStrLn . show . distanceWithFormula $ 3   -- 192
    putStrLn . show . distanceWithFormula $ 20  -- 4680
    putStrLn . show . distanceWithLoop $ 1      -- 44
    putStrLn . show . distanceWithLoop $ 2      -- 108
    putStrLn . show . distanceWithLoop $ 3      -- 192
    putStrLn . show . distanceWithLoop $ 20     -- 4680