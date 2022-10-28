--calculates the new orbital period of a satellite
--takes the current orbital time and the angle you want to move forward or backward in the next cycle
--example: your current period is 1h17m3s and you want to get 10 degree closer to the next satellite in this orbit
--neworbitalperiod 1 17 3 10 => 1h 19m 11s
--the next cycle has to be 1h19m11s long to get 10 degree closer
--don't forget the brackets in case you want to travel back (negative angel) 
neworbitalperiod hour min sec angel =  timeToString(secToHour(div((hourToSec hour min sec) * 360) (360 + angel)))

--calculates hour min sec into second
hourToSec hour min sec = hour*3600 + min*60 + sec

--calculates Seconds into min and hour
secToHour sec = (div sec 3600, mod (div sec 60) 60, mod sec 60)

--converts Int tripel to readable String
timeToString (a,b,c) = (show a) ++ "h " ++ (stt b) ++ "m " ++ (stt c) ++ "s"

--check if a num is < 10 and add leading 0
stt x | x < 10 = "0" ++ (show x)
      | otherwise = (show x)
