/* PROBLEM 1. JavaScript literals
        Assign all the possible JavaScript literals to different variables.
*/
//'Nothing' Variables
var nullVar = null;
console.log(nullVar);
var undefinedVar = undefined;
console.log(undefinedVar);
var nanVar = NaN;
console.log(nanVar);

//Numbers
var decimalInt1 = 5;
console.log(decimalInt1);
var decimalInt2 = -16;  //Just so that negative values are also represented.
console.log(decimalInt2);
var octalInt = 015;
console.log(octalInt);
var hexInt = 0xF2B7;
console.log(hexInt);
var floatNum1 = 3.5;
console.log(floatNum1);
var floatNum2 = -.4;
console.log(floatNum2);
var floatNum3 = 7.;
console.log(floatNum3);
var floatEpsNum = -3.1E42;
console.log(floatEpsNum);

//Strings
var emptyString = "";
console.log(emptyString);
var singleQuotes1 = 'Double "quotes" are used inside single-quotes string literal.';
console.log(singleQuotes1);
var singleQuotes2 = 'This slash was espaced \\.';
console.log(singleQuotes2);
var doubleQuotes1 = "Single 'quotes' are used inside double-quotes string literal.";
console.log(doubleQuotes1);
var doubleQuotes2 = "A new line special character \n was jut used:)";
console.log(doubleQuotes2);
//var backticksAndPlaceholders = `Something ${decimalInt1 + decimalInt2} something`;      //Experimental feature, Visual Studio whines a lot.

//Boolean
var trueVar = true;
console.log(trueVar);
var falseVar = false;
console.log(falseVar);

//Arrays
var arraySimple = ["Cherry", "Melon"];
console.log(arraySimple);
var arrayUndefined1 = ["Kitty", , "Doggy"];
console.log(arrayUndefined1);
var arrayUndefined2 = ["Kitty", "Doggy", , ];
console.log(arrayUndefined2);
var arrayNested = [["Play with Fire", "Hey You"], "Retrograde", "Pagan Poetry"];
console.log(arrayNested);

//Function
var funcVar = function () { return "This is the function's result." };
console.log(funcVar());

//Objects
var carObject1 = {
	myCar : "Saturn", 
	carType : function(){ return "Honda"}
};
console.log(carObject1.myCar);
console.log(carObject1.carType);
var carObject2 = { 
	"stringProperty": "Saab", 
	"": "Still works", 
	10: "Jeep!" 
};
console.log(carObject2.stringProperty);
console.log(carObject2[""]);
console.log(carObject2[10]);
var carObjectNested = { 
	innerObject: { 
		"!": 7362676253465263546376, 
		someProp : true
	}, 
	sth: "Weird language, huh?" 
};
console.log(carObjectNested.innerObject["!"]);
console.log(carObjectNested.innerObject.someProp);
console.log(carObjectNested.sth);
var emptyObject = {};
console.log(emptyObject);


/* PROBLEM 2. Quoted text
        Create a string variable with quoted text in it.
        For example: `'How you doin'?', Joey said'.
*/
var quotedText = '\'Joey doesn\'t share \n Food or Armchair!\', Joey said. And then they knew...';
console.log(quotedText);


/* PROBLEM 3. Typeof variables
        Try typeof on all variables you created.
*/
//'Nothing' Variables
console.log(typeof (nullVar));
console.log(typeof (undefinedVar));
console.log(typeof (nanVar));

//Numbers
console.log(typeof (decimalInt1));
console.log(typeof (decimalInt2));
console.log(typeof (octalInt));
console.log(typeof (hexInt));
console.log(typeof (floatNum1));
console.log(typeof (floatNum2));
console.log(typeof (floatNum3));
console.log(typeof (floatEpsNum));

//Strings
console.log(typeof (emptyString));
console.log(typeof (singleQuotes1));
console.log(typeof (singleQuotes2));
console.log(typeof (doubleQuotes1));
console.log(typeof (doubleQuotes2));

//Boolean
console.log(typeof (trueVar));
console.log(typeof (falseVar));

//Arrays
console.log(typeof (arraySimple));
console.log(typeof (arrayUndefined1));
console.log(typeof (arrayUndefined2));
console.log(typeof (arrayNested));

//Function
console.log(typeof (funcVar));

//Objects
console.log(typeof (carObject2));		
console.log(typeof (carObject1));		
console.log(typeof (carObjectNested));	
console.log(typeof (emptyObject));	


/* PROBLEM 4. Typeof null
    Create null, undefined variables and try typeof on them.
*/
var anotherNull = null;
console.log(typeof (anotherNull));
var anotherUndefined = undefined;
console.log(typeof (anotherUndefined));