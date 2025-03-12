// chama os itens da modal
class GerenciadorModal {
    constructor(modalId, botaoAbrirId) {
        this.modal = document.getElementById(modalId);
        this.botaoAbrir = document.querySelector(botaoAbrirId);
        this.botaoFechar = this.modal.querySelector('.fechar-modal');
        this.botaoCancelar = this.modal.querySelector('.botao-cancelar');
        this.formulario = this.modal.querySelector('form');

        this.inicializar();
    }

    inicializar() {
        
        this.botaoAbrir.addEventListener('click', () => this.abrir());

        this.botaoFechar.addEventListener('click', () => this.fechar());
        this.botaoCancelar.addEventListener('click', () => this.fechar());

        this.modal.addEventListener('click', (e) => {
            if (e.target === this.modal) {
                this.fechar();
            }
        });

        this.formulario.addEventListener('submit', (e) => this.manipularEnvio(e));
    }

    abrir() {
        this.modal.classList.add('ativo');
        this.formulario.reset();
    }

    fechar() {
        this.modal.classList.remove('ativo');
    }

    manipularEnvio(evento) {
        evento.preventDefault();
        
        const dados = {};
        const campos = this.formulario.querySelectorAll('input, textarea');
        campos.forEach(campo => {
            dados[campo.id] = campo.value;
        });

        console.log('Dados do formulário:', dados);

        this.fechar();
    }
}

document.addEventListener('DOMContentLoaded', () => {
    const modalEvento = new GerenciadorModal('modalEvento', '.novo-evento');
    const modalAtividade = new GerenciadorModal('modalAtividade', '.nova-atividade');
});