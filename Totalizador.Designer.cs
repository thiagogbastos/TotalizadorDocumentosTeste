
namespace TotalizadorDocumentosTeste
{
    partial class Totalizador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarPastaRaiz = new System.Windows.Forms.Button();
            this.txtPastaRaiz = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnTotalizador = new System.Windows.Forms.Button();
            this.lstAnos = new System.Windows.Forms.ListBox();
            this.ListMeses = new System.Windows.Forms.ListBox();
            this.lblTituloTotalizador = new System.Windows.Forms.Label();
            this.lstArquivosEscaneados = new System.Windows.Forms.ListBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.LstCategoria = new System.Windows.Forms.ListBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTituloTotalAno = new System.Windows.Forms.Label();
            this.lblTituloTotalMes = new System.Windows.Forms.Label();
            this.lblTituloTotalCategoria = new System.Windows.Forms.Label();
            this.lblTotalAno = new System.Windows.Forms.Label();
            this.lblTotalMes = new System.Windows.Forms.Label();
            this.lblTotalCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasta raiz:";
            // 
            // btnBuscarPastaRaiz
            // 
            this.btnBuscarPastaRaiz.Location = new System.Drawing.Point(281, 53);
            this.btnBuscarPastaRaiz.Name = "btnBuscarPastaRaiz";
            this.btnBuscarPastaRaiz.Size = new System.Drawing.Size(122, 23);
            this.btnBuscarPastaRaiz.TabIndex = 1;
            this.btnBuscarPastaRaiz.Text = "Selecionar pasta";
            this.btnBuscarPastaRaiz.UseVisualStyleBackColor = true;
            this.btnBuscarPastaRaiz.Click += new System.EventHandler(this.btnBuscarPastaRaiz_Click);
            // 
            // txtPastaRaiz
            // 
            this.txtPastaRaiz.Enabled = false;
            this.txtPastaRaiz.Location = new System.Drawing.Point(15, 56);
            this.txtPastaRaiz.Name = "txtPastaRaiz";
            this.txtPastaRaiz.Size = new System.Drawing.Size(260, 20);
            this.txtPastaRaiz.TabIndex = 2;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\Public\\Documents\\Documentos Regina";
            // 
            // btnTotalizador
            // 
            this.btnTotalizador.Enabled = false;
            this.btnTotalizador.Location = new System.Drawing.Point(281, 82);
            this.btnTotalizador.Name = "btnTotalizador";
            this.btnTotalizador.Size = new System.Drawing.Size(122, 23);
            this.btnTotalizador.TabIndex = 3;
            this.btnTotalizador.Text = "Mostrar totalizadores";
            this.btnTotalizador.UseVisualStyleBackColor = true;
            this.btnTotalizador.Click += new System.EventHandler(this.btnTotalizador_Click);
            // 
            // lstAnos
            // 
            this.lstAnos.FormattingEnabled = true;
            this.lstAnos.Location = new System.Drawing.Point(12, 124);
            this.lstAnos.Name = "lstAnos";
            this.lstAnos.Size = new System.Drawing.Size(88, 69);
            this.lstAnos.TabIndex = 4;
            this.lstAnos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAnos_MouseClick);
            // 
            // ListMeses
            // 
            this.ListMeses.FormattingEnabled = true;
            this.ListMeses.Location = new System.Drawing.Point(106, 124);
            this.ListMeses.Name = "ListMeses";
            this.ListMeses.Size = new System.Drawing.Size(88, 69);
            this.ListMeses.TabIndex = 5;
            this.ListMeses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListMeses_MouseClick);
            // 
            // lblTituloTotalizador
            // 
            this.lblTituloTotalizador.AutoSize = true;
            this.lblTituloTotalizador.Location = new System.Drawing.Point(9, 334);
            this.lblTituloTotalizador.Name = "lblTituloTotalizador";
            this.lblTituloTotalizador.Size = new System.Drawing.Size(70, 13);
            this.lblTituloTotalizador.TabIndex = 7;
            this.lblTituloTotalizador.Text = "Totalizadores";
            // 
            // lstArquivosEscaneados
            // 
            this.lstArquivosEscaneados.FormattingEnabled = true;
            this.lstArquivosEscaneados.HorizontalScrollbar = true;
            this.lstArquivosEscaneados.Location = new System.Drawing.Point(12, 199);
            this.lstArquivosEscaneados.Name = "lstArquivosEscaneados";
            this.lstArquivosEscaneados.Size = new System.Drawing.Size(276, 121);
            this.lstArquivosEscaneados.TabIndex = 8;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(12, 108);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 9;
            this.lblAno.Text = "Ano";
            // 
            // LstCategoria
            // 
            this.LstCategoria.FormattingEnabled = true;
            this.LstCategoria.Location = new System.Drawing.Point(200, 124);
            this.LstCategoria.Name = "LstCategoria";
            this.LstCategoria.Size = new System.Drawing.Size(88, 69);
            this.LstCategoria.TabIndex = 10;
            this.LstCategoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstCategoria_MouseClick);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(105, 108);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 11;
            this.lblMes.Text = "Mês";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(197, 108);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblTituloTotalAno
            // 
            this.lblTituloTotalAno.AutoSize = true;
            this.lblTituloTotalAno.Location = new System.Drawing.Point(12, 388);
            this.lblTituloTotalAno.Name = "lblTituloTotalAno";
            this.lblTituloTotalAno.Size = new System.Drawing.Size(26, 13);
            this.lblTituloTotalAno.TabIndex = 13;
            this.lblTituloTotalAno.Text = "Ano";
            // 
            // lblTituloTotalMes
            // 
            this.lblTituloTotalMes.AutoSize = true;
            this.lblTituloTotalMes.Location = new System.Drawing.Point(11, 412);
            this.lblTituloTotalMes.Name = "lblTituloTotalMes";
            this.lblTituloTotalMes.Size = new System.Drawing.Size(27, 13);
            this.lblTituloTotalMes.TabIndex = 14;
            this.lblTituloTotalMes.Text = "Mês";
            // 
            // lblTituloTotalCategoria
            // 
            this.lblTituloTotalCategoria.AutoSize = true;
            this.lblTituloTotalCategoria.Location = new System.Drawing.Point(9, 438);
            this.lblTituloTotalCategoria.Name = "lblTituloTotalCategoria";
            this.lblTituloTotalCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblTituloTotalCategoria.TabIndex = 15;
            this.lblTituloTotalCategoria.Text = "Categoria";
            // 
            // lblTotalAno
            // 
            this.lblTotalAno.AutoSize = true;
            this.lblTotalAno.Location = new System.Drawing.Point(53, 388);
            this.lblTotalAno.Name = "lblTotalAno";
            this.lblTotalAno.Size = new System.Drawing.Size(25, 13);
            this.lblTotalAno.TabIndex = 16;
            this.lblTotalAno.Text = "------";
            // 
            // lblTotalMes
            // 
            this.lblTotalMes.AutoSize = true;
            this.lblTotalMes.Location = new System.Drawing.Point(53, 412);
            this.lblTotalMes.Name = "lblTotalMes";
            this.lblTotalMes.Size = new System.Drawing.Size(25, 13);
            this.lblTotalMes.TabIndex = 17;
            this.lblTotalMes.Text = "------";
            // 
            // lblTotalCategoria
            // 
            this.lblTotalCategoria.AutoSize = true;
            this.lblTotalCategoria.Location = new System.Drawing.Point(67, 438);
            this.lblTotalCategoria.Name = "lblTotalCategoria";
            this.lblTotalCategoria.Size = new System.Drawing.Size(25, 13);
            this.lblTotalCategoria.TabIndex = 18;
            this.lblTotalCategoria.Text = "------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 478);
            this.Controls.Add(this.lblTotalCategoria);
            this.Controls.Add(this.lblTotalMes);
            this.Controls.Add(this.lblTotalAno);
            this.Controls.Add(this.lblTituloTotalCategoria);
            this.Controls.Add(this.lblTituloTotalMes);
            this.Controls.Add(this.lblTituloTotalAno);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.LstCategoria);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lstArquivosEscaneados);
            this.Controls.Add(this.lblTituloTotalizador);
            this.Controls.Add(this.ListMeses);
            this.Controls.Add(this.lstAnos);
            this.Controls.Add(this.btnTotalizador);
            this.Controls.Add(this.txtPastaRaiz);
            this.Controls.Add(this.btnBuscarPastaRaiz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPastaRaiz;
        private System.Windows.Forms.TextBox txtPastaRaiz;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnTotalizador;
        private System.Windows.Forms.ListBox lstAnos;
        private System.Windows.Forms.ListBox ListMeses;
        private System.Windows.Forms.Label lblTituloTotalizador;
        private System.Windows.Forms.ListBox lstArquivosEscaneados;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ListBox LstCategoria;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTituloTotalAno;
        private System.Windows.Forms.Label lblTituloTotalMes;
        private System.Windows.Forms.Label lblTituloTotalCategoria;
        private System.Windows.Forms.Label lblTotalAno;
        private System.Windows.Forms.Label lblTotalMes;
        private System.Windows.Forms.Label lblTotalCategoria;
    }
}

