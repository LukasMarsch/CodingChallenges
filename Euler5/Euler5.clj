(defn divbyall [x] (every? identity (map #(= 0 (mod x %)) (range 1 20))))

(println (first (filter divbyall (range 20 1000000000 20))))
