function cal(operator) {
    FirstOperator = document.getElementById('t1').value;
    f1 = parseFloat(FirstOperator);
    SecondeOperator = document.getElementById('t2').value;
    f2 = parseFloat(SecondeOperator);
    if (operator === '+') {
        result = f1 + f2;
    } else if (operator === '-') {
        result = f1 - f2;
    } else if (operator === '*') {
        result = f1 * f2;
    } else if (operator === '/') {
        result = f1 / f2;
    }
    if (isNaN(result)) {
        alert("Enter two numbers please");
    } else {
        s1 = document.getElementById('t3').value = result.toString();
    }
}

document.getElementById("sm").addEventListener("click", functionSum);

function functionSum() {
    FirstOperator = document.getElementById('t1').value;
    f1 = parseFloat(FirstOperator);
    SecondeOperator = document.getElementById('t2').value;
    f2 = parseFloat(SecondeOperator);

    result = f1 + f2;

    document.getElementById('t3').value = result.toString();
}

document.getElementById("mi").addEventListener("click", functionMin);

function functionMin() {
    FirstOperator = document.getElementById('t1').value;
    f1 = parseFloat(FirstOperator);
    SecondeOperator = document.getElementById('t2').value;
    f2 = parseFloat(SecondeOperator);

    result = f1 - f2;

    document.getElementById('t3').value = result.toString();
}

    document.getElementById("ma").addEventListener("click", functionMaal);
    

function functionMaal() {
    FirstOperator = document.getElementById('t1').value;
    f1 = parseFloat(FirstOperator);
    SecondeOperator = document.getElementById('t2').value;
    f2 = parseFloat(SecondeOperator);

    result = f1 * f2;

    document.getElementById('t3').value = result.toString();
}

document.getElementById("de").addEventListener("click", functionDeel);

function functionDeel() {
    FirstOperator = document.getElementById('t1').value;
    f1 = parseFloat(FirstOperator);
    SecondeOperator = document.getElementById('t2').value;
    f2 = parseFloat(SecondeOperator);

    result = f1 / f2;

    document.getElementById('t3').value = result.toString();
}