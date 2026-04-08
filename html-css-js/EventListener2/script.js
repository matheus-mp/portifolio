document.getElementById("b1").addEventListener("click", function(){
    alert("Você clicou no botão!")
})

document.getElementById("b2").addEventListener("click", function(){
    alert("Você clicou no botão!")
    document.getElementById("b2").style.display = "none"
})

document.getElementById("b3").addEventListener("click", function(){
    document.getElementById("b3").style.display = "none"
    setTimeout(() => {
        document.getElementById("b3").style.display = ""
    }, 4000)
})

document.getElementById("b4").addEventListener("mouseover", function(){
    document.getElementById("b4").style.backgroundColor = "blue"
    document.getElementById("b4").style.color = "white"
})
document.getElementById("b4").addEventListener("mouseleave", function(){
    document.getElementById("b4").style.backgroundColor = ""
    document.getElementById("b4").style.color = "black"
})

document.getElementById("b5").addEventListener("click", function(){
    document.getElementById("p5").style.display = ""
    setTimeout(() => {
        document.getElementById("p5").style.display = "none"
    }, 5000)
})

document.getElementById("b6").addEventListener("click", function(){
    document.getElementById("b6").style.display = "none"
    document.getElementById("p6").style.display = ""
    setTimeout(() => {
        document.getElementById("p6").textContent = "Finalizado!"
        document.getElementById("b6").style.display = ""
    }, 4000)
})

document.getElementById("b7").addEventListener("mouseover", function(){
    document.getElementById("b7").style.backgroundColor = "black"
    document.getElementById("b7").style.color = "white"
})
document.getElementById("b7").addEventListener("mouseleave", function(){
    document.getElementById("b7").style.backgroundColor = ""
    document.getElementById("b7").style.color = ""
})
document.getElementById("b7").addEventListener("click", function(){
    document.getElementById("b7").style.display = "none"
    setTimeout(() => {
        document.getElementById("b7").style.display = ""
    }, 2000)
})