import { FaSearch } from "react-icons/fa";
import './css/BuscaProjetos.css';

function BuscaProjetos(){
    return(
        <div className="search">
            <button className="bt-search"><FaSearch /></button>
            <input className="input-search" placeholder="Buscar projeto"/>
        </div>
    )
}

export default BuscaProjetos;