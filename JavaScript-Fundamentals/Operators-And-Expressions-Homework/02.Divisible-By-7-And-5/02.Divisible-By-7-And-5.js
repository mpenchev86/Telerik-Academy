// Problem 2. Divisible by 7 and 5

// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
// 	Examples:

// n	Divided by 7 and 5?
// 3	false
// 0	true
// 5	false
// 7	false
// 35	true
// 140	true

var intNum = 75283565;
console.log( ((intNum % 7) || (intNum % 5)) ? "Number is not divisible by 7 and 5." : "Number is divisible by 7 and 5." );


// if ((intNum % 7) || (intNum % 5)){
// 	console.log("Number is not divisible by 7 and 5.");
// } else {
// 	console.log("Number is divisible by 7 and 5.");
// }