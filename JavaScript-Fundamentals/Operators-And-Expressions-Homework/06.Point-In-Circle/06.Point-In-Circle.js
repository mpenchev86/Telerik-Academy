﻿// Problem 6. Point in Circle

// Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
// 	Examples:

// x	  y		  inside
// 0	  1		  true
// -5	  0		  true
// -4	  5		  false
// 1.5	  -3	  true
// -4	  -3.5	  false
// 100	  -30	  false
// 0	  0		  true
// 0.2	  -0.8	  true
// 0.9	  -4.93	  false
// 2	  2.655	  true

var x = -4;
var y = 2.9;
console.log( ((x * x) + (y * y)) <= 25 ? true : false);