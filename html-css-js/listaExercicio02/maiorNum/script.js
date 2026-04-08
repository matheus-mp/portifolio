function maiorNum() {
    a = +prompt("Digite o primeiro número:");

    while (isNaN(a) || a == null || a < 0) {
        alert("Dígito inválido");
        a = +prompt("Digite o primeiro número:");
    }

    b = +prompt("Digite o segundo número:");

    while (isNaN(b) || b == null || b < 0) {
        alert("Dígito inválido");
        b = +prompt("Digite a segunda idade:");
    }

    c = +prompt("Digite o terceiro número:");

    while (isNaN(c) || c == null || c < 0) {
        alert("Dígito inválido");
        c = +prompt("Digite o terceiro número:");
    }

    if (a > b && b > c) {
        document.writeln(a + " é maior que " + b + " que é maior que " + c);
    } else if (a > c && c > b){
        document.writeln(a + " é maior que " + c + " que é maior que " + b);    
    } else if (b > a && a > c){
        document.writeln(b + " é maior que " + a + " que é maior que " + c);
    } else if (b > c && c > a) {
        document.writeln(b + " é maior que " + c + " que é maior que " + a);
    } else if (c > a && a > b) {
        document.writeln(c + " é maior que " + a + " que é maior que " + b);
    } else{
        document.writeln(c + " é maior que " + b + " que é maior que " + a);
    }
}