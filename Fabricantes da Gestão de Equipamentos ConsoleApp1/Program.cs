using Fabricantes_da_Gestão_de_Equipamentos_ConsoleApp1.ModuloFabricantes;
using GestaoDeEquipamentos.ConsoleApp.ModuloChamado;
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        RepositorioEquipamento repositorioEquipamento = new RepositorioEquipamento();
        RepositorioChamado repositorioChamado = new RepositorioChamado();
        RepositorioFabricante repositorioFabricante = new RepositorioFabricante();

        TelaEquipamento telaEquipamento = new TelaEquipamento();
        telaEquipamento.repositorioEquipamento = repositorioEquipamento;

        TelaChamado telaChamado = new TelaChamado();
        telaChamado.repositorioChamado = repositorioChamado;
        telaChamado.repositorioEquipamento = repositorioEquipamento;

        TelaFabricante TelaFabricante = new TelaFabricante();
        TelaFabricante.repositorioFabricante = repositorioFabricante;

        while (true)
        {
            char telaEscolhida = ApresentarMenuPrincipal();

            if (telaEscolhida == '1')
            {
                char opcaoEscolhida = telaEquipamento.ApresentarMenu();

                if (opcaoEscolhida == 'S')
                    break;

                switch (opcaoEscolhida)
                {
                    case '1':
                        telaEquipamento.CadastrarRegistro();
                        break;

                    case '2':
                        telaEquipamento.VisualizarRegistros(true);
                        break;

                    case '3':
                        telaEquipamento.EditarRegistro();
                        break;

                    case '4':
                        telaEquipamento.ExcluirRegistro();
                        break;
                }
            }

            else if (telaEscolhida == '2')
            {
                char opcaoEscolhida = telaChamado.ApresentarMenu();

                if (opcaoEscolhida == 'S')
                    break;

                switch (opcaoEscolhida)
                {
                    case '1':
                        telaChamado.CadastrarRegistro();
                        break;

                    case '2':
                        telaChamado.VisualizarRegistros(true);
                        break;

                    case '3':
                        telaChamado.EditarRegistro();
                        break;

                    case '4':
                        telaChamado.ExcluirRegistro();
                        break;
                }
            }

            else if (telaEscolhida == '3')
            {
                char opcaoEscolhida = TelaFabricante.ApresentarMenu();

                if (opcaoEscolhida == 'S')
                    break;

                switch (opcaoEscolhida)
                {
                    case '1':
                        TelaFabricante.CadastrarRegistro();
                        break;

                    case '2':
                        TelaFabricante.VisualizarRegistros(true);
                        break;

                    case '3':
                        TelaFabricante.EditarRegistro();
                        break;

                    case '4':
                        TelaFabricante.ExcluirRegistro();
                        break;
                }
            }

        }
    }

    public static char ApresentarMenuPrincipal()
    {
        Console.Clear();

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|        Gestão de Equipamentos        |");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine();

        Console.WriteLine("1 - Controle de Equipamentos");
        Console.WriteLine("2 - Controle de Chamados");
        Console.WriteLine("3 - Controle de Fabricantes");
        Console.WriteLine("S - Sair");

        Console.WriteLine();

        Console.Write("Escolha uma das opções: ");
        char opcaoEscolhida = Console.ReadLine()[0];

        return opcaoEscolhida;
    }
}