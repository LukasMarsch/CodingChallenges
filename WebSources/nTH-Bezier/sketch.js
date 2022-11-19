var WIDTH = 800;
var HEIGHT = 800;
var newPoints = [];

class myBezier{
  constructor(points = [createVector(0,0), createVector(WIDTH, HEIGHT)], step = 0.001){
    this.points = points;
    this.t = 0.0;
    this.step = step;
  }  

  resetT(){
    this.t = 0.0;
  };
  
  myupdate(){
    this.t+= this.step;
    if (this.t >= 1 || this.t <= 0) { this.step *= -1; }
    this.myLine(this.points);
  }
  
  myLine(array = []){
    if(array == []){return;}
    var bezierArray = [];
    for(let i = 0; i<array.length-1; i++){
      var f = this.mylerp(array[i], array[i+1]);
      append(bezierArray, f); 
      if(array.length == 2){point(f.x, f.y);}
    }
    
    if(array.length > 2) { this.myLine(bezierArray); }
    return;
  }
  
  mylerp(vector1 = createVector(0,0), vector2 = createVector(WIDTH, HEIGHT)){
    return createVector(lerp(vector1.x, vector2.x, this.t),
                        lerp(vector1.y, vector2.y, this.t));
  }
}

function setup() {
  createCanvas(WIDTH, HEIGHT);
  stroke(200);
  strokeWeight(2);
  
  a = new myBezier([createVector(0,HEIGHT), createVector(0,0), createVector(WIDTH, 0), createVector(WIDTH, HEIGHT)], 0.001);
  
  //// EDIT THIS OBJECT TO ADD OR REMOVE POINTS
  b = new myBezier(/*[createVector(0,0), createVector(WIDTH, HEIGHT), createVector(WIDTH, 0),
                   createVector(100, 200), createVector(440, 600)], 0.0005*/);
  
  
  
  background(90);
}

function draw() {
  a.myupdate();
  for(let i = 0; i<newPoints.length; i++){
    point(newPoints[i].x, newPoints[i].y);
  }
}

function removeA(){
  a = new myBezier(createVector(0,0));
}

function addToA(){
  a = new myBezier(newPoints);
  newPoints = [];
}

function clearCanvas(){
  background(90);
}

function mouseClicked(){
  if(mouseX > WIDTH || mouseY > HEIGHT || mouseX < 0 || mouseY < 0){ return; }
  append(newPoints,createVector(mouseX, mouseY));
  print(createVector(mouseX, mouseY));
}

function resetT(){
  a.resetT();
  background(90);
}