using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T
{
    public class BaseDados
    {
        string NomeBD;
        string strligacao;
        string CaminhoBD;
        SqlConnection ligacaoSQL;

        public BaseDados(String NomeBD)
        {
            this.NomeBD = NomeBD;

            strligacao = ConfigurationManager.ConnectionStrings["sql"].ToString();
            CaminhoBD = utils.PastaProgram("M17A_Biblioteca_12T");
            CaminhoBD += @"\" + NomeBD + ".mdf";

            if (System.IO.File.Exists(CaminhoBD) == false)
            {
                CriarBD();
            }
            ligacaoSQL = new SqlConnection(strligacao);
            ligacaoSQL.Open();
            ligacaoSQL.ChangeDatabase(this.NomeBD);
        }

        /// <summary>
        /// verifica se a Bd existe no catalogo e cria a bd e as tabelas
        /// </summary>

        void CriarBD()
        {
            SqlConnection ligacoSQL = new SqlConnection(strligacao);
            ligacoSQL.Open();
            string sql = $@"IF EXISTS(SELECT* from master.SYS.databases
                                      where name='{this.NomeBD}')
                                      Begin
                                        Use[master];
                                        EXEC sp_detach_db{this.NomeBD}
                                         END";

            SqlCommand comando = new SqlCommand(sql, ligacoSQL);
            comando.ExecuteNonQuery();

            //Criar a bd
            sql = $"CREATE DATABASE {this.NomeBD} ON PRIMARY (NAME={this.NomeBD},FILENAME='{this.CaminhoBD}')";

            comando = new SqlCommand(sql, ligacoSQL);
            comando.ExecuteNonQuery();


            // ativar bd criada

            ligacoSQL.ChangeDatabase(this.NomeBD);

            //criar tabela livros

            sql = @"CREATE TABLE Livros(
                nlivro int identity primary key,
                titulo varchar(50) not null,
                autor varchar(100),
                isbn char(13),
                ano int check(ano > 0),
                data_aquisicao date default getdate(),
                preco money check (preco>=0),
                capa varchar(500),
                estado bit deafult 1

                );


                Create Table Leitores(
                nleitor int identity primary key,
                nome varchar(100) not null,
                data_nascimento date,
                fotografia varbinary(max),
                estado bit default 1
                );

                Create Table Emprestimos(
                nemprestimo int identity primary key,
                data_emprestimo date default getdate(),
                data_devolve date,
                estado bit default 1,
                nleitor int references leitores(nleitor),
                nlivro int references Livros(nlivro)



            )";







            //TODO: falta as tabelas leitores e emprestimos
            comando = new SqlCommand(sql, ligacoSQL);
            comando.ExecuteNonQuery();
            comando.Dispose();
        }
    


        public void ExecutarSql(string sql,List<SqlParameter> parametros=null )
        {
            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            if (parametros != null)
                comando.Parameters.AddRange(parametros.ToArray());

            comando.ExecuteNonQuery();
            comando.Dispose();
        }


        public DataTable devolveSql(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            if (parametros != null)
                comando.Parameters.AddRange(parametros.ToArray());

            SqlDataReader dados=comando.ExecuteReader();
            DataTable registros = new DataTable();
            registros.Load(dados);
            comando.Dispose();
            dados.Close();
            return registros;
        }
    }
}
