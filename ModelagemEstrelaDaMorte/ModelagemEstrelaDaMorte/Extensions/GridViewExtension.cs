using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelagemEstrelaDaMorte.Extensions
{
    public static class GridViewExtension
    {
        public static int ObterQuantidadeLinhasVerificadas(this DataGridViewRowCollection linhas, int verificacaoIndiceColunas)
        {
            int quantidade = 0;

            foreach (DataGridViewRow linha in linhas)
            {
                var celula = linha.Cells[verificacaoIndiceColunas] as DataGridViewCheckBoxCell;
                if (celula.Value != null && (bool)celula.Value)
                    ++quantidade;
            }

            return quantidade;
        }

        public static int ObterPrimeiroIndiceVerificado(this DataGridViewRowCollection linhas, int verificacaoIndiceColunas)
        {
            int indice = 0;

            foreach (DataGridViewRow linha in linhas)
            {
                var celula = linha.Cells[verificacaoIndiceColunas] as DataGridViewCheckBoxCell;
                ++indice;

                if (celula.Value != null && (bool)celula.Value)
                    return indice;
            }

            return -1;

        }
    }
}
