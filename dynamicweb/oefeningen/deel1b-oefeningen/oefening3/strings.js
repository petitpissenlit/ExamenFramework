// Examples
// INPUT:   Hello world
// OUTPUT:  dlrow elloh

// INPUT:  barber
// OUTPUT: rebrab
let sentence = prompt("geef iets");

function Reverse(word) {
	let result = "";
	for (let index = word.length - 1; index >= 0; index--) {
		result += word[index];


	}



	return result;
}

console.log(Reverse(sentence));



// let word = "hello world";