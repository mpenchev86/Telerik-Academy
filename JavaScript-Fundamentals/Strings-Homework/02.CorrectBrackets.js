// Problem 2. Correct brackets

// Write a JavaScript function to check if in a given expression the brackets are put correctly.

// 	Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

var exp = "((a+b)/5-d+((c-3)*4+2)/d)",
	result;

function checkBrackets (exp) {
	var openBracks = 0,
		closeBracks = 0,
		i,
		len,
		result = {};
	for (i = 0, len = exp.length; i < len; i += 1) {

		if (exp[i] === '(') {
			openBracks += 1;
		} else if (exp[i] === ')') {
			closeBracks += 1;
		}

		if (openBracks < closeBracks) {
			result.areCorrect = false;
		};
	}
	
	if (openBracks !== closeBracks) {
		result.areCorrect = false;
	} else {
		result.areCorrect = true;
	}

	result.openBracks = openBracks;
	result.closeBracks = closeBracks;
	return result;
}

result = checkBrackets(exp);
console.log("The brackets in the expression are put correctly: " + result.areCorrect);
console.log("'(' occurances: " + result.openBracks);
console.log("')' occurances: " + result.closeBracks);