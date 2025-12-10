using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M17A_Prototipo_2025_26_12T.Livro;

namespace M17A_Prototipo_2025_26_12T.Emprestimo
{
    public partial class F_emprestimo : Form
    {
        BaseDados bd;

        public F_emprestimo(BaseDados bd)
        {
            InitializeComponent();
            this.bd = bd;
            PreencehCBLeitores();
            PreencheCBLivros();
        }
        /// <summary>
        /// preencher cb dos livros
        /// </summary>
        void PreencheCBLivros()
        {
            CBLIVRO.Items.Clear();
            Livro.livro l= new Livro.livro(bd);
            DataTable dados = l.listar();
            foreach (DataRow dr in dados.Rows)
            {
                Livro.livro novo = new Livro.livro(bd);
                novo.nlivro = int.Parse(dr["nlivro"].ToString());
                novo.titulo = dr["titulo"].ToString();
                novo.estado = bool.Parse(dr["estado"].ToString());
                if (novo.estado==true)
                CBLIVRO.Items.Add(novo);
            }

        }
        /// <summary>
        /// Preenche cb dos leitores
        /// </summary>
        void PreencehCBLeitores()
        {
            CBLEITOR.Items.Clear();
            Leitor.Leitor l= new Leitor.Leitor(bd);
            DataTable dados=l.Listar();
            foreach(DataRow dr in dados.Rows)
            {
                Leitor.Leitor novo=new Leitor.Leitor(bd);
                novo.nleitor = int.Parse(dr["nleitor"].ToString());
                novo.nome = dr["nome"].ToString() ;
                novo.estado = bool.Parse(dr["estado"].ToString());
                if(novo.estado==true)
                    CBLEITOR.Items.Add(novo);
            }
        }

        private void TBEMPRESTAR_Click(object sender, EventArgs ev)
        {
            if(CBLEITOR.SelectedIndex==-1 || CBLIVRO.SelectedIndex==-1)
            {
                MessageBox.Show("Tem de escolher um livro e um leitor");
                return;
            }

            Leitor.Leitor leitor_escolhido=CBLEITOR.SelectedItem as Leitor.Leitor;
            Livro.livro livro_escolhido=CBLIVRO.SelectedItem as Livro.livro;
            Emprestimo e = new Emprestimo(bd);
            e.nlivro=livro_escolhido.nlivro;
            e.nleitor=leitor_escolhido.nleitor;
            e.RegistarEmprestimo();
            PreencheCBLivros();
        }
    }
}
