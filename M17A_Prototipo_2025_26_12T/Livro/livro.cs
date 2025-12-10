using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T.Livro
{
    internal class livro : IItem
    {
        public int nlivro {  get; set; }
        public string titulo {  get; set; }
        public string autor {  get; set; }
        public string isbn {  get; set; }
        public int ano { get; set; }
        public DateTime data_aquisicao { get; set; }
        public Decimal preco { get; set; }
        public string capa { get; set; }
        public bool estado { get; set; }
        BaseDados bd;
        public livro(BaseDados bd)
        {
            this.bd=bd;
        }



        public void Adicionar()
        {
            string sql = @"Insert into livros(titulo, autor,isbn,ano,data_aquisicao,preco,capa)
                Values (@titulo,@autor,@isbn,@ano,@data_aquisicao,@preco,@capa)";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@titulo",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.titulo
                },
                new SqlParameter()
                {
                    ParameterName = "@autor",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.autor
                },
                new SqlParameter()
                {
                    ParameterName = "@isbn",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.isbn
                },

                new SqlParameter()
                {
                    ParameterName = "@ano",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = this.ano
                },
                new SqlParameter()
                {
                    ParameterName = "@data_aquisicao",
                    SqlDbType = System.Data.SqlDbType.Date,
                    Value = this.data_aquisicao
                },

                new SqlParameter()
                {
                    ParameterName = "@preco",
                    SqlDbType = System.Data.SqlDbType.Money,
                    Value = this.preco
                },
                new SqlParameter()
                {
                    ParameterName = "@capa",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.capa
                },
            };



            bd.ExecutarSql(sql, parametros);


        }

        public void apagar()
        {
            bd.ExecutarSql("DELETE From livros Where nlivro=" + nlivro);
        }

        public void editar()
        {
            string sql = @"UPDATE livros SET titulo=@titulo, autor=@autor,isbn=@isbn,ano=@ano,data_aquisicao=@data_aquisicao,preco=@preco,capa=@capa
                WHERE nlivro=@nlivro";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@titulo",
                    SqlDbType=System.Data.SqlDbType.VarChar,
                    Value=this.titulo
                },
                new SqlParameter()
                {
                    ParameterName = "@autor",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.autor
                },
                new SqlParameter()
                {
                    ParameterName = "@isbn",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.isbn
                },

                new SqlParameter()
                {
                    ParameterName = "@ano",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = this.ano
                },
                new SqlParameter()
                {
                    ParameterName = "@data_aquisicao",
                    SqlDbType = System.Data.SqlDbType.Date,
                    Value = this.data_aquisicao
                },

                new SqlParameter()
                {
                    ParameterName = "@preco",
                    SqlDbType = System.Data.SqlDbType.Money,
                    Value = this.preco
                },
                new SqlParameter()
                {
                    ParameterName = "@capa",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = this.capa
                },

                new SqlParameter()
                {
                    ParameterName="@nlivro",
                    SqlDbType=System.Data.SqlDbType.Int,
                    Value = this.nlivro
                }
            };



            bd.ExecutarSql(sql, parametros);


        }
        

        public List<string> validar()
        {
            List<string> erros = new List<string>();
            //validar titulo
            if (String.IsNullOrEmpty(titulo) || titulo.Length < 3)
            {
                erros.Add("O título deve ter pelo menos 3 letras.");
            }
            //validar autor
            if (String.IsNullOrEmpty(autor) || autor.Length < 3)
            {
                erros.Add("O autor do livro deve ter pelo menos 3 letras.");
            }
            //validar ISBN
            //validar ano
            if (ano < 0 && ano >= DateTime.Now.Year)
            {
                erros.Add("O ano de publicação do livro deve ser maior que zero e menor ou igual ao ano atual.");
            }
            if (isbn.Length != 13)
            {
                erros.Add("O ISBN do livro deve ter 13 números.");
            }
            return erros;
        }

        //devolve um data table com todos os registros da tabela  livros 
        public DataTable listar()
        {
            return bd.devolveSql("Select nlivro,titulo, autor,isbn,estado FROM livros order by Titulo");
        }
        /// <summary>
        /// pesquisa o livro com base no livro e preenche o objeto com os dados da bd
        /// </summary>
        public void procurar()
        {   
            string sql = "Select * From livros where nlivro=" + nlivro;
            DataTable dados= bd.devolveSql(sql);

            if (dados != null && dados.Rows.Count > 0)
            {
                DataRow linha=dados.Rows[0];
                this.titulo = linha["titulo"].ToString();
                this.isbn = linha["isbn"].ToString();
                this.preco= decimal.Parse(linha["preco"].ToString());
                this.autor = linha["autor"].ToString();
                this.capa = linha["capa"].ToString();
                this.data_aquisicao=DateTime.Parse(linha["data_aquisicao"].ToString());
                this.ano = int.Parse(linha["ano"].ToString());
                this.estado = bool.Parse(linha["estado"].ToString());
            }
        }

        public DataTable procurar(string campo, string texto_pesquisar)
        {
            string sql = "Select nlivro,titulo, autor,isbn, estado FROM livros where ";
            sql += campo + " Like @pesquisa";

            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@pesquisa",
                    SqlDbType=SqlDbType.VarChar,
                    Value="%"+texto_pesquisar+"%"
                }
            };
            return bd.devolveSql(sql, parametros);
        }

        public override string ToString()
        {
            return this.titulo;
        }
    }
}
