// Problem 9. Point in Circle and outside Rectangle

// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
// 	Examples:

// x	 y	  inside K & outside of R
// 1	 4		yes
// 3	 2		yes
// 0	 1		no
// 4	 1		no
// 2	 0		no
// 4	 0		no
// 2.5	 1.5	yes
// 3.5	 1.5	yes
// -100	 -100	no

var x = 3;
var y = 2;
var isInCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
var isOutOfRec = (x < -1) || (x > 5) || (y > 1) || (y < -1);
console.log( (isInCircle && isOutOfRec) ? "Yes" : "No");