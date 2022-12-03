using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace utip_backend.Models
{
    public class ProcessModel
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ProcessID { get; set; }
        [Column(TypeName ="nvarchar(11)")]
        public string? NumLegalProcess { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? Defendant { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string? NaturalidadeReu { get; set;}
        [Column(TypeName = "nvarchar(255)")]
        public string? FiliacaoReu { get; set; }
        [Column(TypeName = "datetime()")]
        public DateTime? DataNascReu { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public string? TelefoneReu { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? DefensoriaPublica { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? Attorney { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? TipoPenal { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? DefAddress { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public string? NumeroREDS { get; set; }
        [Column(TypeName = "datetime()")]
        public DateTime? DataDoCrime { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? LocalDoCrime {get; set;}
        [Column(TypeName = "nvarchar(11)")]
        public string? NumInqueritoPolicial { get; set; }
        [Column(TypeName = "int")]
        public int? IdStatus { get; set; }
        [Column(TypeName = "nvarchar(4)")]
        public string? TxStatus { get; set; }
        [Column(TypeName = "datetime()")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "int")]
        public int? days { get; set; }
    }
}
