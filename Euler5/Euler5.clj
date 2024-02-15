(defn divbyall [x] (every? identity (map #(= 0 (mod x %)) (range 1 20))))

(first (filter divbyall (range 20 1000000000 20)))
