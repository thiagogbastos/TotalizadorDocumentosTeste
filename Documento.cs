using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalizadorDocumentosTeste
{
    public class Documento
    {
        public string Caminho { get; set; }
        public int Ano { get; set; }
        public string Mes { get; set; }
        public string Categoria { get; set; }
      
        public string NomeArquivo { get; set; }
        public double Valor { get; set; }
    }

    public class Arquivo
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
