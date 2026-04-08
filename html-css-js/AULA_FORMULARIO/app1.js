const form = document.getElementById("formCadastro");

let resultado = document.getElementById("resultado")

window.onload = function () {
    listarUsuarios();
}

form.addEventListener("submit", function (event) {
    event.preventDefault();

    let nome = document.getElementById("nome").value

    let email = document.getElementById("email").value

    let idade = document.getElementById("idade").value

    let telefone = document.getElementById("telefone").value


    if (nome == "" || email == "" || idade == "" || telefone == "") {
        resultado.innerHTML = "Preencha todos os campos";
        return;
    }

    if (isNaN(idade) || idade < 0) {
        resultado.innerHTML = "Idade Inválida";
        return;
    }

    if (telefone.length < 8) {
        resultado.innerHTML = "Telefone com caracteres menores que 8";
        return
    } else if (telefone.length > 8) {
        resultado.innerHTML = "Telefone com caracteres maiores que 8";
        return;
    }

    let usuarios = JSON.parse(localStorage.getItem("usuarios")) || [];

    let novoUsuario = {
        nome: nome,
        email: email,
        idade: idade,
        telefone: telefone
    };

    usuarios.push(novoUsuario);

    localStorage.setItem("usuarios", JSON.stringify(usuarios));

    resultado.innerHTML = "<br><br>Cadastro Realizado!!";
    resultado.style.color = "green";
    window.location.reload();

})

function listarUsuarios() {
    let usuarios = JSON.parse(localStorage.getItem("usuarios")) || [];

    usuarios.forEach(function (user) {
        const p = document.createElement('p');

        p.innerHTML =
            'Nome: ' + user.nome + '<br>' +
            'Email: ' + user.email + '<br>' +
            'Idade: ' + user.idade + '<br>' +
            'Telefone: ' + user.telefone + '<hr>';

        resultado.appendChild(p);
    })
}

document.getElementById("reset").addEventListener("click", function(){
    localStorage.clear();
    alert("Registros limpos!")
    window.location.reload();
    
})

