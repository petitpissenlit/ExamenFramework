let rechthoek = {
    lengte: prompt("Voer de lengte van de rechthoek in:"),
    breedte: prompt("Voer de breedte van de rechthoek in:"),
    berekenOppervlakte: function () {
        return this.lengte * this.breedte;
    },
    berekenOmtrek: function () {
        return 2 * (this.lengte + this.breedte);
    }
};

console.log("Oppervlakte van de rechthoek is: " + rechthoek.berekenOppervlakte());
//console.log("Omtrek van de rechthoek is: " + rechthoek.berekenOmtrek());