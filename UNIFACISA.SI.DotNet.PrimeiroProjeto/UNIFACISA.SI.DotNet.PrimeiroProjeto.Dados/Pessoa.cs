using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIFACISA.SI.DotNet.PrimeiroProjeto.Dados
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string  CPF { get; set; }
        public IList<Telefone> Telefones { get; set; }
    }
}
