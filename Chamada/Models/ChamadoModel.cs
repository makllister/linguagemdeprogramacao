using System.Reflection;

namespace Chamados.Models
{
    public class Chamado
    {

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Solicitacao { get; set; } = string.Empty;
        public string Responsavel { get; set; } = string.Empty;
        public DateTime Inicio { get; set; }
        public DateTime? Termino { get; set; }

    }
}