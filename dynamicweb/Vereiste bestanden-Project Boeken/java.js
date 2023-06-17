function addBook(title) {
    const li = document.createElement('li');
    const name = document.createElement('span');
    const deleteBtn = document.createElement('span');
    name.textContent = title;
    deleteBtn.textContent = 'Delete';
    deleteBtn.classList.add('delete');
    li.appendChild(name);
    li.appendChild(deleteBtn);
    bookList.appendChild(li);
}

function getBooks() {
    const books = localStorage.getItem('books');
    if (books) {
        return JSON.parse(books);
    } else {
        return [];
    }
}

function saveBooks(books) {
    localStorage.setItem('books', JSON.stringify(books));
}

function displayBooks() {
    const books = getBooks();
    bookList.innerHTML = '';
    books.forEach(book => addBook(book));
}
document.querySelector('#add-book').addEventListener('submit', e => {
    e.preventDefault();
    const input = document.querySelector('#add-book input');
    const title = input.value.trim();
    if (title) {
        addBook(title);
        const books = getBooks();
        books.push(title);
        saveBooks(books);
        input.value = '';
    }
});
bookList.addEventListener('click', e => {
    if (e.target.classList.contains('delete')) {
        const li = e.target.parentElement;
        const title = li.firstChild.textContent;
        const books = getBooks();
        const index = books.indexOf(title);
        if (index !== -1) {
            books.splice(index, 1);
            saveBooks(books);
        }
        li.remove();
    }
});
hideCheckbox.addEventListener('change', e => {
    if (hideCheckbox.checked) {
        bookList.style.display = 'none';
    } else {
        bookList.style.display = 'initial';
    }
});

function filterBooks(query) {
    const books = getBooks();
    const filteredBooks = books.filter(book => book.toLowerCase().includes(query.toLowerCase()));
    bookList.innerHTML = '';
    filteredBooks.forEach(book => addBook(book));
}
const searchForm = document.querySelector('#search-books');
searchBar.addEventListener('keyup', e => {
    const searchTerm = e.target.value.toLowerCase();
    const books = bookList.querySelectorAll('li');
    Array.from(books).forEach(book => {
        const title = book.querySelector('.name').textContent.toLowerCase();
        if (title.includes(searchTerm)) {
            book.style.display = 'block';
        } else {
            book.style.display = 'none';
        }
    });
});