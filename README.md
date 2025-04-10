# Estacionamento .NET Console

Projeto simples de um sistema de estacionamento, desenvolvido em **C#** com aplicação de console.  
Permite cadastrar, listar e remover veículos, além de calcular o valor a pagar com base nas horas estacionadas.

---

## 🚗 Funcionalidades

- Adicionar veículo ao estacionamento
- Listar veículos estacionados
- Remover veículo do estacionamento
  - Cálculo do valor total baseado nas horas
  - Verificação se o veículo está cadastrado
- Impede o cadastro de placas duplicadas

---

## 🛠️ Tecnologias

- C#
- .NET (Console Application)
- Visual Studio 2022

---

## 📦 Como usar

1. Clone o repositório:
git clone https://github.com/algoritmona/Estacionamento.git
- Abra o projeto com o Visual Studio ou VS Code
- Compile e execute o projeto

## 💰 Cálculo do valor
O valor total é calculado assim:
valorTotal = precoInicial + (precoPorHora * horas);

## 💡 Exemplo de uso
- Digite a placa do veículo para estacionar: ABC1234
- Digite a placa do veículo para remover: ABC1234
- Digite a quantidade de horas que o veículo permaneceu estacionado: 3
- O veículo ABC1234 foi removido e o preço total foi de: R$ 35.00

## 📁 Estrutura do projeto
- Estacionamento.cs → Lógica principal do estacionamento
- Program.cs → Interface do console (menu e interação)
