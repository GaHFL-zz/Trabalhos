using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
namespace Loja.DTO
{
    public class usuario_DTO
    /*Nesta classe DTO temos os atributos do objeto
    Public para que ele seja acessível externamente.
    Propriedade Get e Set para acessar o conteúdo*/
    {
        public int cod_usuario { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime cadastro { get; set; }
        public string situacao { get; set; }
        public int perfil { get; set; }
    }
}