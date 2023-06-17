let numbers = [0, 2, -1, 23, 7];
let result;

result = numbers.reduce(function (sum, cValue) {
    return sum + cValue;
});

console.log(result);
console.log(numbers);


