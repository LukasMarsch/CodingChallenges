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

<<<<<<< Updated upstream
(println (count (vector (loop_me_daddy 200))))
=======
(time
  (loop [ci 1
         maxi 0
         maxc 0]
    (if (< ci 1e6)
      (if (> (loop_me_daddy ci) maxc)
        (recur (inc ci) ci (loop_me_daddy ci))
        (recur (inc ci) maxi maxc))
      maxi)))
>>>>>>> Stashed changes
