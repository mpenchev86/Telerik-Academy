// Problem 5. Youngest person

// Write a function that finds the youngest person in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.

// Example:

// var people = [
//   { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
//   { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];


var people = [
	{ firstname : 'Gosho', lastname: 'Petrov', age: 32 },
	{ firstname : 'Bay', lastname: 'Ivan', age: 81},
	{ firstname : '100', lastname: 'Kila', age: 53},
	{ firstname : 'Pesho', lastname: 'Slepiya', age: 40},
	{ firstname : 'Bahari', lastname: 'Zaharov', age: 38},
	{ firstname : 'John', lastname: 'Snow', age: 26},
	{ firstname : 'Ultron', lastname: 'The Cute', age: Math.pow(0.1, -1.2)} ];

function findYoungest (people) {
	var tempYoungest = people[0];

	for (i = 0, len = people.length; i < len; i += 1) {
		if (people[i].age < tempYoungest.age) {
			tempYoungest = people[i];
		};
	};

	return tempYoungest;
}

console.log("Youngest person is: " + findYoungest(people).firstname + " " + findYoungest(people).lastname);