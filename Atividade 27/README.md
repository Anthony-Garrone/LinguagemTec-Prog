# Sistema de Cadastro de Bandas

Sistema desktop desenvolvido em C# Windows Forms para gerenciamento e cadastro de bandas musicais.

## 📋 Descrição

Este projeto é um sistema de cadastro que permite gerenciar informações sobre bandas musicais, incluindo nome, número de integrantes, ranking e gênero musical. O sistema utiliza MySQL como banco de dados e oferece uma interface gráfica intuitiva para cadastro e busca de informações.

## 🚀 Tecnologias Utilizadas

- **C# (.NET Framework)** - Linguagem de programação
- **Windows Forms** - Framework para interface gráfica
- **MySQL 8.1.0** - Sistema de gerenciamento de banco de dados
- **ADO.NET** - Acesso a dados
- **Visual Studio** - IDE de desenvolvimento

## 📦 Dependências

O projeto utiliza as seguintes bibliotecas NuGet:

- MySql.Data 8.1.0


## 🗄️ Estrutura do Banco de Dados

O sistema utiliza duas tabelas principais:

### Tabela `generos`
- `idgenero` (INT, AUTO_INCREMENT, PRIMARY KEY)
- `genero` (VARCHAR(45))

Gêneros pré-cadastrados: Rock, Metal, Pagode, Gospel, Funk

### Tabela `bandas`
- `idbandas` (INT, AUTO_INCREMENT, PRIMARY KEY)
- `nome` (VARCHAR(45))
- `integrantes` (INT)
- `ranking` (INT)
- `fk_genero` (INT, FOREIGN KEY)

### Stored Procedures

- `sp_insereBanda` - Insere uma nova banda no banco
- `sp_listaBandas` - Lista todas as bandas com seus gêneros
- `sp_listaGeneros` - Lista todos os gêneros disponíveis

## ⚙️ Instalação e Configuração

### Pré-requisitos

- Visual Studio 2019 ou superior
- MySQL Server 8.0 ou superior
- .NET Framework 4.7.2 ou superior

### Passo a Passo

1. **Clone o repositório**
   ```bash
   git clone <url-do-repositorio>
   cd "Semana 12 - Projeto CSharp - Modelo"
   ```

2. **Configure o Banco de Dados**
   - Abra o MySQL Workbench ou outro cliente MySQL
   - Execute o script `DumpBancoCadastro.sql` para criar as tabelas e procedures
   ```sql
   source DumpBancoCadastro.sql
   ```

3. **Configure a String de Conexão**
   - Abra o arquivo `App.config` no projeto SistemaCadastro
   - Atualize a string de conexão com suas credenciais do MySQL
   ```xml
   <connectionStrings>
     <add name="MySqlConnection" 
          connectionString="Server=localhost;Database=cadastro;Uid=root;Pwd=sua_senha;" 
          providerName="MySql.Data.MySqlClient"/>
   </connectionStrings>
   ```

4. **Restaure os Pacotes NuGet**
   - No Visual Studio, clique com o botão direito na solução
   - Selecione "Restore NuGet Packages"

5. **Compile e Execute**
   - Pressione `F5` ou clique em "Start" no Visual Studio

## 🎯 Funcionalidades

- ✅ **Cadastro de Bandas** - Adicione novas bandas com informações completas
- 🔍 **Busca de Bandas** - Pesquise bandas cadastradas
- 📝 **Alteração de Dados** - Edite informações de bandas existentes
- 🗑️ **Remoção de Bandas** - Exclua registros do sistema
- 🎵 **Gerenciamento de Gêneros** - Adicione novos gêneros musicais
- 📊 **Visualização em Lista** - Veja todas as bandas cadastradas

## 📁 Estrutura do Projeto

```
SistemaCadastro/
├── Program.cs              # Ponto de entrada da aplicação
├── Sistema.cs              # Lógica principal do formulário
├── Sistema.Designer.cs     # Designer do Windows Forms
├── App.config             # Configurações da aplicação
├── packages.config        # Configuração de pacotes NuGet
└── Properties/            # Propriedades do projeto
    ├── AssemblyInfo.cs
    ├── Resources.resx
    └── Settings.settings
```

## 🎨 Interface

O sistema possui uma interface com navegação por abas:

- **Aba Cadastro** - Formulário para inserir novas bandas
- **Aba Busca** - Interface para pesquisar e visualizar bandas cadastradas

A navegação é facilitada por botões laterais com indicador visual de aba selecionada.


## 📝 Licença

Este projeto é um trabalho acadêmico desenvolvido para fins educacionais.

## 👥 Autor

Desenvolvido como projeto do curso de Linguagem I

---

**Nota**: Este é um projeto modelo para fins educacionais. Certifique-se de implementar as validações e tratamento de erros adequados antes de usar em produção.
