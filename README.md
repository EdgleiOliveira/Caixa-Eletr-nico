# Caixa Eletrônico — API + Frontend

Este é um projeto completo de **Caixa Eletrônico**, contendo uma **API construída em .NET** e um **frontend em HTML/CSS/JS**.

O objetivo é simular operações bancárias básicas:

* Login usando PIN
* Consulta de saldo
* Saque

---

## Tecnologias Utilizadas

### **Backend (API)**

* **.NET 8 Minimal API**
* **C#**
* Rotas HTTP
* CORS liberado

### **Frontend**

* **HTML5**
* **CSS3** (estilo inspirado no app Santander)
* **JavaScript (Fetch API)**

---

## Estrutura do Projeto

```
 Root
 ┣  CaixaEletronicoApi
 ┣  frontend
 ┣  CaixaApi.sln
 ┗  README.md
```

---

## Como Rodar o Projeto

### **1️ Rodar a API**

```
cd CaixaEletronicoApi

# executar a API
dotnet run
```

A API iniciará em:

```
http://localhost:5027
```

---

### **2️ Rodar o Frontend**

Abra o arquivo:

```
frontend/index.html
```

Pode abrir direto no navegador.

---

## Rotas da API

### **Login**

```
GET /login?pin=1234
```

### **Saldo**

```
GET /saldo
```

### **Saque**

```
POST /sacar/{valor}
```

---

## Funcionalidades Futuras (sugestões)

* Extrato bancário
* Depósito
* Transferências
* Sistema de usuários
* Integração com banco de dados

---

## Autor

Projeto criado para estudo de APIs, frontend e integração Git/GitHub.

---
