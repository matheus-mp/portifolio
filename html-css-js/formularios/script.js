const form = document.getElementById("form1")

form.addEventListener("submit", function(event){
    event.preventDefault();

    let nome1 = document.getElementById("nome").value
    let email1 = document.getElementById("email").value
    let idade1 = document.getElementById("idade").value
    let tel1 = document.getElementById("tel").value

    const p = document.createElement('p')

    resultado.appendChild(p)

    if (nome1 === "" || email1 === "" || idade1 === "" || tel1 === ""){
        resultado.style.color = 'red';
        resultado.innerHTML = 'Preencha todos os campos!'
        return;
    }

    if (!email1.includes('@')) {
        resultado.style.color = 'red';
        resultado.innerHTML = 'Email inválido!';
        return;
    }

    if (idade1 < 0 || isNaN(idade1)) {
        resultado.style.color = 'red';
        resultado.innerHTML = 'Idade inválida!';
        return;
    }

    if (tel1.length < 8 || tel1.length > 8) {
        resultado.style.color = 'red';
        resultado.innerHTML = 'Telefone inválido!';
        return;
    }

    else {
        resultado.style.color = 'green';
    }

    resultado.innerHTML = 'Cadastro completo!'

    document.getElementById("dados").textContent = "Nome: " + nome1 + "\n" + "Email: " + email1 + "\n" + "Idade: " + idade1 + "\n" + "Telefone: " + tel1
})