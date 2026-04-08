function soma(a, b) {
    document.writeln("A soma de ", a ," e ", b ," é igual a: ", a + b);
}

function operacoes(a, b){
    document.writeln("A soma de ", a ," e ", b ," é igual a: ", a + b);

    document.writeln("<br>");

    document.writeln("A subtração de ", a ," e ", b ," é igual a: ", a - b);
    
    document.writeln("<br>");

    document.writeln("A multiplicação de ", a ," e ", b ," é igual a: ", a * b);

    document.writeln("<br>");

    document.writeln("A divisão de ", a ," e ", b ," é igual a: ", a / b);
}

function quadrado(a){
    document.writeln("O número ", a ," ao quadrado é igual a: ", a * a);
}

function sinais(a){
    document.writeln("O número ", a ," é: ");

    if (a < 0) {
        document.writeln("negativo");
    } else if (a > 0) {
        document.writeln("positivo");
    } else {
        document.writeln("zero");
    }
}

function idade(a){
    document.writeln("Uma pessoa com ", a ," anos é: ");

    if (a < 18) {
        document.writeln("maior de idade!");
    } else if(a > 18) {
        document.writeln("maior de idade!");
    } else {
        document.writeln("idade inválida.");
    }
}

function compIdade(a, b){
    document.writeln("Pessoa 1: ", a, " anos");

    document.writeln("<br>");

    document.writeln("Pessoa 2: ", b, " anos");

    document.writeln("<br><br>");

    if (a > b) {
        document.writeln("A pessoa 1 é mais velha do que a pessoa 2.");
    } else if (a < b) {
        document.writeln("A pessoa 2 é mais velha do que a pessoa 1.");
    } else {
        document.writeln("As duas pessoas tem a mesma idade.");
    }
}

function parOuImpar(a){
    if (a%2 == 0) {
        document.writeln("O número ", a ," é par!");
    } else {
        document.writeln("O número ", a ," é ímpar!");
    }
}

function multiploCinco(a) {
    if (a%5 == 0) {
        document.writeln("O número ", a ," é múltiplo de 5!");
    } else {
        document.writeln("O número ", a ," não é múltiplo de 5!");
    }
}

function maiorNumero(a, b, c) {
    document.writeln("Número 1: ", a);

    document.writeln("<br>");

    document.writeln("Número 2: ", b);

    document.writeln("<br>");

    document.writeln("Número 3: ", c);

    document.writeln("<br><br>");

    if (a > b && a > c) {
        document.writeln("O número ", a ," é o maior");
    } else if (b > a && b > c) {
        document.writeln("O número ", b ," é o maior");
    } else {
        document.writeln("O número ", c ," é o maior!");
    }
}

function contDez() {
    for (i = 1; i <= 10; i++) {
        document.writeln(i);
        document.writeln("<br>");
    }
}

function contUm() {
    for (i = 10; i >= 1; i--) {
        document.writeln(i);
        document.writeln("<br>");
    }
}

function numPar() {
    for (i = 0; i <= 20; i++) {
        if (i % 2 == 0) {
            document.writeln(i);
            document.writeln("<br>");
        }
    }
}

function somaCem() {
    let soma = 0;
    
    for (i = 1; i <= 100; i++) {
        soma += i;
    }

    document.writeln("O total somado de 1 a 100 é igual a: ", soma);
}