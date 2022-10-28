let x;
let y;
let vx;
let vy;

let height;
let width;

function windowResized() {
  resizeCanvas(windowWidth, windowHeight);
}


function setup() {
  height = 400;
  width = 400;
  createCanvas(height, width);
  stroke('purple');
  strokeWeight(5);
  
  x = width / 2;
  y = height / 2;
  vx = -2;
  vy = -5;
}

function draw() {
  background(200);
  
  if(crossedYBorder()){
    reverseY();
  }
  if(crossedXBorder()){
    reverseX();
  }
  
  x += vx;
  y += vy;

  point(x,y);
}

function reverseX(){
 vx = -vx;
}
function reverseY(){
  vy = -vy;
}

function crossedYBorder(){
  return y <= 0 || y >= height;
}

function crossedXBorder(){
  return x <= 0 || x >= width;
}

function reverseY(){
  vy = -vy;
}