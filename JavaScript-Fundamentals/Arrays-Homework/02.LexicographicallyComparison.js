// Problem 2. Lexicographically comparison

// Write a script that compares two char arrays lexicographically (letter by letter).

var arr1 = ['w','f','4','\\',']'], 
	arr2 = ['w','f','4','\\',']','%'],
	len1,
	len2,
	i;

len1 = arr1.length;
len2 = arr2.length;
var len = len1 < len2 ? len1 : len2;

for (i = 0 ; i < len; i += 1) {
	if (arr1[i] != arr2[i]) {
		var result = arr1[i] > arr2[i] ? ">" : "<";
		console.log("Arrays differ on index #" + i + ". arr1 " + result + " arr2");
		return;
	};
}

var result = len1 < len2 ? "<" : ">" ;
console.log("Arrays have common elements for the length of the shorter array but differ by length. " + "arr1 " + result + " arr2");