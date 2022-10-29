function timeToSecond(hour, min, sec) {
  return hour*3600 + min * 60 + sec
}

function secondToTime(sec) {
  let hour = Math.floor(sec / 3600)
  sec = sec % 3600
  let min = Math.floor(sec / 60)
  if(min < 10) {
    min = '0' + min
  }
  sec = sec % 60
  if(sec < 10) {
    sec = '0' + sec
  }
  return (`${hour}h ${min}m ${sec}s`) 
}

function newOrbitalPeriod(oldPeriod, angle) {
  return Math.floor(oldPeriod * 360 / (360 + angle))
}

function calcNewPeriod() {
  let textHour = document.getElementById("inputHour").value;
  let textMin = document.getElementById("inputMin").value;
  let textSec = document.getElementById("inputSec").value;
  let textAngle = document.getElementById("inputAngle").value;
  let result = secondToTime(newOrbitalPeriod(timeToSecond(parseInt(textHour), parseInt(textMin), parseInt(textSec)), parseFloat(textAngle)))
  document.getElementById("result").innerHTML = result
}