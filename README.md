## Descrição
Este projeto é um exercício da escola onde é necessário desenvolver uma aplicação para gerir um supermercado utilizando SQL Server e C#. Consiste em uma aplicação **back-office** para gerir categorias, produtos e descontos e um **portal para clientes** onde é possível realizar compras.

---

## Funcionalidades

### Back-Office
- **Gestão de Categorias** 🗂
  - Adicionar novas categorias de produtos. ➕
  - Eliminar categorias (assegurando que não existem produtos associados). ✖

- **Gestão de Produtos** 🛒
  - Adicionar, editar e apagar produtos.
  - Atributos incluem:
    - Nome 
    - Descrição 
    - Preço 
    - Stock 
    - Associação a categoria 

- **Gestão de Descontos** 🔄
  - Criar descontos em produtos para períodos específicos. 🔎
  - Validar que não existem períodos de desconto sobrepostos para o mesmo produto. 📑
  - Aplicar descontos automaticamente para calcular o preço final. 🔄

### Portal para Clientes
- **Registo e Login de Utilizadores** 🔐
  - Registar com nome de utilizador, nome, NIF, password e saldo inicial.
  - Iniciar sessão com nome de utilizador e password.

- **Compras** 🛏
  - Navegar pelos produtos disponíveis por categoria. 🔍
  - Adicionar produtos ao carrinho e especificar quantidades. 🛒
  - Validar a disponibilidade de stock para os produtos selecionados. ✅
  - Garantir que o cliente tem saldo suficiente para concluir a compra. ⚡
  - Atualizar o stock e o saldo do cliente após o pagamento. 💳
  - Visualizar o histórico de compras e realizar devoluções parciais ou completas. ♻
  - Recarregar automaticamente compras incompletas ao iniciar sessão novamente. 🔁
  - Procurar produtos pelo nome ou descrição. 🔍

- **Favoritos** ⭐
  - Marcar produtos como favoritos para acesso mais rápido.

---

## Estrutura da Base de Dados 🔧

O projeto utiliza uma base de dados SQL Server com as seguintes tabelas:

- **`dbo.TYPE`**
  - Armazena categorias de produtos. 🗋
  - Colunas: `ID`, `NAME`, `DELETE_DATE`.

- **`dbo.Product`**
  - Armazena detalhes dos produtos. 🗍
  - Colunas: `ID`, `Name`, `Price`, `Type_Id`, `Description`, `Stock`, `Price_Discount`.

- **`dbo.Discount`**
  - Armazena detalhes dos descontos. 🎁
  - Colunas: `ID`, `PRODUCT_ID`, `FROM`, `TO`, `PERCENTAGE`, `DESCRIPTION`.

- **`dbo.CLIENT`**
  - Armazena dados dos clientes. 👥
  - Colunas: `ID`, `NAME`, `PASSWORD`, `USERNAME`, `BALANCE`.

- **`dbo.BUYS`**
  - Armazena detalhes das compras. 🛍
  - Colunas: `ID`, `ID_CLIENT`, `TOTAL`, `DATE`, `IS_DELETED`.

- **`dbo.BUY_PRODUCTS`**
  - Armazena detalhes dos produtos dentro de uma compra. 🛒
  - Colunas: `ID_BUY`, `ID_PRODUCT`, `PRICE`, `DISCOUNT`.

---

## Como Executar 🚀

1. Clone o repositório: 
   ```bash
   git clone https://github.com/Rodrigo-200/Portal-de-Compras.git
   ```
2. Abra a solução no Visual Studio.
3. Configure a base de dados SQL Server utilizando a estrutura fornecida.
4. Atualize a connection string do projeto para apontar para a sua instância do SQL Server.
5. Compile e execute o projeto.

---

## Requisitos 🔗

- **SQL Server**: Para armazenar todos os dados.
- **.NET Framework**: Para construir a aplicação.
- **Visual Studio**: Para desenvolvimento.

---

## Licença 🔒
Este projeto é apenas para fins educacionais.

