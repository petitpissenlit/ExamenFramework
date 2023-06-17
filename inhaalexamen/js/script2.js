const queryString = window.location.search;
const urlParams = new URLSearchParams(queryString);
const movieID = urlParams.get('id')

const IMG_PATH = 'https://image.tmdb.org/t/p/w1280';

window.onload = function fetchInfo() {

    fetch(`https://api.themoviedb.org/3/movie/${movieID}?api_key=f5c0a8c2530bfc67b5d4ca6b6ffea750&`)
        .then(response => response.json())
        .then(data => {
            console.log(data)
            let result = data

            let posterPath = IMG_PATH + result.poster_path;

            let htmlString = '';

            htmlString += `
                <div class="moviez" id='${result.id}'>
                    <img src="${posterPath}" alt="${result.title} Poster">
                    <div class="movie-infoz">
                        <h3>${result.title}</h3>
                        <span class="red">${result.vote_average}</span>
                    </div>
                    <div class="overviewz">
                        ${result.overview}
                    </div>
                </div>`;
            document.getElementById('main').innerHTML += htmlString;

        });


}

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
