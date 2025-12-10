namespace M17A_Prototipo_2025_26_12T.Emprestimo
{
    partial class F_emprestimo
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
            this.CBLIVRO = new System.Windows.Forms.ComboBox();
            this.CBLEITOR = new System.Windows.Forms.ComboBox();
            this.TBEMPRESTAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBLIVRO
            // 
            this.CBLIVRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLIVRO.FormattingEnabled = true;
            this.CBLIVRO.Location = new System.Drawing.Point(107, 39);
            this.CBLIVRO.Name = "CBLIVRO";
            this.CBLIVRO.Size = new System.Drawing.Size(304, 21);
            this.CBLIVRO.TabIndex = 0;
            // 
            // CBLEITOR
            // 
            this.CBLEITOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLEITOR.FormattingEnabled = true;
            this.CBLEITOR.Location = new System.Drawing.Point(107, 70);
            this.CBLEITOR.Name = "CBLEITOR";
            this.CBLEITOR.Size = new System.Drawing.Size(304, 21);
            this.CBLEITOR.TabIndex = 1;
            // 
            // TBEMPRESTAR
            // 
            this.TBEMPRESTAR.Location = new System.Drawing.Point(107, 110);
            this.TBEMPRESTAR.Name = "TBEMPRESTAR";
            this.TBEMPRESTAR.Size = new System.Drawing.Size(304, 23);
            this.TBEMPRESTAR.TabIndex = 2;
            this.TBEMPRESTAR.Text = "Emprestar";
            this.TBEMPRESTAR.UseVisualStyleBackColor = true;
            this.TBEMPRESTAR.Click += new System.EventHandler(this.TBEMPRESTAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leitor";
            // 
            // F_emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBEMPRESTAR);
            this.Controls.Add(this.CBLEITOR);
            this.Controls.Add(this.CBLIVRO);
            this.Name = "F_emprestimo";
            this.Text = "F_emprestimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBLIVRO;
        private System.Windows.Forms.ComboBox CBLEITOR;
        private System.Windows.Forms.Button TBEMPRESTAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}