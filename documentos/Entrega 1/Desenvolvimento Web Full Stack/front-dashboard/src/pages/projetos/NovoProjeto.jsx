import './css/NovoProjeto.css'
import ReactModal from "react-modal";
import Modal from "react-modal";
import { useState } from "react";

function NovoProjeto(){

    // Criando uma modal para criar novos projetos
    // variaveis para modal, iniciando com false para manter fechado
    const [modalAberta, setModalAberta] = useState(false);

    // Função para abrir a modal quando clicar no botão
    function abrirModal() {
        setModalAberta(true);
    }

    // Função para fechar a modal quando clicar no botão
    function fecharModal() {
        setModalAberta(false)
    }

    // Estilo da modal
    const styleModal = {
        content: {
            top: '50%',
            left: '50%',
            right: 'auto',
            bottom: 'auto',
            marginRight: '-50%',
            height: '270px',
            width: '350px',
            borderRadius: '25px',
            transform: 'translate(-50%,-50% )'
        }
    }



    return(
        <div className="criacao-projeto">
            <button type='button' onClick={abrirModal} className="bt-novo-projeto">+ NOVO PROJETO</button>

            <button className='bt-nova-atividade'>+ NOVA ATIVIDADE</button>

            {/** Chamando a Modal  */}
            <ReactModal style={styleModal} isOpen={modalAberta} onRequestClose={fecharModal} ariaHideApp={false}>
                <p>MODAL</p>
                <button type='button' className='close-modal' onClick={fecharModal}>X</button>
            </ReactModal>

        </div>
    )
}

export default NovoProjeto;