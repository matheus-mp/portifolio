function operacoes() {
    a = +prompt("Digite o primeiro número:");
    b = +prompt("Digite o segundo número");
    
    document.writeln("A soma de " + a + " e " + b + " é igual a " + (a + b));

    document.writeln("<br><br>");

    document.writeln("A subtração de " + a + " e " + b + " é igual a " + (a - b));

    document.writeln("<br><br>");

    document.writeln("A multiplicacao de " + a + " e " + b + " é igual a " + (a * b));

    document.writeln("<br><br>");

    document.writeln("A divisão de " + a + " e " + b + " é igual a " + (a / b));

    document.writeln("<br><br>");
}