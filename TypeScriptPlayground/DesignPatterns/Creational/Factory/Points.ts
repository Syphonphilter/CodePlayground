//* this is great but I am breaking the open closed principle but I Have a cleaner API

class Points {
  point_x;
  point_y;
  constructor(x: number, y: number) {
    this.point_x = x;
    this.point_y = y;
  }
  static get factory() {
    return new PointFactory();
  }
}
//* Using the factory approach
class PointFactory {
  newCatesianPoint(x, y) {
    return new Points(x, y);
  }
  newPolarPoints(rho, theta) {
    return new Points(rho * Math.cos(theta), rho * Math.sin(theta));
  }
}

let p = Points.factory.newCatesianPoint(122, 45);
let x = PointFactory;
console.log(p);
