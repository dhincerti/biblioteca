namespace Biblioteca
{
    partial class frmAlterarExcluirLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarExcluirLivros));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDS = new Biblioteca.BibliotecaDS();
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new Biblioteca.BibliotecaDSTableAdapters.LivrosTableAdapter();
            this.idLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginasLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 287);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 52);
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(13, 13);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(458, 19);
            this.lblMensagem.TabIndex = 1;
            this.lblMensagem.Text = "Selecione o Registro e clique no botão para Alterar / Excluir";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoGenerateColumns = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLivroDataGridViewTextBoxColumn,
            this.nomeLivroDataGridViewTextBoxColumn,
            this.autorLivroDataGridViewTextBoxColumn,
            this.anoLivroDataGridViewTextBoxColumn,
            this.generoLivroDataGridViewTextBoxColumn,
            this.editoraLivroDataGridViewTextBoxColumn,
            this.paginasLivroDataGridViewTextBoxColumn,
            this.statusLivroDataGridViewTextBoxColumn,
            this.Editar,
            this.Excluir});
            this.dgvDados.DataSource = this.livrosBindingSource;
            this.dgvDados.Location = new System.Drawing.Point(17, 56);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(490, 225);
            this.dgvDados.TabIndex = 2;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            this.dgvDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDados_CellMouseClick);
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bibliotecaDS;
            // 
            // bibliotecaDS
            // 
            this.bibliotecaDS.DataSetName = "BibliotecaDS";
            this.bibliotecaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // idLivroDataGridViewTextBoxColumn
            // 
            this.idLivroDataGridViewTextBoxColumn.DataPropertyName = "Id_Livro";
            this.idLivroDataGridViewTextBoxColumn.HeaderText = "Id_Livro";
            this.idLivroDataGridViewTextBoxColumn.Name = "idLivroDataGridViewTextBoxColumn";
            this.idLivroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLivroDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeLivroDataGridViewTextBoxColumn
            // 
            this.nomeLivroDataGridViewTextBoxColumn.DataPropertyName = "Nome_Livro";
            this.nomeLivroDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeLivroDataGridViewTextBoxColumn.Name = "nomeLivroDataGridViewTextBoxColumn";
            this.nomeLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorLivroDataGridViewTextBoxColumn
            // 
            this.autorLivroDataGridViewTextBoxColumn.DataPropertyName = "Autor_Livro";
            this.autorLivroDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorLivroDataGridViewTextBoxColumn.Name = "autorLivroDataGridViewTextBoxColumn";
            this.autorLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anoLivroDataGridViewTextBoxColumn
            // 
            this.anoLivroDataGridViewTextBoxColumn.DataPropertyName = "Ano_Livro";
            this.anoLivroDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoLivroDataGridViewTextBoxColumn.Name = "anoLivroDataGridViewTextBoxColumn";
            this.anoLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generoLivroDataGridViewTextBoxColumn
            // 
            this.generoLivroDataGridViewTextBoxColumn.DataPropertyName = "Genero_Livro";
            this.generoLivroDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoLivroDataGridViewTextBoxColumn.Name = "generoLivroDataGridViewTextBoxColumn";
            this.generoLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editoraLivroDataGridViewTextBoxColumn
            // 
            this.editoraLivroDataGridViewTextBoxColumn.DataPropertyName = "Editora_Livro";
            this.editoraLivroDataGridViewTextBoxColumn.HeaderText = "Editora";
            this.editoraLivroDataGridViewTextBoxColumn.Name = "editoraLivroDataGridViewTextBoxColumn";
            this.editoraLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paginasLivroDataGridViewTextBoxColumn
            // 
            this.paginasLivroDataGridViewTextBoxColumn.DataPropertyName = "Paginas_Livro";
            this.paginasLivroDataGridViewTextBoxColumn.HeaderText = "Paginas";
            this.paginasLivroDataGridViewTextBoxColumn.Name = "paginasLivroDataGridViewTextBoxColumn";
            this.paginasLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusLivroDataGridViewTextBoxColumn
            // 
            this.statusLivroDataGridViewTextBoxColumn.DataPropertyName = "Status_Livro";
            this.statusLivroDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusLivroDataGridViewTextBoxColumn.Name = "statusLivroDataGridViewTextBoxColumn";
            this.statusLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = ">";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 20;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "X";
            this.Excluir.UseColumnTextForButtonValue = true;
            this.Excluir.Width = 20;
            // 
            // frmAlterarExcluirLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(524, 342);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarExcluirLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar / Excluir Clientes";
            this.Load += new System.EventHandler(this.frmAlterarExcluirLivros_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource;
        private BibliotecaDS bibliotecaDS;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private BibliotecaDSTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editoraLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginasLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}