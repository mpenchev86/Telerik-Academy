// Problem 1. Odd or Even

// Write an expression that checks if given integer is odd or even.
// 	Examples:

// n	Odd?
// 3	true
// 2	false
// -2	false
// -1	true
// 0	false

var intNum = 3247578;
console.log (intNum & 1 ? "Odd" : "Even");	//true --> Odd, false --> Even


// if (intNum & 1) {
//     console.log("The number is odd");
// } else {
//     console.log("The number is even");
// }