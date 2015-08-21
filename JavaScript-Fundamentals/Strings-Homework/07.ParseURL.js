// Problem 7. Parse URL

// Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
// Return the elements in a JSON object.

// Example:

// URL																	result
// 																	{ protocol: http, 
// http://telerikacademy.com/Courses/Courses/Details/239		server: telerikacademy.com 
// 															resource: /Courses/Courses/Details/239


var inputURL = 'http://telerikacademy.com/Courses/Courses/Details/239';

function parseURL (inputURL) {
	var parsed = {},
		regProtocol = new RegExp('^[a-z]+', 'g'),
		regServer = new RegExp('\/{2}[^\/]+', 'g'),
		regResource = new RegExp('[a-z][\/].+', 'g');

	parsed['protocol'] = inputURL.match(regProtocol).toString();
	parsed['server'] = inputURL.match(regServer).toString().substr(2);
	parsed['resource'] = inputURL.match(regResource).toString().substr(1);;

	return parsed;
}

console.log(parseURL(inputURL));