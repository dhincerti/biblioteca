namespace Biblioteca
{
    partial class frmAlterarExcluirFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarExcluirFuncionarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDS = new Biblioteca.BibliotecaDS();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new Biblioteca.BibliotecaDSTableAdapters.FuncionariosTableAdapter();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAdmissaoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDemissaoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
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
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.nomeFuncionarioDataGridViewTextBoxColumn,
            this.enderecoFuncionarioDataGridViewTextBoxColumn,
            this.cidadeFuncionarioDataGridViewTextBoxColumn,
            this.estadoFuncionarioDataGridViewTextBoxColumn,
            this.telefoneFuncionarioDataGridViewTextBoxColumn,
            this.cargoFuncionarioDataGridViewTextBoxColumn,
            this.dataAdmissaoFuncionarioDataGridViewTextBoxColumn,
            this.dataDemissaoFuncionarioDataGridViewTextBoxColumn,
            this.Editar,
            this.Excluir});
            this.dgvDados.DataSource = this.funcionariosBindingSource;
            this.dgvDados.Location = new System.Drawing.Point(17, 56);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(490, 225);
            this.dgvDados.TabIndex = 2;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            this.dgvDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDados_CellMouseClick);
            // 
            // bibliotecaDS
            // 
            this.bibliotecaDS.DataSetName = "BibliotecaDS";
            this.bibliotecaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.bibliotecaDS;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Funcionario";
            this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "Id_Funcionario";
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFuncionarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeFuncionarioDataGridViewTextBoxColumn
            // 
            this.nomeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Nome_Funcionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeFuncionarioDataGridViewTextBoxColumn.Name = "nomeFuncionarioDataGridViewTextBoxColumn";
            this.nomeFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoFuncionarioDataGridViewTextBoxColumn
            // 
            this.enderecoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Endereco_Funcionario";
            this.enderecoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Enderecoo";
            this.enderecoFuncionarioDataGridViewTextBoxColumn.Name = "enderecoFuncionarioDataGridViewTextBoxColumn";
            this.enderecoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeFuncionarioDataGridViewTextBoxColumn
            // 
            this.cidadeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Cidade_Funcionario";
            this.cidadeFuncionarioDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeFuncionarioDataGridViewTextBoxColumn.Name = "cidadeFuncionarioDataGridViewTextBoxColumn";
            this.cidadeFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoFuncionarioDataGridViewTextBoxColumn
            // 
            this.estadoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Estado_Funcionario";
            this.estadoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoFuncionarioDataGridViewTextBoxColumn.Name = "estadoFuncionarioDataGridViewTextBoxColumn";
            this.estadoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneFuncionarioDataGridViewTextBoxColumn
            // 
            this.telefoneFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Telefone_Funcionario";
            this.telefoneFuncionarioDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneFuncionarioDataGridViewTextBoxColumn.Name = "telefoneFuncionarioDataGridViewTextBoxColumn";
            this.telefoneFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoFuncionarioDataGridViewTextBoxColumn
            // 
            this.cargoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Cargo_Funcionario";
            this.cargoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoFuncionarioDataGridViewTextBoxColumn.Name = "cargoFuncionarioDataGridViewTextBoxColumn";
            this.cargoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAdmissaoFuncionarioDataGridViewTextBoxColumn
            // 
            this.dataAdmissaoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Data_Admissao_Funcionario";
            this.dataAdmissaoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Data_Admissao";
            this.dataAdmissaoFuncionarioDataGridViewTextBoxColumn.Name = "dataAdmissaoFuncionarioDataGridViewTextBoxColumn";
            this.dataAdmissaoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDemissaoFuncionarioDataGridViewTextBoxColumn
            // 
            this.dataDemissaoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "Data_Demissao_Funcionario";
            this.dataDemissaoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Data_Demissao";
            this.dataDemissaoFuncionarioDataGridViewTextBoxColumn.Name = "dataDemissaoFuncionarioDataGridViewTextBoxColumn";
            this.dataDemissaoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frmAlterarExcluirFuncionarios
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
            this.Name = "frmAlterarExcluirFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar / Excluir Clientes";
            this.Load += new System.EventHandler(this.frmAlterarExcluirFuncionarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private BibliotecaDSTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAdmissaoFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDemissaoFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}