namespace M17A_Prototipo_2025_26_12T.Livro
{
    partial class F_livro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_livro));
            this.label1 = new System.Windows.Forms.Label();
            this.TBTITULO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBAUTOR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBANO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPDATA = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TBPRECO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PBCAPA = new System.Windows.Forms.PictureBox();
            this.BTPROCURAR = new System.Windows.Forms.Button();
            this.BTGUARDAR = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TBISBN = new System.Windows.Forms.TextBox();
            this.LBFEEDBACK = new System.Windows.Forms.Label();
            this.dgv_livros = new System.Windows.Forms.DataGridView();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btimprimir = new System.Windows.Forms.Button();
            this.tbpesquisa = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.PBCAPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Insira um Livro";
            // 
            // TBTITULO
            // 
            this.TBTITULO.Location = new System.Drawing.Point(16, 83);
            this.TBTITULO.Name = "TBTITULO";
            this.TBTITULO.Size = new System.Drawing.Size(141, 20);
            this.TBTITULO.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Autor";
            // 
            // TBAUTOR
            // 
            this.TBAUTOR.Location = new System.Drawing.Point(15, 121);
            this.TBAUTOR.Name = "TBAUTOR";
            this.TBAUTOR.Size = new System.Drawing.Size(141, 20);
            this.TBAUTOR.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ano";
            // 
            // TBANO
            // 
            this.TBANO.Location = new System.Drawing.Point(15, 160);
            this.TBANO.Name = "TBANO";
            this.TBANO.Size = new System.Drawing.Size(141, 20);
            this.TBANO.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data Aquisição";
            // 
            // DTPDATA
            // 
            this.DTPDATA.Location = new System.Drawing.Point(15, 207);
            this.DTPDATA.Name = "DTPDATA";
            this.DTPDATA.Size = new System.Drawing.Size(141, 20);
            this.DTPDATA.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Preço";
            // 
            // TBPRECO
            // 
            this.TBPRECO.Location = new System.Drawing.Point(15, 246);
            this.TBPRECO.Name = "TBPRECO";
            this.TBPRECO.Size = new System.Drawing.Size(141, 20);
            this.TBPRECO.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Capa";
            // 
            // PBCAPA
            // 
            this.PBCAPA.Location = new System.Drawing.Point(1, 297);
            this.PBCAPA.Name = "PBCAPA";
            this.PBCAPA.Size = new System.Drawing.Size(206, 180);
            this.PBCAPA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBCAPA.TabIndex = 29;
            this.PBCAPA.TabStop = false;
            // 
            // BTPROCURAR
            // 
            this.BTPROCURAR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTPROCURAR.Location = new System.Drawing.Point(63, 267);
            this.BTPROCURAR.Name = "BTPROCURAR";
            this.BTPROCURAR.Size = new System.Drawing.Size(84, 27);
            this.BTPROCURAR.TabIndex = 30;
            this.BTPROCURAR.Text = "Procurar...";
            this.BTPROCURAR.UseVisualStyleBackColor = false;
            this.BTPROCURAR.Click += new System.EventHandler(this.BTPROCURAR_Click_1);
            // 
            // BTGUARDAR
            // 
            this.BTGUARDAR.Location = new System.Drawing.Point(153, 269);
            this.BTGUARDAR.Name = "BTGUARDAR";
            this.BTGUARDAR.Size = new System.Drawing.Size(54, 23);
            this.BTGUARDAR.TabIndex = 31;
            this.BTGUARDAR.Text = "Guardar";
            this.BTGUARDAR.UseVisualStyleBackColor = true;
            this.BTGUARDAR.Click += new System.EventHandler(this.BTGUARDAR_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Isbn";
            // 
            // TBISBN
            // 
            this.TBISBN.Location = new System.Drawing.Point(16, 44);
            this.TBISBN.Name = "TBISBN";
            this.TBISBN.Size = new System.Drawing.Size(141, 20);
            this.TBISBN.TabIndex = 33;
            // 
            // LBFEEDBACK
            // 
            this.LBFEEDBACK.AutoSize = true;
            this.LBFEEDBACK.Location = new System.Drawing.Point(228, 458);
            this.LBFEEDBACK.Name = "LBFEEDBACK";
            this.LBFEEDBACK.Size = new System.Drawing.Size(0, 13);
            this.LBFEEDBACK.TabIndex = 34;
            // 
            // dgv_livros
            // 
            this.dgv_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_livros.Location = new System.Drawing.Point(231, 65);
            this.dgv_livros.Name = "dgv_livros";
            this.dgv_livros.Size = new System.Drawing.Size(430, 316);
            this.dgv_livros.TabIndex = 35;
            this.dgv_livros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_livros_CellClick);
            this.dgv_livros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_livros_CellContentClick);
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(231, 407);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(129, 39);
            this.bteliminar.TabIndex = 36;
            this.bteliminar.Text = "eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // btimprimir
            // 
            this.btimprimir.Location = new System.Drawing.Point(555, 407);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(106, 39);
            this.btimprimir.TabIndex = 38;
            this.btimprimir.Text = "Imprimir";
            this.btimprimir.UseVisualStyleBackColor = true;
            this.btimprimir.Click += new System.EventHandler(this.btimprimir_Click);
            // 
            // tbpesquisa
            // 
            this.tbpesquisa.Location = new System.Drawing.Point(231, 13);
            this.tbpesquisa.Name = "tbpesquisa";
            this.tbpesquisa.Size = new System.Drawing.Size(430, 20);
            this.tbpesquisa.TabIndex = 39;
            this.tbpesquisa.TextChanged += new System.EventHandler(this.tbpesquisa_TextChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // F_livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.tbpesquisa);
            this.Controls.Add(this.btimprimir);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.dgv_livros);
            this.Controls.Add(this.LBFEEDBACK);
            this.Controls.Add(this.TBISBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTGUARDAR);
            this.Controls.Add(this.BTPROCURAR);
            this.Controls.Add(this.PBCAPA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBPRECO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPDATA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBANO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBAUTOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBTITULO);
            this.Controls.Add(this.label1);
            this.Name = "F_livro";
            this.Text = "F_livro";
            this.Load += new System.EventHandler(this.F_livro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBCAPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBTITULO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBAUTOR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBANO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPDATA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBPRECO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox PBCAPA;
        private System.Windows.Forms.Button BTPROCURAR;
        private System.Windows.Forms.Button BTGUARDAR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBISBN;
        private System.Windows.Forms.Label LBFEEDBACK;
        private System.Windows.Forms.DataGridView dgv_livros;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btimprimir;
        private System.Windows.Forms.TextBox tbpesquisa;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}