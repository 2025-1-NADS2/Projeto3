class GerenciadorModal {
    constructor(modalId, botaoAbrirId) {
        this.modal = document.getElementById(modalId);
        this.botaoAbrir = document.querySelector(botaoAbrirId);
        this.botaoFechar = this.modal.querySelector('.fechar-modal');
        this.botaoCancelar = this.modal.querySelector('.botao-cancelar');
        this.formulario = this.modal.querySelector('form');
        this.modoEdicao = false;
        this.eventoAtual = null;

        this.inicializar();
    }

    inicializar() {
        if (this.botaoAbrir) {
            this.botaoAbrir.addEventListener('click', () => this.abrir());
        }

        this.botaoFechar.addEventListener('click', () => this.fechar());
        this.botaoCancelar.addEventListener('click', () => this.fechar());

        this.modal.addEventListener('click', (e) => {
            if (e.target === this.modal) {
                this.fechar();
            }
        });

        this.formulario.addEventListener('submit', (e) => this.manipularEnvio(e));
    }

    abrir(edicao = false, evento = null) {
        this.modoEdicao = edicao;
        this.eventoAtual = evento;
        
        if (edicao && evento) {
            this.preencherFormulario(evento);
            this.modal.querySelector('.modal-cabecalho h2').textContent = 'Editar Evento';
        } else {
            this.formulario.reset();
            this.modal.querySelector('.modal-cabecalho h2').textContent = 'Novo Evento';
        }
        
        this.modal.classList.add('ativo');
    }

    fechar() {
        this.modal.classList.remove('ativo');
        this.modoEdicao = false;
        this.eventoAtual = null;
    }

    preencherFormulario(evento) {
        document.getElementById('nomeEvento').value = evento.nome || '';
        document.getElementById('options').value = evento.tipo || '';
        document.getElementById('descricaoEvento').value = evento.descricao || '';

        const dataParts = evento.dataFormatada?.split('/') || [];
        const dataFormatada = dataParts.length === 3 
            ? `${dataParts[2]}-${dataParts[1].padStart(2, '0')}-${dataParts[0].padStart(2, '0')}`
            : '';
        document.getElementById('dataInicioEvento').value = dataFormatada;
        
        document.getElementById('horaInicio').value = evento.horarioInicio || '';
        document.getElementById('horaFinal').value = evento.horarioFim || '';
        document.getElementById('cep').value = evento.cep || '';
        document.getElementById('logradouro').value = evento.logradouro || '';
        document.getElementById('numero').value = evento.numero || '';
        document.getElementById('bairro').value = evento.bairro || '';
        document.getElementById('cidade').value = evento.cidade || '';
        document.getElementById('capacidade').value = evento.capacidade || '';
        document.getElementById('responsavel').value = evento.responsavel || '';
        
        document.getElementById('banner').required = !this.modoEdicao;
    }

    async manipularEnvio(evento) {
        evento.preventDefault();
        
        const dados = {
            nome: document.getElementById('nomeEvento').value,
            tipo: document.getElementById('options').value,
            descricao: document.getElementById('descricaoEvento').value,
            dataI: document.getElementById('dataInicioEvento').value,
            horaI: document.getElementById('horaInicio').value,
            horaF: document.getElementById('horaFinal').value,
            cep: document.getElementById('cep').value,
            logradouro: document.getElementById('logradouro').value,
            numero: document.getElementById('numero').value,
            bairro: document.getElementById('bairro').value,
            cidade: document.getElementById('cidade').value,
            capacidade: document.getElementById('capacidade').value,
            responsavel: document.getElementById('responsavel').value
        };

        try {
            const token = localStorage.getItem('token');
            if (!token) throw new Error('Você precisa estar logado!');

            // Upload da imagem se houver
            let imagemId = null;
            const file = document.getElementById('banner').files[0];
            if (file) {
                if (!file.type.match('image.*')) throw new Error('Apenas imagens são permitidas!');
                
                const formDataImg = new FormData();
                formDataImg.append('image', file);
                
                const uploadResponse = await fetch('http://localhost:3000/api/images', {
                    method: 'POST',
                    body: formDataImg
                });
                
                if (!uploadResponse.ok) throw new Error('Falha ao enviar imagem');
                imagemId = (await uploadResponse.json()).id;
            }

            const url = this.modoEdicao 
                ? `http://localhost:3000/api/eventos/${this.eventoAtual.id}`
                : 'http://localhost:3000/api/eventos';
                
            const method = this.modoEdicao ? 'PUT' : 'POST';

            const response = await fetch(url, {
                method,
                headers: { 
                    'Authorization': `Bearer ${token}`,
                    'Content-Type': 'application/json' 
                },
                body: JSON.stringify({ ...dados, imagemId })
            });

            if (!response.ok) {
                const error = await response.json();
                throw new Error(error.error || 'Erro ao salvar evento');
            }

            const result = await response.json();
            alert(result.message || (this.modoEdicao ? 'Evento atualizado com sucesso!' : 'Evento criado com sucesso!'));
            
            this.fechar();
            if (typeof carregarEventos === 'function') {
                await carregarEventos();
            }
        } catch (error) {
            console.error('Erro:', error);
            alert(error.message || "Erro ao salvar. Verifique os dados e tente novamente.");
        }
        window.abrirEdicaoEvento = function(evento) {
            if (typeof modalEvento !== 'undefined') {
                this.modal.abrir(true, evento);
            } else {
                console.error('Modal de eventos não foi inicializado corretamente');
            }
        };
    }
}

const modalEvento = new GerenciadorModal('modalEvento', '.novo-evento');

