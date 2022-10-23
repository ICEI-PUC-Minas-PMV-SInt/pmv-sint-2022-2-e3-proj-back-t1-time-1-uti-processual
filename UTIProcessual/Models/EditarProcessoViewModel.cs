namespace UTIProcessual.Models
{
    public class EditarProcessoViewModel
    {
        // Processo
        public Guid Id { get; set; }
        public int NumeroProcessoPenal { get; set; }
        public string TipoPenal { get; set; }

        // Dados do Crime
        public string LocalDoCrime { get; set; }
        public DateTime DataDoCrime { get; set; }
        public int NumeroPCNET { get; set; }
        public int NumeroREDS { get; set; }
        public int NumInqueritoPolicial { get; set; }

        // Réu
        public string NomeReu { get; set; }
        public string FiliacaoReu { get; set; }
        public DateTime DataNascReu { get; set; }
        public string NaturalidadeReu { get; set; }
        public string EnderecoReu { get; set; }
        public int TelefoneReu { get; set; }

        // Caso o réu tenha patrocinio
        public string Advogado { get; set; }
        public string OABAdvogado { get; set; }
        public string DefensoriaPublica { get; set; }
    }
}
