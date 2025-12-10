using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T.Emprestimo
{
    public class Emprestimo
    {
        public int nlivro { get; set; }
        public int nleitor { get; set; }
        BaseDados bd;
        public Emprestimo(BaseDados bd)
        {
            this.bd = bd;
        }
        public void RegistarEmprestimo()
        {
            String SQL = "INSERT INTO Emprestimos(nleitor, nlivro) Values(@nleitor,@nlivro)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@pesquisa",
                    SqlDbType = SqlDbType.VarChar,
                    Value = this.nleitor,
                },
                new SqlParameter()
                {
                    ParameterName = "@nlivro",
                    SqlDbType = SqlDbType.Int,
                    Value = this.nlivro

                }


            };
            bd.ExecutarSql(SQL, parametros);
            SQL = "Update livros Set estado= 0 where nlivro=@nlivro";
            bd.ExecutarSql(SQL,parametros);
        }
    }
}

