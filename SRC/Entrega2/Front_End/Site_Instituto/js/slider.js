let cont = 1
document.getElementById('radio1').checked = true

var radio = document.querySelector('.manual-btn')

setInterval( function() {
    proximaImg()
}, 5000)

function proximaImg(){
    cont++

    if(cont > 3){
        cont = 1 
    }

    document.getElementById('radio'+cont).checked = true
}