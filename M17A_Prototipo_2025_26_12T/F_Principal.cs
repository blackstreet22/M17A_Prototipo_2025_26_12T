using M17A_Prototipo_2025_26_12T.Emprestimo;
using M17A_Prototipo_2025_26_12T.Livro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_Prototipo_2025_26_12T
{
    public partial class F_Principal : Form
    {
        BaseDados bd;
        public F_Principal()
        {
            InitializeComponent();
            bd = new BaseDados("Biblioteca_12T");
        }
        //livros
        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_livro F=new F_livro(bd);
            F.Show();

        }
        //sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void F_Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_emprestimo f =new F_emprestimo(bd);
            f.Show();
        }
    }
}
