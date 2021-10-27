import logo from './logo.svg';
import './App.css';
import { Component } from 'react';


export default class Home extends Component {
  constructor(props) {
    super(props);
    this.state = {
      listaDesejos: [],
      descricao: '',
      idUsuario: 0
    };
  };


  atualizarDesejo = async (desejo) => {
    await this.setState({ descricao: desejo.target.value })
    console.log(this.state.descricao)
  }
  atualizarID = async (desejo) => {
    await this.setState({ idUsuario: desejo.target.value })
    console.log(this.state.idUsuario)
  }

  buscarDesejos = () => {
    fetch('http://localhost:5000/api/Desejos')
      .then(resposta => resposta.json())

      .then(dados => this.setState({ listaDesejos: dados }))

      .catch(erro => console.log(erro))
  }

  componentDidMount() {
    this.buscarDesejos();

  }

  cadastrarDesejo = (desejo) => {
    desejo.preventDefault();

    fetch('http://localhost:5000/api/Desejos', {

      method: 'POST',
      body: JSON.stringify({ idUsuario: this.state.idUsuario, descricao: this.state.descricao }),
      headers: { "Content-Type": "application/json" }
    })
      .then(console.log("Desejo cadastrado."))

      .catch(erro => console.log(erro))

      .then(this.buscarDesejos)

      .then(this.limparCampos);
  }

  limparCampos = () => {
    this.setState({
      descricao: '',
      idUsuario: ''
    })
    // Exibe no console do navegador a mensagem abaixo
    console.log('Os states foram resetados!')
  };




  render() {
    return (
      <main>
        <div className="background">
          <div className="container">
            <div className="box-titulo">
              <h1 className="titulo" >
                lista de desejos
              </h1>
              <span className="slogan">crie seu proprio desejo</span>
            </div>

            <form onSubmit={this.cadastrarDesejo}>
              <div className="box-text">
                <textarea className="digite-nome" placeholder="Digite seu ID" value={this.state.idUsuario} onChange={this.atualizarID}></textarea>
                <textarea className="digite-desejo" placeholder="Digite seu desejo" value={this.state.descricao} onChange={this.atualizarDesejo}></textarea>
              </div>
              <div className="box-enviar">
                <button className="btn-enviar" type="submit">Cadastrar</button>
              </div>
            </form>
            {
              this.state.listaDesejos.map((retorno) => {
                return (
                  <section className="container-desejos">
                    <div className="box-desejos">
                      <div className="box-informacao">
                        <span className="span-desejo">ID: {retorno.idUsuario}</span>
                      </div>
                      <div className="box-desejo">
                        <span className="span-desejo">Desejo: {retorno.descricao}</span>
                      </div>
                    </div>
                  </section>
                )
              })
            }
          </div>
        </div>
      </main>
    )
  }
}
