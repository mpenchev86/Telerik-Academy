// Problem 6.

// Write a function that groups an array of people by age, first or last name.
// The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
// Use function overloading (i.e. just one function)

// Example:

// 	var people = {…};
// 	var groupedByFname = group(people, 'firstname');
// 	var groupedByAge= group(people, 'age');

var people = [
	{ firstname : 'Gosho', lastname: 'Petrov', age: 20},
	{ firstname : 'Bay', lastname: 'Ivan', age: 23},
	{ firstname : 'Bay', lastname: 'Petrov', age: 23},
	{ firstname : 'Ivan', lastname: 'Goshov', age: 38},
	{ firstname : 'Bahari', lastname: 'Petrov', age: 38},
	{ firstname : 'Bahari', lastname: 'Goshov', age: 26},
	{ firstname : 'Ivan', lastname: 'Grozny', age: 192} ];

function groupPeople (people, groupby) {
	var assArr = {};	//No pun unintended;)
	
		for (var prop in people) {
			var keyName = people[prop][groupby];

			if (!assArr.hasOwnProperty(keyName)) {
				assArr[keyName] = [];				
			};

			assArr[keyName].push(people[prop]);
		}

	return assArr;
};

var groupedByFname = groupPeople(people, 'firstname');
var groupedByLname = groupPeople(people, 'lastname');
var groupedByAge = groupPeople(people, 'age');

console.log("Grouped by firstname:".toUpperCase());
console.log(groupedByFname);
console.log();
console.log("Grouped by lastname:".toUpperCase());
console.log(groupedByLname);
console.log();
console.log("Grouped by age:".toUpperCase());
console.log(groupedByAge);