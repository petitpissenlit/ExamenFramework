function myDisplayer(some) {
    document.getElementById("myimg").src = `${some}`;
    document.getElementById("demo").innerHTML = some;
}
let myPromise = new Promise(function (myResolve, myReject) {
    let req = new XMLHttpRequest();
    req.open('GET', 'https://dog.ceo/api/breeds/image/random')
    req.onload = function () {
        if (req.status == 200) {
            const response = JSON.parse(this.responseText);
            myUrl = response.message;
            myResolve(myUrl);
        } else {
            myReject("File not Found")
        }
    };
    req.send();
});
myPromise.then(
    function (value) {
        myDisplayer(value);
    },
    function (error) {
        myDisplayer(error);
    }
);