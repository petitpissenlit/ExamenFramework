let straal = prompt("voer de straal van de cirkel in");

straal = parseFloat(straal);

let oppervlakte = Math.PI * Math.pow(straal, 2);
let omtrek = 2 * Math.PI * straal;

console.log("de opp is :" + oppervlakte);
console.log("de omtrek is:" + omtrek);
