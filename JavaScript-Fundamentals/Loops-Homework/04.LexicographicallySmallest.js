// Problem 4. Lexicographically smallest

// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

var docArr = Object.getOwnPropertyNames(document),
	winArr = Object.getOwnPropertyNames(window),
	navArr = Object.getOwnPropertyNames(navigator),
	smallestDoc = largestDoc = docArr[0],
	smallestWin = largestWin = winArr[0],
	smallestNav = largestNav = navArr[0];

for (prop in document) {
	if (prop > largestDoc) {
		largestDoc = prop;
	};
	if (prop < smallestDoc) {
		smallestDoc = prop;
	};
}

console.log("Document: " + "\n" 
	+ "smallest property: " + smallestDoc + "; largest property: " + largestDoc + "\n");

for (prop in window) {
	if (prop > largestWin) {
		largestWin = prop;
	};
	if (prop < smallestWin) {
		smallestWin = prop;
	};
}

console.log("Window: " + "\n" 
	+ "smallest property: " + smallestWin + "; largest property: " + largestWin + "\n");

for (prop in navigator) {
	if (prop > largestNav) {
		largestNav = prop;
	};
	if (prop < smallestNav) {
		smallestNav = prop;
	};
}

console.log("Navigator: " + "\n" 
	+ "smallest property: " + smallestNav + "; largest property: " + largestNav + "\n");