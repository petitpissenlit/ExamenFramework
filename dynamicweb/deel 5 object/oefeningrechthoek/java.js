let rechthoek = {
    lengte: 40,
    breedte: 60,
    berekenOppervlakte: function () {
        return this.lengte * this.breedte;
    }
};

console.log("opppervlakte van de rechthoek is :" +rechthoek.berekenOppervlakte());