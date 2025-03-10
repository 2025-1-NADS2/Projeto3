import BuscaProjetos from './BuscaProjetos';
import './css/ListaProjetos.css'
import ListaProjetos from './ListaProjetos';
import NovoProjeto from './NovoProjeto';

function PainelProjetos(){

    return(
        <div className="painel-projetos">
            <BuscaProjetos/>
            <NovoProjeto/>
            <ListaProjetos/>
        </div>
    )
}

export default PainelProjetos;