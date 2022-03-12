using System.Collections.Generic;


namespace ModelagemEstrelaDaMorte.ViewModels
{
    public class ResultadoApi<ViewModel>
    {
        public string Next { get; set; }
        public IReadOnlyList<ViewModel> Resultado { get; set;}
    }
}
