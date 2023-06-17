class Card {
    constructor(suit, value) {
        this.suit = suit;
        this.value = value;
    }
}
class Deck {
    constructor() {
        this.deck = [];
    }

    createDeck(suits, values) {
        for (let suit of suits) {
            for (let value of values) {
                this.deck.push(new Card(suit, value));
            }
        }
        return this.deck
    }


}
let suits = [' harten', 'schoppen', 'ruiten', 'klaveren'];
let values = [2, 3, 4, 5, 6, 7, 8, 9, 10, 'Jack', 'Queen', 'King', 'Ace'];
let deck = new deck();
deck.createDeck(suits, values);
console.log(deck.createDeck(suits, values));