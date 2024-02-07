;; find the sum of all multiples of 3 or 5 from 0 to 10000
(defn applies [x]
  (or (= 0 (mod x 3))
      (= 0 (mod x 5))
      ))

(pr (reduce + (filter applies (take 999 (map #(+ 1 %) (range))))))

