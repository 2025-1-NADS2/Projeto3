// manipulando o DOM
const sidebar = document.getElementById('sidebar');
const abrirSidebar = document.getElementById('abrirSidebar');
const fecharSidebar = document.getElementById('fecharSidebar');
const temaToggle = document.getElementById('temaToggle');
const temaIcon = temaToggle.querySelector('.tema-icon');

// mudando o tema
let modoEscuro = false;

function alternarTema() {
    modoEscuro = !modoEscuro;
    document.documentElement.setAttribute('data-theme', modoEscuro ? 'dark' : 'light');
    temaIcon.textContent = modoEscuro ? '🌞' : '🌙';
    atualizarTemaGraficos(modoEscuro);
}

temaToggle.addEventListener('click', alternarTema);

// abrir e fechar sidebar
function abrirMenuLateral() {
    sidebar.classList.add('active');
}

function fecharMenuLateral() {
    sidebar.classList.remove('active');
}

abrirSidebar.addEventListener('click', abrirMenuLateral);
fecharSidebar.addEventListener('click', fecharMenuLateral);

function inicializarGraficos() {
    // gráfico 1
    const opcoesGrafico1 = {
        series: [17, 80],
        chart: {
            type: 'donut',
            height: 200
        },
        responsive: [{
            breakpoint: 480,
            options: {
                chart: {
                    width: 200
                },
                legend: {
                    position: 'bottom'
                }
            }
        }],
        fill: {
            colors: ['#FFE910', '#FF254A']
        },
        legend: {
            show: false
        }
    };

    // gráfico 2
    const opcoesGrafico2 = {
        series: [45, 55],
        chart: {
            type: 'donut',
            height: 200
        },
        responsive: [{
            breakpoint: 480,
            options: {
                chart: {
                    width: 200
                },
                legend: {
                    position: 'bottom'
                }
            }
        }],
        fill: {
            colors: ['#93F205', '#1CEAE4']
        },
        legend: {
            show: false
        }
    };

    // inicializar gráficos
    const grafico1 = new ApexCharts(document.querySelector('#grafico1'), opcoesGrafico1);
    const grafico2 = new ApexCharts(document.querySelector('#grafico2'), opcoesGrafico2);

    grafico1.render();
    grafico2.render();
}


function atualizarTemaGraficos(modoEscuro) {
}

document.addEventListener('DOMContentLoaded', () => {
    inicializarGraficos();
});

// se a tela for maior que 768 a sidebar fica ativa
window.addEventListener('resize', () => {
    if (window.innerWidth > 768) {
        sidebar.classList.remove('active');
    }
});


const botaoNovoEvento = document.querySelector('.novo-evento');
const botaoNovaAtividade = document.querySelector('.nova-atividade');

botaoNovoEvento.addEventListener('click', () => {
    console.log('Novo evento clicado');
});

botaoNovaAtividade.addEventListener('click', () => {
    console.log('Nova atividade clicada');
});