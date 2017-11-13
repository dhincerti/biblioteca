namespace Biblioteca
{
    partial class frmAlterarFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarFuncionarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDataAdm = new System.Windows.Forms.Label();
            this.lblDataDem = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtDataAdm = new System.Windows.Forms.MaskedTextBox();
            this.txtDataDem = new System.Windows.Forms.MaskedTextBox();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
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
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEnd.Location = new System.Drawing.Point(14, 90);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(76, 18);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Endereço";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCid.Location = new System.Drawing.Point(14, 125);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(60, 18);
            this.lblCid.TabIndex = 4;
            this.lblCid.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEstado.Location = new System.Drawing.Point(14, 160);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 18);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTelefone.Location = new System.Drawing.Point(14, 195);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 18);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCargo.Location = new System.Drawing.Point(14, 230);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 18);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDataAdm
            // 
            this.lblDataAdm.AutoSize = true;
            this.lblDataAdm.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDataAdm.Location = new System.Drawing.Point(273, 160);
            this.lblDataAdm.Name = "lblDataAdm";
            this.lblDataAdm.Size = new System.Drawing.Size(116, 18);
            this.lblDataAdm.TabIndex = 8;
            this.lblDataAdm.Text = "Data Admissão";
            // 
            // lblDataDem
            // 
            this.lblDataDem.AutoSize = true;
            this.lblDataDem.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDataDem.Location = new System.Drawing.Point(273, 195);
            this.lblDataDem.Name = "lblDataDem";
            this.lblDataDem.Size = new System.Drawing.Size(118, 18);
            this.lblDataDem.TabIndex = 9;
            this.lblDataDem.Text = "Data Demissão";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(144, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(352, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(142, 88);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(352, 20);
            this.txtEnd.TabIndex = 3;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(142, 123);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(352, 20);
            this.txtCid.TabIndex = 4;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(142, 228);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(352, 20);
            this.txtCargo.TabIndex = 7;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO "});
            this.cboEstado.Location = new System.Drawing.Point(144, 157);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(115, 21);
            this.cboEstado.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(144, 192);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(115, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // txtDataAdm
            // 
            this.txtDataAdm.Location = new System.Drawing.Point(396, 157);
            this.txtDataAdm.Mask = "00/00/00";
            this.txtDataAdm.Name = "txtDataAdm";
            this.txtDataAdm.Size = new System.Drawing.Size(100, 20);
            this.txtDataAdm.TabIndex = 8;
            // 
            // txtDataDem
            // 
            this.txtDataDem.Location = new System.Drawing.Point(396, 192);
            this.txtDataDem.Mask = "00/00/00";
            this.txtDataDem.Name = "txtDataDem";
            this.txtDataDem.Size = new System.Drawing.Size(100, 20);
            this.txtDataDem.TabIndex = 9;
            // 
            // epErro
            // 
            this.epErro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epErro.ContainerControl = this;
            // 
            // frmAlterarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 322);
            this.Controls.Add(this.txtDataDem);
            this.Controls.Add(this.txtDataAdm);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblDataDem);
            this.Controls.Add(this.lblDataAdm);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "frmAlterarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Funcionários";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDataAdm;
        private System.Windows.Forms.Label lblDataDem;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtEnd;
        public System.Windows.Forms.TextBox txtCid;
        public System.Windows.Forms.TextBox txtCargo;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.MaskedTextBox txtDataAdm;
        public System.Windows.Forms.MaskedTextBox txtDataDem;
        public System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ErrorProvider epErro;
    }
}