(defn fib [x]
 (if (< 2 x) (+ (fib (- x 1)) (fib (- x 2)))
  (if (< 0 x) 1
   0))) 

(defn nums [] (lazy-seq (map #(+ % 1) (range))))

(defn fib-below-4e6 [] (take-while
  #(> 4e6 %)
  (map fib (nums))))

(print (reduce + (filter even? (fib-below-4e6))))
