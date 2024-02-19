(defn sum_of_squares [x]
  (reduce + (map #(* % %) (range (inc x)))))
(defn square_of_sum [x]
  (Math/pow (reduce + (range (inc x))) 2))

(println (#(- (square_of_sum %) (sum_of_squares %)) 100))
