
import { Link } from "react-router-dom";
import './sidebar.css';
import logo from './../../assets/img/logo.png';
import { RxDashboard } from "react-icons/rx";
import { GoProjectRoadmap } from "react-icons/go";
import { VscInspect } from "react-icons/vsc";
import { FiInfo } from "react-icons/fi";

// função navegação. 
function Sidebar ({ children }) { 
    return (
            <div className="sidebar">
            {/*CHILDREN é utilizado para exibir o conteúddo da função corretamente
                ele permite que um componente filho (conteúdo das rotas) seja inserido dentro 
                de um componente pai (Sidebar).

                Sem o uso de children, o Sidebar não tinha um local dinâmico para renderizar o 
                conteúdo das rotas. Ou seja, o conteúdo que o React Router deveria renderizar dentro 
                da div.sidebar não estava sendo passado para o Sidebar.

                O children garante que esse conteúdo seja renderizado dentro da div.sidebar do Sidebar.
            */}
            {children}
            <img src={logo} alt="Logo" className="logo-header"/>
            <ul className="menu-opcoes">
                {/*links de navegação para diferentes rotas*/}
                <li><Link className="link" to="/"><RxDashboard className="icon"/>Dashboard</Link></li>
                <li><Link className="link" to="/ListaProjetos"><GoProjectRoadmap className="icon"/>Projetos</Link></li>
                <li><Link className="link" to="/"><VscInspect className="icon"/>Publicações</Link></li>
                <li><Link className="link" to="/"><FiInfo className="icon"/>Sobre</Link></li>
            </ul>

            
            </div>
           
    );
};






export default Sidebar;