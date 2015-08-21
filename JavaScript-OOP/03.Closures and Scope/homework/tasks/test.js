// var Shape = (function() {
// 	function Shape (x, y) {
// 		this.xx = x;
// 		this.yy = y;
// 	}

// 	Object.defineProperty(Shape, 'x', {
// 		get: function () {
// 			return this.xx;
// 		},
// 		set: function (value) {
// 			this.xx = value;
// 		}
// 	});

// 	Object.defineProperty(Shape, 'y', {
// 		get: function () {
// 			return this.yy;
// 		},
// 		set: function (value) {
// 			if (typeof value !== 'number') {
// 				throw new Error("Blah");
// 			};
// 			this.yy = value;
// 		}
// 	})

// 	Shape.sickshit = "sickshit";

// 	return Shape;
// }());

// var Rect = (function () {
// 	function Rect (x, y, width, height) {
// 		Shape.call(this, x, y);
// 		this.wwidth = width;
// 		this.hheight = height;
// 	}

// 	Object.defineProperty(Rect, 'sickshit', {
// 		value: Shape.sickshit
// 	});

// 	// Rect.prototype = Object.create(Shape.prototype);
// 	// Rect.prototype.constructor = Rect;

// 	return Rect;
// }());

// var s = new Shape(5, 4);
// var r = new Rect(3, 4, 5, 6);

// console.log(s);
// console.log(r);
// console.log();
// console.log(Shape.hasOwnProperty('sickshit'));
// console.log(Rect.hasOwnProperty('sickshit'));
// console.log(Rect.sickshit);
// console.log(Shape.sickshit);





// var Animal = (function () {
// 	function Animal(name, age) {
// 		this.name = name;
// 		this.age = age;
// 		console.log();
// 		console.log(this);
// 		console.log();
// 	}

// 	Animal.prototype.mqu = function () {
// 		console.log('mqu');
// 	}

// 	return Animal;
// }());

// var p = new Animal("pesho", 34);
// // p.prototype = Animal;
// // p.prototype.protoProp = "protoProp";
// p.objProp = "objProp";

// console.log(p);
// console.log(Animal);
// console.log(p.__proto__);
// console.log(Animal.prototype);
// // console.log(p.hasOwnProperty('objProp'));






// var dog = Object.defineProperties(animal, {
//     type: {
//       value: 'dog'
//     },
//     noise: {
//       value: 'djaf'
//     },
//     bark: {
//       value: function (){
//         console.log('Bark, Bark');
//       }
//     }
//   });
  // return dog;






// console.log();
// var animal = {name: "pesho", age: 12};
// var dog = Object.create(animal);
// console.log(dog.__proto__);
// console.log(animal.prototype);
// console.log(dog.prototype);
// console.log(dog);






// var Person = (function () {
// 	function Person(pOne, pTwo) {
// 		this.pOne = pOne;
// 		this.pTwo = pTwo;
// 	}

// 	// Object.defineProperty(Person.prototype, 'blah', {
// 	// 	get: function () {
// 	// 		return this._pName;
// 	// 	},
// 	// 	set: function (val) {
// 	// 		this._pName = value;
// 	// 	}
// 	// });

// 	// Person.ownProp = "Person's Prop.";

// 	Person.prototype = {oneProp: 'I have one property'};

// 	return Person;
// }());

// var p = Object.create(Person.prototype);
// // p.oneProp = "Bye bye";
// // // p.ownProp = "p's prop";

// console.log(p);
// console.log(p.hasOwnProperty('oneProp'));
// console.log(p.oneProp);
// console.log();

// p.oneProp = "shit!";
// // console.log(p.prototype);
// console.log(Person.prototype);
// // console.log();

// console.log(p.prototype);
// console.log(p.prototype.oneProp);
// console.log(p.oneProp);
// console.log(p.ownProp);
// console.log(p.hasOwnProperty('pTwo'));

// console.log();

// console.log(Person.prototype);
// console.log(Person.prototype.oneProp);
// console.log(Person.oneProp);
// console.log(Person.ownProp);
// console.log(Person.hasOwnProperty('pTwo'));

// console.log();






// var p = {pone: "gary", ptwo: "pensiq"};
// var c = p;
// console.log(c);
// c.pone = "vesko";
// console.log(c);
// console.log(p);






// var vehicle = (function () {
// 	var vehicle = function (doors, year) {
// 		this.doors = doors;
// 		this.year = year;
// 	}
// 	return vehicle;
// }());

// var car = (function () {
// 	var car = function (doors, year, model) {
// 		vehicle.call(this, doors, year);
// 		this.model = model;
// 	}

// 	car.sayBeep = function () {
// 		console.log('Beep!');
// 	}

// 	// car.prototype = Object.create(vehicle.prototype);
// 	// car.prototype.constructor = car;
// 	return car;
// }());

// var c = Object.create(car);
// var p = new car(4, 2009, "Zaz");
// c.prototype.mlabel = 'label';

// c.sayBeep();
// car.sayBeep();
// console.log();

// console.log(c);
// console.log(car);
// console.log();

// console.log(c.prototype);
// console.log(car.prototype);
// console.log(vehicle.prototype);
// console.log();






// var mod = {};

// (function (scope) {
// 	scope.x = "peshkata";
// }(mod));

// (function (scope) {
// 	scope.y = "drusa";
// }(mod));

// console.log(mod);






// var obj = {name: 'peshkata', age: 12}
// Object.defineProperty(obj, 'walk', {
// 	value: function (age) {
// 		console.log('Az sym na ' + age + ' godini');
// 	},
// 	enumerable: true
// });

// console.log(Object.keys(obj));






// var Parent = (function () {
// 	function Parent (nname, age) {
// 		this.nname = nname;
// 		this.age = age;
// 	}

// 	Parent.walk = function () {
// 		console.log("It's just the way I walk");
// 	}

// 	Parent.prototype.dance = function () {
// 		console.log('See, I can even dance!');
// 	}
// 	return Parent;
// }());

// var par = new Parent('pepe', 23);
// par.dance = function () {
// 	console.log('typnq');
// };
// par.dance();
// Parent.prototype.dance();

// var Child = (function () {
// 	function Child (nname, age, tan) {
// 		Parent.call(this, nname, age);
// 		this.tan = tan;	
// 	}
// 	Child.prototype = Object.create(Parent.prototype);
// 	// Child.prototype.constructor = Child;

// 	return Child;
// });

// var chi = new Child('go6o', 11, 'kafev');
// console.log(chi.hasOwnProperty('nname'));
// console.log(Child.prototype.hasOwnProperty('constructor'));
// console.log(Parent.hasOwnProperty('prototype'));
// console.log(chi.prototype);
// console.log(chi.tan);

// var par = Object.defineProperties(Parent, {
// 	'nname': {
// 		value : 'pepi',
// 		enumerable: true
// 	},
// 	'age': {
// 		value: 45,
// 		enumerable: true
// 	},
// 	'dance': {
// 		value: function () {
// 			console.log(par.nname + ' walks!');
// 		},
// 		enumerable: true
// 	}
// });
// console.log(par);
// console.log(Parent);

// var par = Object.create(Parent);
// par.walk = function () {
// 	console.log('pepi enters');
// };
// par.walk();
// Parent.walk();

// par.prototype.dance = function () {
// 	console.log('pepi enters');
// };
// par.prototype.dance();
// Parent.prototype.dance();

// console.log(par.hasOwnProperty('prototype'));
// console.log(par.prototype);






// var prot = {name: 'mecho', age: 423423};
// console.log(prot.prototype);
// var der = Object.create(prot);
// console.log(der.prototype);







// var playable = (function function_name (argument) {
// 	var playable = Object.create({});

// 	Object.defineProperty(playable, 'init', {
// 		value: function (nname) {
// 			this.nname = nname;
// 			return this;
// 		},
// 		enumerable: true
// 	});

// 	Object.defineProperty(playable, 'toString', {
// 		value: function () {
// 			return 'name is '+ this.nname;
// 		},
// 		enumerable: true
// 	});

// 	return playable;
// }());

// var somePlayable = Object.create(playable).init('peckata');
// console.log(somePlayable.prototype == playable);
// console.log(somePlayable);







// var module = solve();

// player = module.getPlayer('pesho');
// playlist = module.getPlaylist('gosho');
// player.addPlaylist(playlist);
// var audio = module.getAudio('ivan', 'ivanov', 4);
// playlist.addPlayable(audio);

// console.log(player.search('van'));







// var playable = (function () {
//     var currentPlayableId = 0,
//         playable = Object.create({});

//     Object.defineProperty(playable, 'init', {
//         value: function (title, author) {
//             this.title = title;
//             this.author = author;
//             this._id = ++currentPlayableId;
//             return this;
//         }
//     });

//     Object.defineProperty(playable, 'id', {
//         get: function () {
//             return this._id;
//         }
//     });

//     Object.defineProperty(playable, 'title', {
//         get: function () {
//             return this._title;
//         },
//         set: function (val) {
//             // validator.validateString(val, 'Playable Title');
//             this._title = val;
//         }
//     });

//     Object.defineProperty(playable, 'author', {
//         get: function () {
//             return this._author;
//         },
//         set: function (val) {
//             // validator.validateString(val, 'Playable Author');
//             this._author = val;
//         }
//     });

//     Object.defineProperty(playable, 'play', {
//         value: function () {
//             return this.id + '. ' + this.title + ' - ' + this.author;
//         }
//     });

//     return playable;
// }());

// var somePlayableObject = Object.create(playable).init('title', 'author');
// console.log(somePlayableObject.prototype == playable);
// console.log(somePlayableObject.prototype);







// function solve () {
// 	var module = (function () {
		
// 	}());
// 	return module;
// }