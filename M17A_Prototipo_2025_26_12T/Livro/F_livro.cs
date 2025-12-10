using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_Prototipo_2025_26_12T.Livro
{
    public partial class F_livro : Form
    {
        string ficheiro_capa = "";
        BaseDados bd;
        int nlivro_escolhido = 0;


        public F_livro(BaseDados bd)
        {
            InitializeComponent();
            this.bd = bd;
            ListarLivros();
        }

        private void F_livro_Load(object sender, EventArgs e)
        {

        }

        private void BTPROCURAR_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ficheiro = new OpenFileDialog();
            ficheiro.Filter = "Imagens |*.jpg; *.png; *.bmp | Todos os ficheiros | *.*";
            ficheiro.InitialDirectory = "c:\\";
            ficheiro.Multiselect = false;
            if (ficheiro.ShowDialog() == DialogResult.OK)
            {
                string temp = ficheiro.FileName;//Caminho inteiro do ficheiro
                if (System.IO.File.Exists(temp))
                {
                    PBCAPA.SizeMode = PictureBoxSizeMode.StretchImage;
                    Stream stream = File.Open(temp, FileMode.Open, FileAccess.Read, FileShare.Read);
                    PBCAPA.Image = Image.FromStream(stream);
                    stream.Close();
                    ficheiro_capa = temp;
                }
            }
        }

        private void BTGUARDAR_Click(object sender, EventArgs e)
        {
            livro novo = new livro(bd);
            novo.titulo = TBTITULO.Text;
            novo.isbn = TBISBN.Text;
            novo.ano = int.Parse(TBANO.Text);
            novo.autor = TBAUTOR.Text;
            novo.data_aquisicao = DTPDATA.Value;
            novo.preco = decimal.Parse(TBPRECO.Text);
            novo.estado = true;
            novo.capa = utils.PastaProgram("M17A_Biblioteca_12T") + @"\" + novo.isbn;




            List<string> erros = novo.validar();
            if (erros.Count > 0)
            {
                String mensagem = "";
                foreach (string erro in erros)
                    mensagem+= erro;
                
                    LBFEEDBACK.Text = mensagem;
                    LBFEEDBACK.ForeColor = Color.Red;
                    return;
                

            }


                //VERIFICAR SE É UM LIVRO NOVO
                if(nlivro_escolhido==0)
  
                    novo.Adicionar();

                else
                {
                    novo.nlivro = nlivro_escolhido;
                    novo.editar();
                }

                if (ficheiro_capa != "")
                {
                    if (System.IO.File.Exists(ficheiro_capa) == true)
                    {
                        System.IO.File.Copy(ficheiro_capa, novo.capa, true);
                    }
                }

            limparForm();


            ListarLivros();


            LBFEEDBACK.Text = "Livro guardado com sucesso.";
            LBFEEDBACK.ForeColor = Color.Black;



        }

        private void ListarLivros()
        {
            dgv_livros.AllowUserToAddRows = false;
            dgv_livros.AllowUserToDeleteRows = false;
            dgv_livros.MultiSelect = false;
            dgv_livros.ReadOnly = true;
            dgv_livros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            livro l = new livro(bd);
            dgv_livros.DataSource = l.listar();

        }

        // limpa os controlos do formulario
        private void limparForm()
        {
            TBANO.Text = "";
            TBAUTOR.Text = "";
            TBISBN.Text = "";
            TBPRECO.Text = "0";
            TBTITULO.Text = "";
            PBCAPA.Image = null;
            ficheiro_capa = "";
            DTPDATA.Value = DateTime.Now;

        }

        private void dgv_livros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_livros.CurrentCell==null)
            {
                return;
            }
            //guardar o nlivros selecionando
            int linha = dgv_livros.CurrentCell.RowIndex;
            if (linha == -1)
                return;

            nlivro_escolhido = int.Parse(dgv_livros.Rows[linha].Cells[0].Value.ToString());
            //mostrar dados do livro selecionado
            livro l= new livro(bd);
            l.nlivro = nlivro_escolhido;
            l.procurar();
            TBTITULO.Text = l.titulo;
            TBANO.Text=l.ano.ToString();
            TBAUTOR.Text = l.autor;
            TBISBN.Text=l.isbn;
            TBPRECO.Text = l.preco.ToString();
            if (System.IO.File.Exists(l.capa))
            {
                Stream stream = File.Open(l.capa, FileMode.Open, FileAccess.Read, FileShare.Delete);

                PBCAPA.Image = Image.FromStream(stream);
                stream.Close();
            }

            else
                PBCAPA.Image = null;
            DTPDATA.Value = l.data_aquisicao;


        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            EliminarLivro();
            //todo:

        }



        private void teste()
        {
            
        }

        private void EliminarLivro()
        {


            if (nlivro_escolhido == 0)
            {
               MessageBox.Show("Tem de selecionar um livro");
                return;
            }

            if( MessageBox.Show("Tem a certeza que pretende eliminar o livro selecionado?",
                                "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {
                livro apagar = new livro(bd);
                apagar.nlivro = nlivro_escolhido;
                apagar.apagar();
                nlivro_escolhido = 0;
                ListarLivros();
                limparForm();
               }



        

        }
        /// <summary>
        /// Sempre que o utilizador altera o texto filtra os livros da datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbpesquisa_TextChanged(object sender, EventArgs e)
        {
            livro l=new livro(bd);
            dgv_livros.DataSource = l.procurar("titulo", tbpesquisa.Text);
        }
        /// <summary>
        /// IMPRIMIR A DATAGRID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btimprimir_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape=true;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Impressora imprime= new Impressora();
            imprime.imprimeGrelha(printDocument1, e, dgv_livros);
        }

        private void dgv_livros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    } 
}