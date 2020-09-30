using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAReceber
{
    class Contasreceber
    {
        public int nr_titulo { get; set; }
        public int parcela { get; set; }
        public DateTime dataCadastro { get; set; }
        public int Fk_Id_cliente { get; set; }
        public int Fk_Id_categoria { get; set; }
        public int Fk_Id_tipo { get; set; }
        public int Fk_Id_situacao { get; set; }
        public DateTime vencimento { get; set; }
        public int valorTitulo { get; set; }
        public String observacoes { get; set; }

        public Cliente tb_cliente { get; set; }
        public Categoria tb_categoria { get; set; }
        public Tipo_Cobranca tb_tipocobranca { get; set; }
        public Situacao tb_situacao { get; set; }

    }
}
