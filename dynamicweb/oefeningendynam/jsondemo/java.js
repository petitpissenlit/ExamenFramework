"use strict";

document.getElementById("MJ").addEventListener("click",() => {

    let user =
    {
        name: "soufian",
        email: "dnoubsoufian@gmail.com",
        city: "lennik",
        age: 23

    
    };
    console.log(user);


    let product =
    {
        name: "hamburguerre",
        description: "no cochon it is halal",
        price: 3
    }
    console.log(product);


    let userstring = JSON.stringify(user);
    console.log(userstring);

    localStorage.setItem("UserTest", userstring);
});

document.getElementById("RCS").addEventListener("click", () => {
    
    let SaveUser = localStorage.getItem("UserTest");
    console.log(SaveUser);
    let savedUserObject = JSON.parse(SaveUser);
    console.log(savedUserObject);

    console.log(savedUserObject.name);
    console.warn(savedUserObject.name);
});