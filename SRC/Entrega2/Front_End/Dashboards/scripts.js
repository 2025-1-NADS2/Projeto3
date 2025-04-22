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
            height: 180,
            width: 180
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
            height: 180,
            width: 180
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
    const grafico3 = new ApexCharts(document.querySelector('#grafico3'), opcoesGrafico1);
    const grafico4 = new ApexCharts(document.querySelector('#grafico4'), opcoesGrafico2);
    const grafico5 = new ApexCharts(document.querySelector('#grafico5'), opcoesGrafico1);
    const grafico6 = new ApexCharts(document.querySelector('#grafico6'), opcoesGrafico2);

    grafico1.render();
    grafico2.render();
    grafico3.render();
    grafico4.render();
    grafico5.render();
    grafico6.render();
}

var opcoesBarra = {
    series: [{
    name: 'PRODUCT A',
    data: [44, 55, 41, 67, 22, 43]
  }],
    chart: {
    type: 'bar',
    height: 350,
    stacked: true,
    toolbar: {
      show: true
    },
    zoom: {
      enabled: true
    }
  },
  responsive: [{
    breakpoint: 480,
    options: {
      legend: {
        position: 'bottom',
        offsetX: -10,
        offsetY: 0
      }
    }
  }],
  colors: ['#72A603'],
  plotOptions: {
    bar: {
      horizontal: false,
      borderRadius: 10,
      borderRadiusApplication: 'end',
      borderRadiusWhenStacked: 'last',
      dataLabels: {
        total: {
          enabled: true,
          style: {
            fontSize: '13px',
            fontWeight: 900
          }
        }
      }
    },
  },
  xaxis: {
    type: 'datetime',
    categories: ['01/01/2011 GMT', '01/02/2011 GMT', '01/03/2011 GMT', '01/04/2011 GMT',
      '01/05/2011 GMT', '01/06/2011 GMT'
    ],
  },
  legend: {
    position: 'right',
    offsetY: 40
  },
  fill: {
    opacity: 1
  }
  };

  const grafico7 = new ApexCharts(document.querySelector('#grafico7'), opcoesBarra);
  grafico7.render();


function atualizarTemaGraficos(modoEscuro) {
}

document.addEventListener('DOMContentLoaded', () => {
    inicializarGraficos();
});

window.addEventListener('resize', () => {
    if (window.innerWidth > 768) {
        sidebar.classList.remove('active');
    }
});

const botaoNovoEvento = document.querySelector('.novo-evento');
const modalEvento = document.getElementById('modalEvento');

if (botaoNovoEvento && modalEvento) {
    botaoNovoEvento.addEventListener('click', () => {
        modalEvento.style.display = 'flex';
    });
    
    document.querySelector('.fechar-modal').addEventListener('click', () => {
        modalEvento.style.display = 'none';
    });
}



