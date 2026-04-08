const campoIdade = document.getElementById("idade");
const resultado = document.getElementById("resultado");

campoIdade.addEventListener("input", function() {

  const idadeDigitada = Number(campoIdade.value);

  if (campoIdade.value === "") {
    resultado.innerHTML = "";
  } else if (idadeDigitada < 18 && idadeDigitada >= 0) {
    resultado.innerHTML = "Você é menor de idade, faltam " + (18 - idadeDigitada) + " anos para você chegar à maioridade";
  } else if (idadeDigitada < 0) {
    resultado.innerHTML = "Digito inválido";
  } else {
    if (idadeDigitada == 67) {
        resultado.innerHTML = "sic seve";
    } else {
        resultado.innerHTML = "Você é maior de idade";
    }
  } 
});          
