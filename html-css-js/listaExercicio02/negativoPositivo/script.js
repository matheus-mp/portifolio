function negativoPositivo() {
    a = +prompt("Digite um número:");

    if (a < 0) {
        document.writeln("O número é negativo");
    } else if (a > 0) {
        document.writeln("O número é positivo");
    } else {
        document.writeln("O número é 0");
    }
}