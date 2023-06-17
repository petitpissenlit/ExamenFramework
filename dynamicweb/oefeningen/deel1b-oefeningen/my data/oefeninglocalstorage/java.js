// Gegevens opslaan in LocalStorage
localStorage.setItem('gegevens', 'Dit zijn mijn opgeslagen gegevens.');

// Gegevens uitlezen uit LocalStorage
let opgeslagenGegevens = localStorage.getItem('gegevens');
console.log(opgeslagenGegevens); // Output: "Dit zijn mijn opgeslagen gegevens."

// Gegevens verwijderen uit LocalStorage
localStorage.removeItem('gegevens');