import express, { urlencoded } from 'express'
import cors from 'cors'
import dotenv from 'dotenv'
import routes from './routes.js'

dotenv.config()
const app = express()
const port = process.env.PORT || 3000

app.use(cors({
    origin: '*'
}));
app.use(express.json())
app.use(urlencoded({extended: true}))
app.use(express.static('public'))
app.use('/uploads', express.static('uploads'))
app.use("/api", routes)


//Conexão
app.listen(port, ()=> {
    console.log(`Servidor rodando em: http://localhost:${port}`)
})

