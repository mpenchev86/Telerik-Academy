// Problem 1. Planar coordinates

// Write functions for working with shapes in standard Planar coordinate system.
// 	-Points are represented by coordinates P(X, Y)
// 	-Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
// Calculate the distance between two points.
// Check if three segment lines can form a triangle.


// array of points for tests
var points = [
		{X : -2, Y : 1}, 
		{X : -1, Y : -2}, 
		{X : 3, Y : 1.5}, 
		{X : 2, Y : -2}, 
		{X : 1, Y : 2.5} 
	],
// array of lines for tests
	lines = [
		{ P1 : {X : -2, Y : 1}, P2 : {X : 3, Y : 1.5}}, 
		{ P1 : {X : -1, Y : -2}, P2 : {X : 0, Y : -2}}, 
		{ P1 : {X : -1, Y : -2}, P2 : {X : -2, Y : 1}}, 
		{ P1 : {X : 1, Y : 2.5}, P2 : {X : -1, Y : -2}}, 
		{ P1 : {X : 1, Y : 2.5}, P2 : {X : 2, Y : -2}}
	],
	distancePoints,
	resultTriangle;


function calcPointsDistance (p1, p2) {
	return Math.sqrt((p1.X - p2.X)*(p1.X - p2.X) + (p1.Y - p2.Y)*(p1.Y - p2.Y));   
}

distancePoints = calcPointsDistance(points[2], points[4]);
console.log("The distance between the two points is " + distancePoints + "\n");

function checkForTriangle (L1, L2, L3) {
	var lenghtL1 = Math.sqrt( (L1.P1.X - L1.P2.X)*(L1.P1.X - L1.P2.X) + (L1.P1.Y - L1.P2.Y)*(L1.P1.Y - L1.P2.Y) ),
		lenghtL2 = Math.sqrt( (L2.P1.X - L2.P2.X)*(L2.P1.X - L2.P2.X) + (L2.P1.Y - L2.P2.Y)*(L2.P1.Y - L2.P2.Y) ),
		lenghtL3 = Math.sqrt( (L3.P1.X - L3.P2.X)*(L3.P1.X - L3.P2.X) + (L3.P1.Y - L3.P2.Y)*(L3.P1.Y - L3.P2.Y) ),
		canFormTriangle;
	
	if ((lenghtL1 < (lenghtL2 + lenghtL3)) &&
		(lenghtL2 < (lenghtL1 + lenghtL3)) &&
		(lenghtL3 < (lenghtL2 + lenghtL1))) {
		canFormTriangle = true;
	} else {
		canFormTriangle = false;
	}

	return canFormTriangle;
}

resultTriangle = checkForTriangle(lines[0], lines[1], lines[2]) ? "can" : "can not";
console.log("The three line segments " + resultTriangle + " form a triangle." + "\n");