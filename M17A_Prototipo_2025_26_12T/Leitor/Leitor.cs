using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T.Leitor
{
    internal class Leitor
    {
        public int nleitor { get; set; }
        public string nome { get; set; }
        public bool estado { get; set; }
        BaseDados bd;
        public Leitor(BaseDados bd)
        {
            this.bd= bd;
        }

        public DataTable Listar()
        {
            return bd.devolveSql("Select * From Leitores Order by Nome");
        }

        //TODO: Adicionar as funcionalidades restantes 
    public override string ToString()
        {
            return this.nome;
        }
    }
}
