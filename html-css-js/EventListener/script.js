let p = document.getElementById("p")

document.getElementById("button").addEventListener("mouseout", function(){
    p.style.display = "none"
})
document.getElementById("button").addEventListener("mouseover", function(){
    p.style.display = "block"
})

document.getElementById("button").addEventListener("click", function(){
    p.style.color = "pink"
    p.textContent = "fiquei rosa bixo"
    document.body.style.backgroundColor = "white"
})
document.getElementById("button").addEventListener("dblclick", function(){
    p.style.color = "white"
    p.textContent = "fiquei branco, oloco"
    document.body.style.backgroundColor = "black"
})