using Fabricantes_da_Gestão_de_Equipamentos_ConsoleApp1.ModuloChamado;
using Fabricantes_da_Gestão_de_Equipamentos_ConsoleApp1.ModuloEquipamento;
using Fabricantes_da_Gestão_de_Equipamentos_ConsoleApp1.ModuloFabricante;
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace Fabricantes_da_Gestão_de_Equipamentos_ConsoleApp1.ModuloFabricantes;

public class TelaFabricante
{
    public RepositorioFabricante repositorioFabricante;

    public void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("Gestão de Fabricantes");
        Console.WriteLine();
    }
    public char ApresentarMenu()
    {
        ExibirCabecalho();

        Console.WriteLine("1 - Cadastro de Fabricantes");
        Console.WriteLine("2 - Visualizar Fabricantes");
        Console.WriteLine("3 - Editar Fabricantes");
        Console.WriteLine("4 - Excluir Fabricantes");
        Console.WriteLine("S - Sair");

        Console.WriteLine();

        Console.Write("Digite uma opção válida: ");
        char opcaoEscolhida = Console.ReadLine().ToUpper()[0];

        return opcaoEscolhida;
    }
    public void CadastrarRegistro()
    {
        ExibirCabecalho();
        Console.WriteLine("Cadastro de Fabricantes");

        Console.WriteLine();

        Fabricante fabricante = ObterDados();

        repositorioFabricante.CadastrarFabricante(fabricante);

        Console.WriteLine($"\nFabricante \"{fabricante.nomeFabricante}\" cadastrado com sucesso!");
        Console.ReadLine();
    }
    public void VisualizarRegistros(bool exibirCabecalho)
    {
        if (exibirCabecalho == true)
            ExibirCabecalho();

        Console.WriteLine("Visualização de Fabricantes");

        Console.WriteLine();

        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -20} | {3, -30} | {4, -15}",
            " id", "Nome", "email", "telefone", "Fabricante"
        );
        // Equipamento[] equipamentos = repositorioEquipamento.SelecionarEquipamentos();
        Fabricante[] fabricantes = repositorioFabricante.SelecionarFabricantes();

        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante f = fabricantes[i];

            if (f == null)
                continue;

            Console.WriteLine(
               "{0, -10} | {1, -20} | {2, -20} | {3, -30} | {4, -15}",
                f.id, f.nomeFabricante,  f.telefone, f.numeroSerie, f.email
            );
        }

        Console.ReadLine();
    }

    public void EditarRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine("Edição de Fabricante");

        Console.WriteLine();

        VisualizarRegistros(false);

        Console.Write("Digite o id do registro que deseja selecionar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Fabricante fabricanteAtualizado = ObterDados();

        bool conseguiuEditar = repositorioFabricante.EditarFabricante(idSelecionado, fabricanteAtualizado);

        if (!conseguiuEditar)
        {
            Console.WriteLine("Não foi possível encontrar o registro selecionado.");
            Console.ReadLine();

            return;
        }

        Console.WriteLine($"Fabricante \"{fabricanteAtualizado.nomeFabricante}\" editado com sucesso!");
        Console.ReadLine();
    }

    public void ExcluirRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine("Exclusão de Fabricante");

        Console.WriteLine();

        VisualizarRegistros(false);

        Console.Write("Digite o id do registro que deseja selecionar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        bool conseguiuExcluir = repositorioFabricante.ExcluirFabricante(idSelecionado);

        if (!conseguiuExcluir)
        {
            Console.WriteLine("Não foi possível encontrar o registro selecionado.");
            Console.ReadLine();

            return;
        }

        Console.WriteLine($"Fabricante excluído com sucesso!");
        Console.ReadLine();
    }

    public Fabricante ObterDados()
    {
        Console.WriteLine("Digite o nome do fabricante: ");
        string nomeFabricante = Console.ReadLine();

        Console.WriteLine("Digite telefone do fabricante: ");
        string telefone = Console.ReadLine();

        Console.WriteLine("Digite o número de série do equipamento: ");
        string numeroSerie = Console.ReadLine();

        Console.WriteLine("Digite o email do fabricante do equipamento: ");
        string email = Console.ReadLine();

        Fabricante fabricantes = new Fabricante();
     
        fabricantes.nomeFabricante = nomeFabricante;
        fabricantes.telefone = telefone;
        fabricantes.numeroSerie = numeroSerie;
        fabricantes.email = email;
        //• Deve ter a quantidade de equipamentos feitos pelo fabricante em registro;
        return fabricantes;
    }
}
