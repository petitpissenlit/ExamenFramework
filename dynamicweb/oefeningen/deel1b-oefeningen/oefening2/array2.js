let arr = ["banana", "apples", "pear", "cherry"];

var invoerveld = Number(prompt('which froot do yoou like?'));




switch (invoerveld) {
    case 0:
        console.log("you eat all the apples" + arr[invoerveld]);
        break;
    case 1:
        console.log("you throw this" + arr[invoerveld]);
        break;

    case 2:
        console.log("you are a sweet" + arr[invoerveld]);
        break;

    case 3:
        console.log("you squease the" + arr[invoerveld]);
        break;


    default:
        break;
}