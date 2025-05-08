🛠️ Gestão de Equipamentos - ASP.NET Core
Este projeto é uma API desenvolvida em C# com ASP.NET Core para ajudar o funcionário Junior no controle de equipamentos, manutenções (chamados) e fabricantes. O sistema substitui planilhas manuais por uma aplicação automatizada e centralizada.

📦 Funcionalidades
1. Controle de Equipamentos
✅ Requisito 1.1 - Cadastrar Equipamento
Id (Guid): gerado automaticamente

Nome (mínimo 6 caracteres)

Preço de Aquisição (decimal)

Número de Série (string)

Data de Fabricação (DateTime)

Fabricante (relacionamento com entidade fabricante)

✅ Requisito 1.2 - Listar Equipamentos
Exibe: Id, Nome, Preço, Fabricante, Data de Fabricação

✅ Requisito 1.3 - Editar Equipamento
Todos os campos do Requisito 1.1 podem ser editados

✅ Requisito 1.4 - Excluir Equipamento
Atualiza automaticamente a lista

2. Controle de Chamados
✅ Requisito 2.1 - Cadastrar Chamado
Id (Guid): gerado automaticamente

Título (string)

Descrição (string)

Equipamento (relacionamento com equipamento)

Data de Abertura (DateTime)

✅ Requisito 2.2 - Listar Chamados
Exibe: Título, Equipamento, Data de Abertura, Dias em aberto (calculado)

✅ Requisito 2.3 - Editar Chamado
Todos os campos do Requisito 2.1 podem ser editados

✅ Requisito 2.4 - Excluir Chamado
3. Controle de Fabricantes
✅ Requisito 3.1 - Cadastrar Fabricante
Id (Guid): gerado automaticamente

Nome (string)

Email (string)

Telefone (string)

✅ Requisito 3.2 - Listar Fabricantes
Exibe: Nome, Email, Telefone, Quantidade de Equipamentos Associados

✅ Requisito 3.3 - Editar Fabricante
Todos os campos do Requisito 3.1 podem ser editados

✅ Requisito 3.4 - Excluir Fabricante
✅ Requisito 3.5 - Associar Fabricante ao Equipamento no Cadastro

## Autor SCHMITZ.CAUE


  <img src="https://github.com/user-attachments/assets/bea09985-5a7f-40ca-b0a6-6891c144a032" width="280" />
  <h3 style="margin: 0;"><i>SCHMITZ.CAUE</i></h4>


  <p>
    <a href="https://www.linkedin.com/in/cau%C3%AA-schmitz-316261356/">
      <img src="https://skillicons.dev/icons?i=linkedin&theme=dark" width="50"/>
      LinkedIn
    </a> &nbsp;  |  &nbsp;
    <a href=https://github.com/schmitzcaue
      <img src="https://skillicons.dev/icons?i=github&theme=dark" width="50"/>
      GitHub
    </a>
  </p>
</main>

## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=cs,dotnet,visualstudio,git,github)](https://skillicons.dev)
