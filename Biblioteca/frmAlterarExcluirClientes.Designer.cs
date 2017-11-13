namespace Biblioteca
{
    partial class frmAlterarExcluirClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarExcluirClientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDS = new Biblioteca.BibliotecaDS();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Biblioteca.BibliotecaDSTableAdapters.ClientesTableAdapter();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
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
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.enderecoClienteDataGridViewTextBoxColumn,
            this.cidadeClienteDataGridViewTextBoxColumn,
            this.estadoClienteDataGridViewTextBoxColumn,
            this.telefoneClienteDataGridViewTextBoxColumn,
            this.statusClienteDataGridViewTextBoxColumn,
            this.Editar,
            this.Excluir});
            this.dgvDados.DataSource = this.clientesBindingSource;
            this.dgvDados.Location = new System.Drawing.Point(17, 56);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(490, 225);
            this.dgvDados.TabIndex = 2;
            this.dgvDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDados_CellMouseClick);
            // 
            // bibliotecaDS
            // 
            this.bibliotecaDS.DataSetName = "BibliotecaDS";
            this.bibliotecaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.bibliotecaDS;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "Nome_Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoClienteDataGridViewTextBoxColumn
            // 
            this.enderecoClienteDataGridViewTextBoxColumn.DataPropertyName = "Endereco_Cliente";
            this.enderecoClienteDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoClienteDataGridViewTextBoxColumn.Name = "enderecoClienteDataGridViewTextBoxColumn";
            this.enderecoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeClienteDataGridViewTextBoxColumn
            // 
            this.cidadeClienteDataGridViewTextBoxColumn.DataPropertyName = "Cidade_Cliente";
            this.cidadeClienteDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeClienteDataGridViewTextBoxColumn.Name = "cidadeClienteDataGridViewTextBoxColumn";
            this.cidadeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoClienteDataGridViewTextBoxColumn
            // 
            this.estadoClienteDataGridViewTextBoxColumn.DataPropertyName = "Estado_Cliente";
            this.estadoClienteDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoClienteDataGridViewTextBoxColumn.Name = "estadoClienteDataGridViewTextBoxColumn";
            this.estadoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneClienteDataGridViewTextBoxColumn
            // 
            this.telefoneClienteDataGridViewTextBoxColumn.DataPropertyName = "Telefone_Cliente";
            this.telefoneClienteDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneClienteDataGridViewTextBoxColumn.Name = "telefoneClienteDataGridViewTextBoxColumn";
            this.telefoneClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusClienteDataGridViewTextBoxColumn
            // 
            this.statusClienteDataGridViewTextBoxColumn.DataPropertyName = "Status_Cliente";
            this.statusClienteDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusClienteDataGridViewTextBoxColumn.Name = "statusClienteDataGridViewTextBoxColumn";
            this.statusClienteDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frmAlterarExcluirClientes
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
            this.Name = "frmAlterarExcluirClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar / Excluir Clientes";
            this.Load += new System.EventHandler(this.frmAlterarExcluirClientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BibliotecaDSTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}