(defn even [x] (= 0 (mod x 2)))
(defn odd  [x] (= 1 (mod x 2)))

(defn col_even [x] (long (/ x 2)))
(defn col_odd [x] (long (+ 1 (* 3 x))))

(defn collatz [x] 
  (if (even x)
    (#(/ % 2) x)
    (#(+ 1 (* % 3)) x)))

(defn loop_me_daddy [x]
  (loop [v ()]
   (when (not (= 1 x))
     (conj v x)
     (recur (collatz x)))))

(println (count (vector (loop_me_daddy 200))))
