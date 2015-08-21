/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(start, end) {
	var primes = [],
		temp,
		notPrime = false,
		i,
		j;

    if (arguments.length !== 2) {
		throw new Error();
	}


  	if (parseInt(start) === NaN || parseInt(end) === NaN) {
		throw new Error();
	}

	start = +start;
	end = +end;

	for (i = start; i <= end; i += 1) {
		if (i < 2) {
			continue;
		};
		temp = Math.sqrt(i);
		for (j = 2; j <= temp; j += 1) {
			
			if (i % j === 0) {
				notPrime = true;
				break;
			};
		};
		if (notPrime) {
			notPrime = false;
			continue;
		}
		primes.push(i);
	};

  	return primes;
};

console.log(findPrimes(0, 5));
module.exports = findPrimes;