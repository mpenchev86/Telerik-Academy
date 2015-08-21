// Problem 4. Number of elements

// Write a function to count the number of div elements on the web page


function countDivs () {
	var count = document.getElementsByTagName("div").length;
	return count;
}

console.log("Number of div elements: " + countDivs());