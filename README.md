# 📅 BusinessAgenda

O **BusinessAgenda** é uma API desenvolvida em .NET com o objetivo de gerenciar agendas comerciais de gerentes e supervisores em uma cooperativa fictícia. Este projeto está sendo criado como parte do meu processo de aprendizado e prática de desenvolvimento web com ASP.NET Core, seguindo boas práticas de arquitetura e organização de código.

---

## 🚀 Tecnologias e Padrões Aplicados

- **ASP.NET Core** (Web API)
- **Entity Framework Core** (persistência e mapeamento)
- **CQRS** (Command Query Responsibility Segregation)
- **Clean Architecture** (camadas bem separadas)
- **MediatR** (desacoplamento entre camadas)
- **AutoMapper** (mapeamento entre entidades e DTOs)

---

## 📚 Funcionalidades

- Criar, cancelar e listar reuniões comerciais (Meetings)
- Gerenciar agendas vinculadas a cada gerente
- Permitir que supervisores visualizem e editem agendas
- Atribuir permissões de acesso via `Skills` (Manager, Supervisor)
- Validação de conflito de horários
- Regras de negócio como duração mínima da reunião (1h)

---

## 📦 Estrutura da Solução

---

## 🛠️ Como rodar o projeto

> Requisitos: [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

```bash
git clone https://github.com/seu-usuario/BusinessAgenda.git
cd BusinessAgenda
dotnet build
dotnet ef database update
dotnet run --project BusinessAgenda.API
