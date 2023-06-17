function createAccount() {
    let username = document.getElementById("username").value;
    let password = document.getElementById("password").value;
    localStorage.setItem("username", username);
    localStorage.setItem("password", password);
    document.getElementById("status").innerHTML = "Account created.";
  }
  
  
  function login() {
    let username = document.getElementById("username").value;
    let password = document.getElementById("password").value;
    let storedUsername = localStorage.getItem("username");
    let storedPassword = localStorage.getItem("password");
   
    if (username === storedUsername && password === storedPassword) {
      document.getElementById("status").innerHTML = "Login successful.";
    } else {
      document.getElementById("status").innerHTML = "Login failed. Please try again.";
    }
  }