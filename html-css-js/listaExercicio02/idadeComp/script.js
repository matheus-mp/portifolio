function idadeComp() {
    a = +prompt("Digite a primeira idade:");

    while (isNaN(a) || a == null || a < 0) {
        alert("Dígito inválido");
        a = +prompt("Digite a primeira idade:");
    }

    b = +prompt("Digite a segunda idade:");

    while (isNaN(b) || b == null || b < 0) {
        alert("Dígito inválido");
        b = +prompt("Digite a segunda idade:");
    }

    if (a == b) {
        document.writeln("As duas idades são iguais");
    } else if (a < b){
        document.writeln("A idade " + b + " é maior que " + a);    
    } else {
        document.writeln("A idade " + a + " é maior que " + b);
    }
}