var step = 0.001;
var i = 0;
var count = 0;
var WIDTH = 800;
var HEIGHT = 800;

function setup() {
  createCanvas(WIDTH, HEIGHT);
  stroke(255);
  strokeWeight(3);
  background(44);
}

function draw() {
  var amount = 0;
  var v0 = createVector(0,0);
  var v1 = createVector(WIDTH,0);
  var v2 = createVector(0,HEIGHT);
  if(i < 0 || i > 1) step *= -1;
  i += step;
  v3 = lerpVector(v0, v1,i);
  v4 = lerpVector(v2, v0, i);
  push();
  strokeWeight(1);
  stroke(cos(count/500 - 1)*255, sin(count/500 - 1)*255, tan(count/500 - 1)*255);
  if(count % 15 == 0) { line(v3.x, v3.y, v4.x, v4.y); }
  pop();
  point(lerpVector(v4, v3, i));
  count++;
}

function lerpVector(v1, v2, amt){
  return createVector(lerp(v1.x, v2.x, amt), lerp(v1.y, v2.y, amt));
}

