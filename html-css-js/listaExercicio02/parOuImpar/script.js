function parOuImpar() {
    a = +prompt("Digite um número:");

    while (isNaN(a) || a == null || a < 0) {
        alert("Dígito inválido");
        a = +prompt("Digite um número:");
    }

    if (a % 2 == 0) {
        document.writeln("O número é par");
    } else {
        document.writeln("O número é ímpar")    
    } 
}