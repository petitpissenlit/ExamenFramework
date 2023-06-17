const getTodos = function (url, callback) {
    const request = new XMLHttpRequest();
    request.open('GET', url);
    request.send();
    request.onload = function () {
        if (request.status === 200) {
            const data = JSON.parse(request.responseText);
            callback(undefined, data);
        
        } else {
            console.log();
            callback('not found...', undefined);
        }
    }
}
const url1 = 'https://jsonplaceholder.typicode.com/todos/1';
const url2 = 'https://jsonplaceholder.typicode.com/todos/2';
const url3 = 'https://jsonplaceholder.typicode.com/todos/3';

getTodos(url1, function (error, data) {
    if (error) {
        console.log('no Data...');
    } else {
        console.log(data);
        getTodos(url2, function (error, data) {
            if (error) {
                console.log('no Data...');
            } else {
                console.log(data);
                getTodos(url3, function (error, data) {
                    if (error) {
                        console.log('no Data...');
                    } else {
                        console.log(data);
                    }
                });
            }
        });
    }
});
            

