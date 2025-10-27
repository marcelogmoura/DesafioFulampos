# 🕵️ Desafio do Detetive: Verificação de Notas Roubadas (API C#)

## 🎯 Objetivo do Desafio

O objetivo deste projeto é desenvolver a lógica para identificar, no menor tempo possível, se uma carteira de suspeito contém **duas notas** que somadas resultam em **150 fulampos** (o valor roubado).

A solução foi implementada como uma **API RESTful em C# (.NET 8/ASP.NET Core)** e empacotada em um **Contêiner Docker** para fácil distribuição.

## 📋 Requisitos e Documentação

Os requisitos completos do teste técnico (prova) estão detalhados no documento oficial:
* **[Enunciado.pdf](https://github.com/marcelogmoura/DesafioFulampos/blob/main/Desafio/enunciado.pdf)**

## 💻 Solução Técnica e Algoritmo

### Algoritmo: Dois Ponteiros (Two Pointers)

A abordagem escolhida para resolver o problema é a técnica de **Dois Ponteiros** (*Two Pointers*), que é ideal para busca de pares em coleções **ordenadas**.

- **Estrutura:** A API utiliza uma arquitetura em camadas (`Aplicacao`, `Domain`, `Infra`) para separar as responsabilidades e garantir a manutenibilidade do código.
- **Lógica:** O algoritmo usa dois ponteiros (`esquerda` e `direita`) nas extremidades do *array* de notas. A cada iteração, ele ajusta um dos ponteiros com base na soma atual:
  - Se a soma for **menor** que 150, o ponteiro `esquerda` avança (busca por uma nota maior).
  - Se a soma for **maior** que 150, o ponteiro `direita` recua (busca por uma nota menor).
  - Se a soma for **igual a 150**, o algoritmo retorna `TRUE` e encerra.

### Complexidade de Tempo

A complexidade de tempo da solução é **O(n)** (Linear).

Esta é a solução mais eficiente porque o algoritmo percorre a lista de notas no máximo uma vez, tornando o tempo de execução diretamente proporcional ao número de itens (\(n\)) na carteira.

## 🚀 Como Executar o Projeto (Usando Docker)

Certifique-se de ter o **Docker Desktop** instalado e em execução.

### 1. Buildar a Imagem Docker

Navegue até a **raiz da solução** (`\Desafio`), onde estão o `Dockerfile` e o `.dockerignore`, e execute o comando de *build*:

```bash
docker build -t desafio-detetive:v1 .
```


### 2. Rodar o Contêiner

Execute a imagem recém-criada, mapeando a porta 8000 da sua máquina para a porta 8080 do contêiner:

```bash
docker run -d -p 8000:8080 --name detetive-app desafio-detetive:v1
```


### 3. Testar a API

A API estará rodando no Docker. Acesse o Swagger para testar o endpoint e os casos de teste:

URL do Swagger: http://localhost:8000/swagger

## 🔍 Endpoint da API

| Método | URL                    | Descrição                                               |
|--------|------------------------|---------------------------------------------------------|
| POST   | /Investigacao/suspeito | Verifica se a carteira possui duas notas que somam 150 fulampos. |

### Exemplo de Requisição (JSON)

```bash
{
"notas":
}
```


## ⚖️ Casos de Teste

| Caso   | Notas                          | Resultado Esperado |
|--------|--------------------------------|--------------------|
| Caso 1 | [10, 20, 50, 70, 80, 100, 150] | TRUE               |
| Caso 2 | [5, 25, 50, 100, 200]           | TRUE               |
| Caso 3 | [1, 2, 3, 147, 148, 149]        | TRUE               |

![Resultado dos testes no Swagger](https://i.postimg.cc/Dw1Z9Zx8/Screenshot-2.jpg)

![Resultado dos testes no Swagger](https://i.postimg.cc/s2yXsrLg/Screenshot-3.jpg)

![Resultado dos testes no Swagger](https://i.postimg.cc/5t10bVrN/Screenshot-4.jpg)


---


👨‍💻 **Autor:** Marcelo Moura 

📧 **Email:** [mgmoura@gmail.com](mailto:mgmoura@gmail.com)   
📧 **Email:** [admin@allriders.com.br](mailto:admin@allriders.com.br)   
🐱 **GitHub:** [github.com/marcelogmoura](https://github.com/marcelogmoura)   
🔗 **LinkedIn:** [linkedin.com/in/marcelogmoura](https://www.linkedin.com/in/marcelogmoura/)   
