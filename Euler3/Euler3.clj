(def product 600851475143)

(def tops (Math/ceil (Math/sqrt product)))

(def try-these (reverse (range 2 tops)))

(defn divByProd? [x] (= 0 (mod product x)))

(defn prime? [x] 
  (not-any? 
    #(= 0 (mod x %))
    (range 2 (/ x 2))))

(defn prime_factor [x] 
      (and (divByProd? x) (prime? x)))

(println (first (filter prime_factor try-these)))
