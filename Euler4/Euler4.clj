(defn ntov
  ([x]
   (if (<= 10 x)
     (flatten (ntov (int (Math/floor (/ x 10))) (list (mod x 10))))
     (list x)))
  ([xs x]
   (if (<= 10 xs)
     (ntov (int (Math/floor (/ xs 10))) (conj (list x) (mod xs 10)))
     (conj x (list xs)))))

(defn palindrome? [x] 
  (=
   (ntov (* (first x) (last x)))
   (reverse (ntov (* (first x) (last x))))))

(def pairs (for [n (range 1 1000) m (range 1 1000)] (list n m)))

(println (reduce max (map #(* (first %) (last %)) (filter palindrome? (reverse pairs)))))
