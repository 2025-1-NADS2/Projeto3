const tagDias = document.querySelector(".dias"),
dataAtual = document.querySelector(".data-atual"),
prevNextIcon = document.querySelectorAll(".icons span");

let date = new Date(),
anoAtual = date.getFullYear(),
mesAtual = date.getMonth();
const months = ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho",
              "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"];
const renderCalendar = () => {
    let primeiroDiaDoMes = new Date(anoAtual, mesAtual, 1).getDay(),
    ultimaDataMes = new Date(anoAtual, mesAtual + 1, 0).getDate(),
    ultimoDiaDoMes = new Date(anoAtual, mesAtual, ultimaDataMes).getDay(),
    ultimaDataDoUltimoMes = new Date(anoAtual, mesAtual, 0).getDate();
    let liTag = "";
    for (let i = primeiroDiaDoMes; i > 0; i--) {
        liTag += `<li class="inactive">${ultimaDataDoUltimoMes - i + 1}</li>`;
    }
    for (let i = 1; i <= ultimaDataMes; i++) {
        
        let hoje = i === date.getDate() && mesAtual === new Date().getMonth() 
                     && anoAtual === new Date().getFullYear() ? "active" : "";
        liTag += `<li class="${hoje}">${i}</li>`;
    }
    for (let i = ultimoDiaDoMes; i < 6; i++) {
        liTag += `<li class="inactive">${i - ultimoDiaDoMes + 1}</li>`
    }
    dataAtual.innerText = `${months[mesAtual]} ${anoAtual}`;
    tagDias.innerHTML = liTag;
}
renderCalendar();
prevNextIcon.forEach(icon => {
    icon.addEventListener("click", () => {
        
        mesAtual = icon.id === "prev" ? mesAtual - 1 : mesAtual + 1;
        if(mesAtual < 0 || mesAtual > 11) {
            
            date = new Date(anoAtual, mesAtual, new Date().getDate());
            anoAtual = date.getFullYear(); 
            mesAtual = date.getMonth();
        } else {
            date = new Date();
        }
        renderCalendar();
    });
});