let userInput = prompt('What is your age?');
// INPUT : 18
// OUTPUT : you are a adult!

// INPUT : between 10-20
// OUTPUT : you are a teenager!

// INPUT : below 10
// OUTPUT : you are a baby!

// INPUT : higher than 70 or the text "old"
// OUTPUT : you are old!

// INPUT : everthing else
// OUTPUT : is that an age?
if (userInput >= 10 && userInput <= 20) {
    console.log("you are a teenager!");
} else if (userInput < 10) {
    console.log("you are a baby!");

} else if (userInput > 70) {
    console.log("you are old!");
} else {
    console.log("is that an age?");
}