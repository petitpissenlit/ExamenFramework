const API_URL = 'https://api.themoviedb.org/3/discover/movie?sort_by=popularity.desc&api_key=f5c0a8c2530bfc67b5d4ca6b6ffea750&page=1';

const IMG_PATH = 'https://image.tmdb.org/t/p/w1280';

const SEARCH_API = 'https://api.themoviedb.org/3/search/movie?api_key=a0814a81d9e0ea8e164320078c18b3cb&query="';

fecthFilm()
searchB()
backgroundColor();
borderline()


function backgroundColor() {
    document.getElementById('backgroundColor').addEventListener("change", () => {
        let backgroundColor = document.getElementById('backgroundColor').value
        console.log(backgroundColor);
        document.body.style.backgroundColor = backgroundColor;
    })

}

function borderline() {
    document.getElementById('borderColor').addEventListener("change", () => {
        let borderColor = document.getElementById('borderColor').value
        let borderStyle = document.getElementById('selectBorder').value
        let borderWidth = document.getElementById('selectBorderWidth').value + 'px'
        document.querySelector('main').style.border = borderWidth + " " + borderStyle + " " + borderColor;

    })

    document.getElementById('selectBorder').addEventListener("change", () => {
        let borderColor = document.getElementById('borderColor').value
        let borderStyle = document.getElementById('selectBorder').value
        let borderWidth = document.getElementById('selectBorderWidth').value + 'px'
        document.querySelector('main').style.border = borderWidth + " " + borderStyle + " " + borderColor;

    })

    document.getElementById('selectBorderWidth').addEventListener("change", () => {
        let borderColor = document.getElementById('borderColor').value
        let borderStyle = document.getElementById('selectBorder').value
        let borderWidth = document.getElementById('selectBorderWidth').value + 'px'
        document.querySelector('main').style.border = borderWidth + " " + borderStyle + " " + borderColor;

    })

}

function fecthFilm() {
    fetch('https://api.themoviedb.org/3/discover/movie?sort_by=popularity.desc&api_key=f5c0a8c2530bfc67b5d4ca6b6ffea750&page=1')
        .then(response => response.json())
        .then(data => {
            let results = data.results
            let htmlString = '';

            results.forEach(result => {
                console.log(result)
                let posterPath = IMG_PATH + result.poster_path;
                htmlString += `
                <div class="movie" id='${result.id}'>
                    <img src="${posterPath}" alt="${result. y} Poster">
                    <div class="movie-info">
                        <h3>${result.title}</h3>
                        <span class="${rate(result.vote_average)}">${result.vote_average}</span>
                    </div>
                    <div class="overview">
                        ${result.overview}
                    </div>
                </div>`;

            });

            document.getElementById('main').innerHTML += htmlString;
            infoMovie()
        })


}

function rate(vote) {
    if (vote >= 8) {
        return 'green'
    } else if (vote >= 5) {
        return 'orange'
    } else {
        return 'red'
    }


}

const selectVote = document.getElementById("selectVote");
selectVote.addEventListener("change", handleSelectChange);

function handleSelectChange() {
    const selectedValue = parseInt(this.value);
    const elements = document.querySelectorAll("[data-vote]");
    elements.forEach(element => {
        const elementVote = parseInt(element.dataset.vote);
        if (elementVote >= selectedValue) {
            element.style.display = "block";
        } else {
            element.style.display = "none";
        }
    });
}





function searchB() {
    const searchForm = document.getElementById('form');
    const searchInput = document.getElementById('search');

    searchForm.addEventListener('submit', (e) => {
        e.preventDefault();

        const searchTerm = searchInput.value;

        if (searchTerm && searchTerm !== '') {
            searchMovies(searchTerm);
            searchInput.value = '';
        } else {
            window.location.reload();
        }
    });

    function searchMovies(searchTerm) {
        fetch(SEARCH_API + searchTerm)
            .then(response => response.json())
            .then(data => {
                let results = data.results
                let htmlString = '';

                if (results.length === 0) {
                    htmlString = `<h2>No results found for '${searchTerm}'</h2>`;
                } else {
                    results.forEach(result => {
                        let posterPath = IMG_PATH + result.poster_path;
                        htmlString += `
                        <div class="movie" id='${result.id}'>
                            <img src="${posterPath}" alt="${result.title} Poster">
                            <div class="movie-info">
                                <h3>${result.title}</h3>
                                <span class="${rate(result.vote_average)}">${result.vote_average}</span>
                            </div>
                            <div class="overview">
                                ${result.overview}
                            </div>
                        </div>`;
                    });
                }

                document.getElementById('main').innerHTML = htmlString;
            });

    }
}
function infoMovie() {
    const movies = document.getElementsByClassName("movie");
    let moviesArray = [].slice.call(movies);
    moviesArray.forEach(result => {
        result.addEventListener("click", function (e) {
            setTimeout(500)
            e.preventDefault();

            const movieID = result.id;
            window.location.href = `movie.html?id=${movieID}`;

        })
    })
}

