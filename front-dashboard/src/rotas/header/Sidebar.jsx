
import { Link } from "react-router-dom";
import './sidebar.css';

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
            <ul>
                {/*links de navegação para diferentes rotas*/}
                <li><Link to="/">dashboard</Link></li>
                <li><Link to="/ListaProjetos">projetos</Link></li>
            </ul>
            </div>
           
    );
};






export default Sidebar;