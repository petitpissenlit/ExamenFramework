let nu = prompt (`wat is jouw nummer: `)
for (let i = 0; i < nu; i++) {
console.log(i);
switch (i) {
    case 0:
        console.log('nul')
        break;
        case 1:
        console.log('een')
        break;
        case 2:
        console.log('twee')
        break;
        case 3:
        console.log('drie')
        break;
        case 4:
            console.log('drie')
        break;
        case 5:
        console.log('vijf')
        break;
        case 6:
        console.log('zes')
        break;
        case 7:
        console.log('zeven')
        break;
        case 8:
        console.log('acht')
        break;
        case 9:
        console.log('negen')
        break;
    default:
        console.log("het getal mag niet groter zijn dan 10")
        break;
}
}