# Desafio Sprint 3 - Desenvolvimento de APIs .NET

## Sobre o Projeto

Este projeto consiste no desenvolvimento de uma API REST utilizando ASP.NET Core, com autenticação, persistência de dados e arquitetura em camadas.

Além da API, foram implementadas páginas web para cadastro, login e dashboard integradas ao banco de dados.

---

## Tecnologias Utilizadas

- ASP.NET Core Web API
- Entity Framework Core
- JWT (Autenticação)
- Swagger
- MySQL Workbench
- HTML
- Javascript
- Bootstrap

---

## Funcionalidades Implementadas

✅ Cadastro de usuários  
✅ Login de usuários  
✅ Autenticação  
✅ Persistência de dados com MySQL  
✅ Entity Framework Core  
✅ Migrations  
✅ Dashboard após login  
✅ Tabela com usuários cadastrados  
✅ Redirecionamento entre páginas  
✅ Arquitetura em camadas  

---

## Como rodar o projeto

### 1. Clone ou baixe o projeto

Clone:

```bash
git clone https://github.com/xeilongue/BahiaImperial_API.git
```

Ou:

- Clique em **Code**
- Selecione **Download ZIP**
- Extraia o projeto

---

### 2. Configure a conexão

No arquivo:

```json
appsettings.json
```

Configure a string:

```json
"ConnectionStrings": {
   "DefaultConnection":"server=localhost;database=EventHorizon;user=root;password=suaSenha"
}
```

---

### 3. Execute as migrations

Abra o terminal na pasta do projeto:

```bash
Update-Database
```

ou:

```bash
dotnet ef database update
```

Esse comando criará a estrutura do banco automaticamente.

---

### 4. Execute o projeto

```bash
dotnet run
```

Será exibido algo semelhante:

```bash
http://localhost:5248
```

---

### 5. Acesse a aplicação

Abra o endereço HTTP retornado.

Páginas disponíveis:

- Login
- Cadastro

---

## Fluxo da aplicação

### Cadastro

O usuário realiza o cadastro e os dados são salvos no MySQL local.

**Implementado:**

- formulário
- validações
- integração com banco
- Entity Framework

---

### Login

Após o cadastro, o usuário pode realizar login com as mesmas credenciais.

**Implementado:**

- autenticação
- validação
- consulta ao banco

---

### Dashboard

Após login, ocorre redirecionamento automático para a dashboard.

A dashboard exibe uma tabela contendo usuários cadastrados.

**Implementado:**

- redirecionamento
- proteção da rota
- listagem dinâmica
- consulta ao banco
- tabela de usuários

---

## Arquitetura

O projeto segue arquitetura em camadas:

```text
Controllers
    ↓
Services
    ↓
Repositories
    ↓
Entity Framework
    ↓
MySQL
```

Estrutura:

```text
Controllers/
Services/
Repositories/
Models/
DTOs/
Data/
Views/
wwwroot/
```

---

## Instalação dos Pacotes Essenciais

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Swashbuckle.AspNetCore
```