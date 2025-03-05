import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Sidebar from "./Sidebar";
import Dashboard from "../../pages/dashboard/Dashboard";
import PainelProjetos from "../../pages/projetos/PainelProjetos";

function Rotas() {
    return(
        <div>
            
            <Router> {/* ROUTER responsável por gerenciar a navegação entre as diferentes rotas da aplicação. Ele deve envolver todos os componentes relacionados à navegação, como as rotas e os links. */}
                <Sidebar> {/*Barra lateral, conteúdo da navegação */}
                    <Routes> {/** define todas as rotas */}
                        {/**Rotas */}
                        <Route path="/" element={<Dashboard />} />
                        <Route path="/ListaProjetos" element={<PainelProjetos />} />
                    </Routes>
                </Sidebar>

            </Router>
        </div>
    )
}

export default Rotas;