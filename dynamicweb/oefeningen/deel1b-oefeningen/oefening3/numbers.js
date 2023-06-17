// Input:4
// (4 * 3 * 2 * 1) = 24
// Output:24

// Input:8
// (8 * 7 * 6 * 5 * 4 * 3 * 2 * 1) = 40320
// Output:40320
var invoepromptvarrveld = Number(prompt("welke waar wil je bereiken?"));

function Factorial(invoerveld) {

	var counter = invoerveld;

	for (let index = 1; index < counter; index++) {
		invoerveld *= index;
		console.log(invoerveld);
	}



	return invoerveld;

}


console.log(Factorial(invoepromptvarrveld));