var WIDTH = 1000;
var HEIGHT = 1000;
var centerX = WIDTH/2;
var centerY = HEIGHT/2;
var totalSize = 1000;
var stars = [];

function setup() {
  createCanvas(WIDTH, HEIGHT);
  stroke(0xff5555);
  strokeWeight(2);
}

function draw() {
  background(10);
  let slen = stars.length;
  //if(slen > totalSize) stars = []; slen = 0;
  for(let i = 0; i < random(10); i++){
    stars[slen+i] = new Star();
  }
  for(let i = 0; i < stars.length; i++){
    stars[i].update();
  }
}

class Star {
  
  constructor(){
    let l = random(100);
    let v = random(20);
    let phi = random(2* PI);
    this.v = createVector(sin(phi) * v, cos(phi) * v);
    this.pos = createVector(centerX+this.v.x, centerY + this.v.y);
    return this;
  }
  
  update(){
    line(this.pos.x, this.pos.y, this.pos.x + this.v.x, this.pos.y + this.v.y);
    this.pos.x += this.v.x;
    this.pos.y += this.v.y;
  }
}
