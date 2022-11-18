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
  var v1 = createVector(400,200);
  var v2 = createVector(100, 100);
  if(i < 0 || i > 1) step *= -1;
  i += step;
  v3 = p5.Vector.lerp(v1,v2,i);
  line(0,400, v3.x, v3.y);
}