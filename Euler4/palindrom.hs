main = do
    print (show(palindrom 999))

palindrom a = maximum [x*y| x<-[1..a], y<-[x..a], show(x*y) == reverse(show(x*y))]
