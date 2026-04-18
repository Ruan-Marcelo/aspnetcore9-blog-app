# 📝 SyncSyntax Blog

![.NET](https://img.shields.io/badge/.NET-9.0-purple)
![C#](https://img.shields.io/badge/C%23-Backend-blue)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET-MVC-green)
![Entity Framework](https://img.shields.io/badge/EntityFramework-Core-orange)
![SQL Server](https://img.shields.io/badge/SQL-Server-red)
![Bootstrap](https://img.shields.io/badge/Bootstrap-UI-purple)
![AJAX](https://img.shields.io/badge/AJAX-Dynamic-yellow)

---

## 📌 Sobre o Projeto

O **SyncSyntax Blog** é uma aplicação web completa desenvolvida com **ASP.NET Core MVC**, que permite a criação, edição e gerenciamento de posts com categorias, imagens e comentários dinâmicos.

O projeto foi construído com foco em boas práticas de desenvolvimento backend, integração com banco de dados e experiência do usuário.

---

## 🎯 Funcionalidades

✅ Criar, editar e excluir posts  
✅ Upload de imagens com validação de extensão  
✅ Sistema de categorias  
✅ Comentários dinâmicos com AJAX (sem recarregar a página)  
✅ Filtro de posts por categoria  
✅ Editor de texto avançado com TinyMCE  
✅ Exclusão automática de imagens ao deletar posts  

---

## 🛠️ Tecnologias Utilizadas

### 🔹 Backend
- ASP.NET Core MVC
- C#
- Entity Framework Core

### 🔹 Frontend
- Razor Pages
- Bootstrap
- JavaScript / AJAX
- TinyMCE (editor de texto)

### 🔹 Banco de Dados
- SQL Server

---

## 🧠 Arquitetura do Projeto

O projeto segue o padrão **MVC (Model-View-Controller)**:

- **Models**
  - `Post`
  - `Category`
  - `Comment`

- **ViewModels**
  - `PostViewModel`
  - `EditViewModel`

- **Controllers**
  - `PostController`

---

## 📂 Estrutura do Projeto

A aplicação segue o padrão **MVC (Model-View-Controller)**, com separação clara de responsabilidades:

```
📦 SyncSyntax
 ┣ 📂 Controllers        → Responsável por receber as requisições e controlar o fluxo da aplicação
 ┣ 📂 Models             → Entidades do sistema (Post, Category, Comment)
 ┃ ┗ 📂 ViewModel        → Objetos utilizados para comunicação entre Controller e View
 ┣ 📂 Data               → Contexto do banco de dados (AppDbContext)
 ┣ 📂 Migrations         → Histórico de versões e estrutura do banco (Entity Framework)
 ┣ 📂 Views              → Interfaces da aplicação (Razor Pages)
 ┣ 📂 wwwroot            → Arquivos estáticos (CSS, JS, imagens)
 ┃ ┗ 📂 images           → Armazenamento das imagens enviadas nos posts
```

### 🧠 Organização

* **Controllers** → Contém a lógica de controle e interação com o usuário
* **Models** → Representam os dados e regras de negócio
* **ViewModels** → Evitam acoplamento direto entre View e Model
* **Data** → Configuração do Entity Framework e conexão com banco
* **Views** → Renderização das páginas
* **wwwroot** → Arquivos públicos acessíveis pelo navegador

Essa estrutura facilita a **manutenção, escalabilidade e organização do código**.



---

## ⚙️ Como Executar o Projeto

### 🔹 Pré-requisitos

- .NET 9 SDK
- SQL Server
- Visual Studio ou VS Code

---

### 🔹 Passos

```bash
# Clone o repositório
git clone https://github.com/Ruan-Marcelo/aspnetcore9-blog-app.git

# Acesse a pasta
cd aspnetcore9-blog-app
```

🔹 Configurar conexão com banco

No arquivo appsettings.json, configure:
```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=SyncSyntaxDB;Trusted_Connection=True;"
}
```

🔹 Aplicar migrations
```bash
dotnet ef database update
```

🔹 Rodar o projeto
```bash
dotnet run
```

📸 Imagens do Projeto
<p align="center">
  <img src="../imgs/home.png" width="400"/>
    <img src="../imgs/create.png" width="400"/>
  <img src="../imgs/detail.png" width="400"/>
</p>

⚡ Destaques Técnicos
🔥 Upload de Imagens com Segurança
Validação de extensão (.jpg, .jpeg, .png)
Nome único com GUID
Armazenamento em /wwwroot/images

🔥 Comentários com AJAX
```bash
$.ajax({
    url: '/Post/AddComment',
    type: 'POST',
    contentType: 'application/json',
    data: JSON.stringify(comment),
    success: function(response){
        // Atualiza a UI sem reload
    }
});
```

🔥 Uso de Entity Framework
Relacionamento entre:
Post → Category
Post → Comments
Migrations para controle de banco


📊 Banco de Dados
🧾 Tabelas
Posts
Categories
Comments

Relacionamentos:

1 Categoria → N Posts
1 Post → N Comentários

## 👨‍💻 Autor

**Ruan Marcelo**
Desenvolvedor Full Stack em formação, focado em criar aplicações web modernas e funcionais.

🔗 **GitHub:** https://github.com/Ruan-Marcelo
🌐 **Portfólio:** https://zruanzito.com.br

---

## 🤝 Contribuição

Contribuições são muito bem-vindas! 🚀

Se quiser colaborar com o projeto, você pode:

* 📌 Abrir uma *issue* para sugerir melhorias ou reportar bugs
* 🔧 Enviar um *pull request* com novas funcionalidades ou correções

---

## ⭐ Apoie o projeto

Se este projeto te ajudou de alguma forma, considere deixar uma ⭐ no repositório — isso ajuda bastante na divulgação!



