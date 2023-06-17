
function calculator() {
    
    var num1 = parseFloat(prompt("Enter the first number: "));
    var num2 = parseFloat(prompt("Enter the second number: "));
    var operator = prompt("Enter an operator (+, -, *, /): ");

    
    if (operator === "+") {
        console.log(num1 + num2);
    } else if (operator === "-") {
        console.log(num1 - num2);
    } else if (operator === "*") {
        console.log(num1 * num2);
    } else if (operator === "/") {
        console.log(num1 / num2);
    } else {
        console.log("Invalid operator");
    }
}


calculator();
