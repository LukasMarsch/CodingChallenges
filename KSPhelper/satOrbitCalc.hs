--calculates the new orbital period of a satellite
--takes the current orbital time and the angle you want to move forward or backward in the next cycle
--example: your current period is 1h17m3s and you want to get 10 degree closer to the next satellite in this orbit
--neworbitalperiod 1 17 3 10 => 1h 19m 11s
--the next cycle has to be 1h19m11s long to get 10 degree closer
--don't forget the brackets in case you want to travel back (negative angel) 
neworbitalperiod hour min sec angel =  timeToString(secToHour(div((hourToSec hour min sec) * (360 + angel)) 360))

hourToSec hour min sec = hour*3600 + min*60 + sec

secToHour sec = (div sec 3600, mod (div sec 60) 60, mod sec 60)

timeToString (a,b,c) = (show a) ++ "h " ++ (if (b<11) then "0" else "") ++ (show b) ++ "m " ++ (if (c<10) then "0" else "") ++ (show c) ++ "s"
