let straal = 5;
let hoogte = 10;

function oppervlakte() {
    console.log("oppervlakte:" + " " +
        straal * straal * Math.PI);

}
oppervlakte(5)

function omtrek() {
    console.log("omtrek:" + " " + 2 * straal * Math.PI);
}
omtrek(5)

function volume() {
    console.log("volume:" + " " +
        Math.PI * (straal * straal) * hoogte);
}
volume(5, 10)

