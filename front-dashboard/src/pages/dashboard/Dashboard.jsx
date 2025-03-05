import BuscaProjetos from '../projetos/BuscaProjetos';
import ListaProjetos from '../projetos/ListaProjetos';
import NovoProjeto from '../projetos/NovoProjeto';
import './dashboard.css'
function Dashboard(){

    return(
        <div className="dashboard">
            
            

            <div className="lista">
                <BuscaProjetos/>
                <NovoProjeto/>
                <ListaProjetos/>
            </div>
            <aside className="info-mais"></aside>

            <section className="calendario">
                <p>aaaa</p>
            </section>

        <div className="div-info-colaboradores">
            <aside>
                <p>colaboradores</p>
            </aside>
            <article>
                <p>47</p>
            </article>
        </div>

        <div className='div-info-graficos'>
            <section className='grafico-projetos'>
                <p>aaaaaaa</p>
            </section>

            <article>
                <p>1</p>
            </article>
            <article>
                <p>2</p>
            </article>
            <article>
                <p>3</p>
            </article>
        </div>

        
            
            

           
        </div>  
    )
}

export default Dashboard;