var step = 0.1;
var i = 0;
function setup() {
  createCanvas(400, 400);
  stroke(255);
  
  background(44);
}

function draw() {
  var amount = 0;
  var v0 = createVector(0,0);
  var v1 = createVector(400,0);
  var v2 = createVector(0,400);
  if(i < 0 || i > 1) step *= -1;
  i += step;
  v3 = lerpVector(v0, v1,i);
  v4 = lerpVector(v2, v0, i);
  line(v3.x, v3.y, v4.x, v4.y);
}

function lerpVector(v1, v2, amt){
  return createVector(lerp(v1.x, v2.x, amt), lerp(v1.y, v2.y, amt));
}
