import React from 'react';
import { useState } from 'react'

import axios from 'axios';

import { ClockCircleOutlined, Html5Outlined,  CheckSquareOutlined, DownOutlined, CaretUpOutlined, CaretDownOutlined} from '@ant-design/icons';
import {PageHeader, Button, Input, Space, List, Dropdown, Menu, Checkbox, Radio, DatePicker, Progress, Slider, Card, Row, Col, Timeline} from 'antd'

import 'antd/dist/antd.css';

function Mix(){
  
  const [nome, setNome] = useState("");
  const [titulo, setTitulo] = useState("");
  const [trabalhos, setTrabalhos] = useState([]);
  const [trabalhosDoAluno, setTrabalhosDoAluno] = useState([]);
  const [inputsAlocar, setInputsAlocar] = useState([]);

  const criarUsuario = () => {
    const dados = {"username": nome};
    axios.post("https://trabalho-react.glitch.me/aluno", dados).then((res) => {
        if (res.status == 200) {
         console.log(res.data);
         alert('sucesso! você está logado até seu browser fechar');
         sessionStorage.setItem("nomeSessao", nome)
        }
        }).catch ((err) => {
         console.log('ERRO: ', err);
        })
  }

  const criarTrabalho = () => {
    const dados = {"titulo": titulo};
    axios.post("https://trabalho-react.glitch.me/trabalho", dados).then((res) => {
        if (res.status == 200) {
         console.log(res.data)
        }
        }).catch ((err) => {
         console.log('ERRO: ', err);
        })
  }

  const obterTrabalhos = () => {
    axios.get('https://trabalho-react.glitch.me/trabalho').then(
      res => {
        let temp = [];
        let tempp = [];
        console.log(res.data);
        res.data.forEach( (item, index) => { temp.push({index: index, id: item.id, titulo: item.titulo, percentual: item.percentual}); tempp.push("");} );
        setTrabalhos(temp);
        setInputsAlocar(tempp);
        console.log(trabalhos);
      }
    );
  }

  const atualizarTrabalho = (id, percentual) => {
    axios.put(`https://trabalho-react.glitch.me/trabalho/percentual/${id}/${percentual}`, {}).then(
      res => {
        if (res.status == 200) {
          console.log(res.data)
          let i = 0;
          let temp = [];
          while(res.data > i){
            temp.push(res.data[i].percentual);
            i++;
          }
          setInputsAlocar();
         }
         }).catch ((err) => {
          console.log('ERRO: ', err);
         })
  };

  const alocarAluno = (id, nomeDoAluno) => {
    axios.put(`https://trabalho-react.glitch.me/alocacao/${id}/${nomeDoAluno}`, {}).then(
      res => {
        if (res.status == 200) {
          console.log(res.data)
         }
         }).catch ((err) => {
          console.log('ERRO: ', err);
         })
  };

  const obterTrabalhosDoAluno = () => {
    axios.get('https://trabalho-react.glitch.me/alocacao').then(
      res => {
        console.log("res data:");
        console.log(res.data);
        let temp = [];
        let i = 0;
        let j = 0;
        while(res.data.length > i){
          console.log("res data "+i);
          console.log(res.data[i]);
          if(sessionStorage.nomeSessao == res.data[i].idAluno){
            while(j < trabalhos.length){
              if(trabalhos[j].id == res.data[i].idTrabalho){
                break;
              }
              j++;
            }
            temp.push({id: res.data[i].idTrabalho, percentual: trabalhos[j].percentual});
            console.log(res.data[i].idTrabalho, trabalhos[j].percentual);
          }
          i++;
        }
        setTrabalhosDoAluno(temp);
        console.log(temp);
        
      }
    );
  }

  return <div id="sbody">
    <div className="sbody-component">
    <Input className="sbody-subcomponent" addonBefore="Nome do aluno:" placeholder="Informe aqui o nome completo do aluno" 
            value={nome}
            onChange={(e) => {
              console.log(e.target.value);
              setNome(e.target.value);}}/>
    <Button className="sbody-subcomponent" type="primary" onClick={criarUsuario}>Criar Usuario</Button>
    </div>
    <div className="sbody-component">
    <Input className="sbody-subcomponent" addonBefore="Título do trabalho:" placeholder="Informe aqui o título" 
            value={titulo}
            onChange={(e) => {
              console.log(e.target.value);
              setTitulo(e.target.value);}}/>
    <Button className="sbody-subcomponent" type="primary" onClick={criarTrabalho}>Criar Trabalho</Button>
    </div>
    
    <div className="sbody-component">
    <List className="sbody-subcomponent" bordered header={<div>Atualizar Trabalhos</div>} 
            dataSource={trabalhos}
            renderItem={(item, index) => (<>
            <List.Item id={index}>{"Título: " + item.titulo + " || ID: " + item.id}
            <Input addonBefore="Percentual:" placeholder="Informe o percentual completado do trabalho" onChange={(e) => {
              console.log(e.target.value);
              console.log(index);
              let temparray = trabalhos;
              temparray[index].percentual = e.target.value;
              setTrabalhos(temparray);}} />
            <Button onClick={() => {atualizarTrabalho(trabalhos[index].id, trabalhos[index].percentual);}}>Atualizar Percentual</Button>
            <br /><br />
            <Input addonBefore="Nome do aluno:" placeholder="Informe aqui o nome completo do aluno" onChange={(e) => {
              let temp = inputsAlocar;
              temp[index] = e.target.value;
              setInputsAlocar(temp);
            }}/>
            <Button onClick={() => {alocarAluno(trabalhos[index].id, inputsAlocar[index]);}}>Alocar Aluno</Button>
            <br /><br />
            </List.Item>
            </>)}
    />
    <Button className="sbody-subcomponent" type="primary" onClick={obterTrabalhos}>Obter Trabalhos</Button>
    </div>

    <div className="sbody-component">
    <List dataSource={trabalhosDoAluno} bordered header={<div>Dashboard</div>}
        renderItem={(item, index) => (<List.Item>{item.id + " || percentual: " + item.percentual + "%"}</List.Item>)}
    />
    <Button className="sbody-subcomponent" type="primary" onClick={obterTrabalhosDoAluno}>Obter Trabalhos do {sessionStorage.nomeSessao}</Button>
    </div>
  </div>;
}













function App() {
  const [variavel, setVariavel] = useState("");

  const obterAlunos = () => {
    axios.get('https://trabalho-react.glitch.me/aluno').then(
      res => {
        console.log(res.data);
        res.data.forEach(
          (item, index) => {
            setVariavel(variavel + "<br>" + index + ": " + item.id);
          });
      }
    );
  } 

  const cadastrarAlunos = () => {
    axios.post('https://trabalho-react.glitch.me/aluno', {"username": "thefirstjooj"}).then(
      res => {
        console.log(res);
      }
    );
  }
  
  return (
    <>
    <h1>Obter Alunos</h1>
    <div className="obterAlunos">
      <Button id="botao" type="primary" onClick={() => this.obterAlunos()}>Fazer requisição dos alunos</Button>
      <span id="espam">{"safsafdas"}</span>
    </div>
    <br />
    <br />
    <br />
    <h1>Cadastrar Aluno</h1>
    <div className="cadastrarAluno">
      <Input value="jooj"></Input>
      <Button id="botao" type="primary" onClick={() => this.cadastrarAlunos()}>Fazer requisição dos alunos</Button>
      <span id="espam"></span>
    </div>
    </>
  );
}

export default Mix;