# Trybank

Bem-vindo ao repositório do **Trybank**, um projeto criado como parte do meu aprendizado na [Trybe](https://www.betrybe.com/).

## Descrição do Projeto

O Trybank é uma aplicação simples que simula funcionalidades básicas de um banco. Ele permite o cadastro de contas, login, logout, checagem de saldo, depósito, saque e transferência de dinheiro entre contas. O projeto foi desenvolvido em C# e todos os dados são armazenados temporariamente em memória usando arrays multidimensionais.

## Funcionalidades

- Cadastro de novas contas bancárias
- Login e logout de usuários
- Verificação de saldo
- Depósito de dinheiro em conta
- Saque de dinheiro da conta
- Transferência de saldo entre contas

## Tecnologias Utilizadas

- C#
- .NET Core

## Como Executar o Projeto

### Pré-requisitos

- .NET Core SDK instalado

### Passos para execução

1. Clone o repositório:
    ```bash
    git clone https://github.com/seu-usuario/nome-do-repositorio.git
    ```

2. Entre no diretório do projeto:
    ```bash
    cd nome-do-repositorio
    ```

3. Restaure as dependências:
    ```bash
    dotnet restore
    ```

4. Execute o projeto:
    ```bash
    dotnet run --project src/trybank
    ```

5. Execute os testes:
    ```bash
    dotnet test
    ```

## Estrutura do Projeto

O projeto segue a seguinte estrutura:

```bash
src/
├── Trybank.cs    # Contém a lógica principal da aplicação
├── Trybank.Test/ # Contém os testes da aplicação
