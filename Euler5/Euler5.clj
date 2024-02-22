(defn divbyall [x] (every? identity (#(= 0 (mod x %)) (range 1 20))))

(println (first (filter divbyall (range 20 1e9 20))))
