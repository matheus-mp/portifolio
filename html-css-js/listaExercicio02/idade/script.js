function idade() {
    a = +prompt("Digite sua idade:");

    while (isNaN(a) || a == null || a < 0) {
        alert("Dígito inválido");
        a = +prompt("Digite sua idade:");
    }

    if (a < 18) {
        document.writeln("Você é menor de idade");
    } else {
        if (a == 67) {
            document.writeln("Você é maior de idade (sics sevein)")    
        } else {
            document.writeln("Você é maior de idade");
        }
    } 
}