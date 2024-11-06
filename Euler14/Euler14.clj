(defn col_even [x] (long (/ x 2)))
(defn col_odd [x] (long (+ 1 (* 3 x))))

(defn collatz [x] 
  (if (even? x)
    (#(/ % 2) x)
    (#(+ 1 (* % 3)) x)))

(defn loop_me_daddy [x]
  (loop [x x
         v []]
   (if (not= 1 x)
     (recur (collatz x) (conj v x))
     (count v))))

(println
  (loop [ci 1
         maxi 0
         maxc 0]
    (if (< ci 1e6)
      (if (> (loop_me_daddy ci) maxc)
        (recur (inc ci) ci (loop_me_daddy ci))
        (recur (inc ci) maxi maxc))
      maxi)))