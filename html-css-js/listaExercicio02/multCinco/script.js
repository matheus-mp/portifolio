function multCinco() {
    a = +prompt("Digite um número:");

    while (isNaN(a) || a == null || a < 0) {
        alert("Dígito inválido");
        a = +prompt("Digite um número:");
    }

    if (a % 5 == 0) {
        document.body.innerHTML = "O número é múltiplo de 5";
    } else {
        document.body.innerHTML = "O número não é múltiplo de 5";    
    } 
}