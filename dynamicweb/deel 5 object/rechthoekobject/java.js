class Rechthoek {
    constructor(lengte, breedte) {
        this.lengte = lengte;
        this.breedte = breedte;
    }

    berekenOppervlakte() {
        return this.lengte * this.breedte;
    }

    berekenOmtrek() {
        return 2 * (this.lengte + this.breedte);
    }
}


const lengte1 = prompt("Voer de lengte van de eerste rechthoek in:");
const breedte1 = prompt("Voer de breedte van de eerste rechthoek in:");


const rechthoek1 = new Rechthoek(lengte1, breedte1);


const lengte2 = prompt("Voer de lengte van de tweede rechthoek in:");
const breedte2 = prompt("Voer de breedte van de tweede rechthoek in:");


const rechthoek2 = new Rechthoek(lengte2, breedte2);


document.write("<p>De oppervlakte van de eerste rechthoek is " + rechthoek1.berekenOppervlakte() + "</p>");
document.write("<p>De omtrek van de eerste rechthoek is " + rechthoek1.berekenOmtrek() + "</p>");
document.write("<p>De oppervlakte van de tweede rechthoek is " + rechthoek2.berekenOppervlakte() + "</p>");
document.write("<p>De omtrek van de tweede rechthoek is " + rechthoek2.berekenOmtrek() + "</p>");
