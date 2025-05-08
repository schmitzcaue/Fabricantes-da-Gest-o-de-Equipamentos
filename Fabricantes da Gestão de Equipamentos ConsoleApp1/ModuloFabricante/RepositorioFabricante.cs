using Fabricantes_da_Gestão_de_Equipamentos_ConsoleApp1.ModuloEquipamento;
using Fabricantes_da_Gestão_de_Equipamentos_ConsoleApp1.ModuloFabricante;

namespace Fabricantes_da_Gestão_de_Equipamentos_ConsoleApp1.ModuloFabricantes;

public class RepositorioFabricante
{
    public Fabricante[] fabricantes = new Fabricante[100];
    public int contadorFabricante = 0;

    public void CadastrarFabricante(Fabricante fabricante)
    {
        fabricantes[contadorFabricante] = fabricante;

        contadorFabricante++;
    }
    public bool EditarFabricante(int idSelecionado, Fabricante FabricanteAtualizado)
    {
        Fabricante FabricanteSelecionado = SelecionarFabricantePorId(idSelecionado);

        if (FabricanteSelecionado == null)
            return false;

        FabricanteSelecionado.nomeFabricante = FabricanteAtualizado.nomeFabricante;
        FabricanteSelecionado.email = FabricanteAtualizado.email;
        FabricanteSelecionado.telefone = FabricanteAtualizado.telefone;
        FabricanteSelecionado.numeroSerie = FabricanteAtualizado.numeroSerie;

        return true;
    }

    public bool ExcluirFabricante(int idSelecionado)
    {
        for (int i = 0; i < fabricantes.Length; i++)
        {
            if (fabricantes[i] == null)
                continue;

            if (fabricantes[i].id == idSelecionado)
            {
                fabricantes[i] = null;

                return true;
            }
        }

        return false;
    }


    public Fabricante[] SelecionarFabricantes()
    {
        return fabricantes;
    }

    public Fabricante SelecionarFabricantePorId(int idSelecionado)
    {
        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante f = fabricantes[i];

            if (f == null)
                continue;

            if (f.id == idSelecionado)
                return f;
        }

        return null;
    }

}
