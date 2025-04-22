document.addEventListener('DOMContentLoaded', () => {
    console.log("DOM totalmente carregado");
    
    const modalInfo = document.getElementById('modalInfo');
    const conteudoModal = document.getElementById('conteudo');

    function exibirModal(evento) {
        conteudoModal.innerHTML = `
            <h2>${evento.nome}</h2>
            <p id="descricao">${evento.descricao}</p>

            <div class="info">
                <h3>Data</h3>
                <h3>Hora Início</h3>
                <h3>Hora Final</h3>
                <h3>Tipo</h3>

                <p>${evento.dataFormatada}</p>
                <p>${evento.horarioInicio}</p>
                <p>${evento.horarioFim}</p>
                <p>${evento.tipo}</p>
            </div>

            <h2>Local</h2>
            <div class="local">
                <div>
                    <h3>CEP</h3>
                    <p>${evento.cep}</p>
                </div>
                <div>
                    <h3>Logradouro</h3>
                    <p>${evento.logradouro}</p>
                </div>
                <div>
                    <h3>Número</h3>
                    <p>${evento.numero}</p>
                </div>
                <div>
                    <h3>Bairro</h3>
                    <p>${evento.bairro}</p>
                </div>
                <div>
                    <h3>Cidade</h3>
                    <p>${evento.cidade}</p>
                </div>
                <div>
                    <h3>Capacidade</h3>
                    <p>${evento.capacidade}</p>
                </div>
            </div>

            <div class="responsavel">
                <h2>Responsável</h2>
                <p>${evento.responsavel}</p>
            </div>

            <div class="botoes">
                <button id="delete">Excluir</button>
                <button id="edit">Editar</button>
                <button id="close">Fechar</button>
            </div>
        `;

        modalInfo.style.display = 'flex';
    }

    document.addEventListener('click', (e) => {
        const cartao = e.target.closest('.cartao-projeto');
        if (cartao && cartao.dataset.evento) {
            try {
                const evento = JSON.parse(cartao.dataset.evento);
                console.log("Evento para exibir:", evento);
                exibirModal(evento);
            } catch (error) {
                console.error("Erro ao analisar dados do evento:", error);
            }
        }
    });

    document.addEventListener('click', async (e) => {
        if (e.target.id === 'delete') {
            const cartao = document.querySelector('.cartao-projeto[data-evento]');
            if (!cartao) return;
            
            const evento = JSON.parse(cartao.dataset.evento);
            const success = await excluirEvento(evento.id);
            if (success) {
                modalInfo.style.display = 'none';
                if (typeof carregarEventos === 'function') {
                    await carregarEventos();
                }
            }
        }

        if (e.target.id === 'edit') {
            const cartao = document.querySelector('.cartao-projeto[data-evento]');
            if (!cartao) return;
            
            const evento = JSON.parse(cartao.dataset.evento);
            modalInfo.style.display = 'none';
            if (typeof abrirEdicaoEvento === 'function') {
                abrirEdicaoEvento(evento);
            } else {
                console.error('Função abrirEdicaoEvento não está disponível');
                window.location.reload();
            }
        }

        if (e.target.id === 'close') {
            modalInfo.style.display = 'none';
        }
    });

    document.addEventListener('click', (e) => {
        if (e.target.classList.contains('fechar-modal1') || e.target === modalInfo) {
            modalInfo.style.display = 'none';
        }
    });

    async function excluirEvento(eventoId) {
        const token = localStorage.getItem('token');
        
        if (!token) {
            alert('Você precisa estar logado para excluir eventos!');
            return false;
        }

        if (!confirm('Tem certeza que deseja excluir este evento?')) {
            return false;
        }

        try {
            const response = await fetch(`http://localhost:3000/api/eventos/${eventoId}`, {
                method: 'DELETE',
                headers: {
                    'Authorization': `Bearer ${token}`
                }
            });

            if (!response.ok) {
                const error = await response.json();
                throw new Error(error.error || 'Erro ao excluir evento');
            }

            const result = await response.json();
            alert(result.message || 'Evento excluído com sucesso!');
            return true;
        } catch (error) {
            console.error('Erro ao excluir evento:', error);
            alert(error.message || 'Erro ao excluir evento');
            return false;
        }
    }
});