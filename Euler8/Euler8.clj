(def input (vec 
            (map #(- (int %) 48)
                 (.replace (slurp "data.txt") "\r\n" ""))))

(defn maxpoint [x]
  (loop [numbers x
         global 0]
    (let [local (reduce * (take 13 numbers))]
    (if (empty? numbers)
      global
      (if (> local global)
        (recur (rest numbers) local)
        (recur (rest numbers) global))))))

(println (maxpoint input))