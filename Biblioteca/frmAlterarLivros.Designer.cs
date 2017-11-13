namespace Biblioteca
{
    partial class frmAlterarLivros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarLivros));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.rdbDisponivel = new System.Windows.Forms.RadioButton();
            this.rdbIndisponivel = new System.Windows.Forms.RadioButton();
            this.txtPaginas = new System.Windows.Forms.NumericUpDown();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 267);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(128, 52);
            this.btnGravar.Text = "Gravar dados";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 52);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(14, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 18);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNome.Location = new System.Drawing.Point(14, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(110, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Livro";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAutor.Location = new System.Drawing.Point(14, 90);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(45, 18);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAno.Location = new System.Drawing.Point(14, 125);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(36, 18);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 12F);
            this.lblGenero.Location = new System.Drawing.Point(14, 160);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(60, 18);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Gênero";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEditora.Location = new System.Drawing.Point(14, 195);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(59, 18);
            this.lblEditora.TabIndex = 6;
            this.lblEditora.Text = "Editora";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPaginas.Location = new System.Drawing.Point(273, 125);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(66, 18);
            this.lblPaginas.TabIndex = 7;
            this.lblPaginas.Text = "Páginas";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.lblStatus.Location = new System.Drawing.Point(14, 230);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 18);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(142, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(325, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(142, 88);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(325, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(142, 158);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(325, 20);
            this.txtGenero.TabIndex = 6;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(142, 193);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(325, 20);
            this.txtEditora.TabIndex = 7;
            this.txtEditora.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(142, 123);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(115, 20);
            this.txtAno.TabIndex = 4;
            // 
            // rdbDisponivel
            // 
            this.rdbDisponivel.AutoSize = true;
            this.rdbDisponivel.Checked = true;
            this.rdbDisponivel.Font = new System.Drawing.Font("Arial", 12F);
            this.rdbDisponivel.Location = new System.Drawing.Point(142, 226);
            this.rdbDisponivel.Name = "rdbDisponivel";
            this.rdbDisponivel.Size = new System.Drawing.Size(98, 22);
            this.rdbDisponivel.TabIndex = 8;
            this.rdbDisponivel.TabStop = true;
            this.rdbDisponivel.Text = "Disponível";
            this.rdbDisponivel.UseVisualStyleBackColor = true;
            // 
            // rdbIndisponivel
            // 
            this.rdbIndisponivel.AutoSize = true;
            this.rdbIndisponivel.Font = new System.Drawing.Font("Arial", 12F);
            this.rdbIndisponivel.Location = new System.Drawing.Point(259, 226);
            this.rdbIndisponivel.Name = "rdbIndisponivel";
            this.rdbIndisponivel.Size = new System.Drawing.Size(106, 22);
            this.rdbIndisponivel.TabIndex = 9;
            this.rdbIndisponivel.Text = "Indisponível";
            this.rdbIndisponivel.UseVisualStyleBackColor = true;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(345, 123);
            this.txtPaginas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(120, 20);
            this.txtPaginas.TabIndex = 5;
            // 
            // epErro
            // 
            this.epErro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epErro.ContainerControl = this;
            // 
            // frmAlterarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 322);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.rdbIndisponivel);
            this.Controls.Add(this.rdbDisponivel);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmAlterarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Livros";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtAutor;
        public System.Windows.Forms.TextBox txtGenero;
        public System.Windows.Forms.TextBox txtEditora;
        public System.Windows.Forms.MaskedTextBox txtAno;
        public System.Windows.Forms.RadioButton rdbDisponivel;
        public System.Windows.Forms.RadioButton rdbIndisponivel;
        public System.Windows.Forms.NumericUpDown txtPaginas;
        private System.Windows.Forms.ErrorProvider epErro;
    }
}