// Problem 1. Make person

// Write a function for creating persons.
// Each person must have firstname, lastname, age and gender (true is female, false is male)
// Generate an array with ten person with different names, ages and genders


console.log("Problem 1. Make person".toUpperCase() + "\n");

function Person (fname, lname, age, gender) {
	this.firstname = fname,
	this.lastname = lname,
	this.age = age,
	this.gender = gender;
}

if (!Array.prototype.fill) {
	Array.prototype.fill = function (value) {
		var i, 
			len;
		for (i = 0, len = this.length; i < len; i += 1) {
			this[i] = value;
		};
	}
};

var arrPeople = new Array(10);
arrPeople.fill(1);

arrPeople = arrPeople.map(function (person) {
	var alphaBet = 'abcdefghijklmnopqrstuvwxyz',
		fname = alphaBet.split('')
			.sort(function (x, y) { return Math.random() - 0.5})
			.slice(0, 5 + Math.random()*4)
			.map(function (elem, index) {
				if (index === 0) { return elem.charAt(0).toUpperCase();}
				return elem;
			})
			.join(''),
		lname = alphaBet.split('')
			.sort(function (x, y) { return Math.random() - 0.5})
			.slice(0, 5 + Math.random()*4)
			.map(function (elem, index) {
				if (index === 0) { return elem.charAt(0).toUpperCase();} 
				return elem;
			})
			.join(''), 
		age = 10 + (Math.random()*30 | 0), 
		gender = Boolean( (Math.random() + 0.5) | 0 );
	person = new Person(fname, lname, age, gender);
	return person;
})

arrPeople.forEach(function (person) {
	console.log(person);	
});
console.log("_______________________________________________________");



// Problem 2. People of age

// Write a function that checks if an array of person contains only people of age (with age 18 or greater)
// Use only array methods and no regular loops (for, while)


console.log("Problem 2. People of age".toUpperCase() + "\n");

function checkAge(arr) {
	var areAllOfAge;

	areAllOfAge = arr.every(function(person){
		return person.age >= 18;
	});

	console.log("All people are of age: " + areAllOfAge);
}

checkAge(arrPeople);
console.log("_______________________________________________________");



// Problem 3. Underage people

// Write a function that prints all underaged persons of an array of person
// Use Array#filter and Array#forEach
// Use only array methods and no regular loops (for, while)


console.log("Problem 3. Underage people".toUpperCase() + "\n");

function isUnderage (person) {
	return person.age < 19;
}

function allUnderage (arr) {
	var underAgeArr = arr.filter(isUnderage);

	underAgeArr.forEach(function (person) {
		console.log(person);
	});
}

allUnderage(arrPeople);
console.log("_______________________________________________________");



// Problem 4. Average age of females

// Write a function that calculates the average age of all females, extracted from an array of persons
// Use Array#filter
// Use only array methods and no regular loops (for, while)


console.log("Problem 4. Average age of females".toUpperCase() + "\n");

function isFemale (person) {
	return person.gender === true;
}

function averageFemaleAge (arr) {
	var allFemales = arr.filter(isFemale),
		ageAggregate = 0,
		count = 0;
	
	allFemales.forEach(function (person) {
		ageAggregate += person.age;
		count += 1;
	});

	return ageAggregate / count;
}

console.log("Average age of of all females: " + averageFemaleAge(arrPeople));
console.log("_______________________________________________________");



// Problem 5. Youngest person

// Write a function that finds the youngest male person in a given array of people and prints his full name
// Use only array methods and no regular loops (for, while)
// Use Array#find


console.log("Problem 5. Youngest person".toUpperCase() + "\n");

if (!Array.prototype.find) {
	Array.prototype.find = function (callback) {
		var i, 
			len;
		for (i = 0, len = this.length; i < len; i += 1) {
			if (callback (this[i], i, this)) {
				return this[i];
			};
		};
		return undefined;
	}
};

function findYoungest (arr) {
		var youngestMale = arr.sort(function (x, y) { return x.age - y.age;})
			.find(function (person) {
				return (!person.gender);
			});

	console.log("Youngest male's full name: " 
		+ youngestMale.firstname + " " + youngestMale.lastname);
}

findYoungest(arrPeople);
console.log("_______________________________________________________");



// Problem 6. Group people

// Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
// Use Array#reduce
// Use only array methods and no regular loops (for, while)


console.log("Problem 6. Group people".toUpperCase() + "\n");

function groupByLetterOrName (arr, groupBy) {
	var groupedPeople = arr.reduce(function (group, person) {
		var keyName = (groupBy === "letter") ? person.firstname[0] : person.firstname;
		
		if (!group.hasOwnProperty(keyName)) {
			group[keyName] = [];
		};
		group[keyName].push(person);

		return group;
	}, {});
	return groupedPeople;
}

console.log("	People grouped by first letter:");
console.log();
console.log(groupByLetterOrName(arrPeople, "letter"));
console.log();
console.log("	People grouped by first name:");
console.log();
console.log(groupByLetterOrName(arrPeople, "name"));
console.log("_______________________________________________________");