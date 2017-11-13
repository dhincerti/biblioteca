namespace Biblioteca
{
    partial class frmCadastrarFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarFuncionarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDataAdm = new System.Windows.Forms.Label();
            this.lblDataDem = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtDataAdm = new System.Windows.Forms.MaskedTextBox();
            this.txtDataDem = new System.Windows.Forms.MaskedTextBox();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
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
            this.btnCancelar.Size = new System.Drawing.Size(160, 52);
            this.btnCancelar.Text = "Cancelar Cadastros";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVoltar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 307);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(534, 55);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Enabled = false;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 52);
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblName.Location = new System.Drawing.Point(16, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome Completo";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEnd.Location = new System.Drawing.Point(16, 117);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(76, 18);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Endereço";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCid.Location = new System.Drawing.Point(16, 151);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(60, 18);
            this.lblCid.TabIndex = 4;
            this.lblCid.Text = "Cidade";
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEst.Location = new System.Drawing.Point(16, 186);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(58, 18);
            this.lblEst.TabIndex = 5;
            this.lblEst.Text = "Estado";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTel.Location = new System.Drawing.Point(16, 223);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(66, 18);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Telefone";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCargo.Location = new System.Drawing.Point(16, 256);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 18);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDataAdm
            // 
            this.lblDataAdm.AutoSize = true;
            this.lblDataAdm.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDataAdm.Location = new System.Drawing.Point(278, 186);
            this.lblDataAdm.Name = "lblDataAdm";
            this.lblDataAdm.Size = new System.Drawing.Size(116, 18);
            this.lblDataAdm.TabIndex = 8;
            this.lblDataAdm.Text = "Data Admissão";
            // 
            // lblDataDem
            // 
            this.lblDataDem.AutoSize = true;
            this.lblDataDem.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDataDem.Location = new System.Drawing.Point(278, 223);
            this.lblDataDem.Name = "lblDataDem";
            this.lblDataDem.Size = new System.Drawing.Size(118, 18);
            this.lblDataDem.TabIndex = 9;
            this.lblDataDem.Text = "Data Demissão";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(145, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(360, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(145, 114);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(360, 20);
            this.txtEnd.TabIndex = 2;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(145, 148);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(360, 20);
            this.txtCid.TabIndex = 3;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(145, 253);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(360, 20);
            this.txtCargo.TabIndex = 8;
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
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(145, 183);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(145, 220);
            this.txtTel.Mask = "(99) 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 5;
            // 
            // txtDataAdm
            // 
            this.txtDataAdm.Location = new System.Drawing.Point(405, 187);
            this.txtDataAdm.Mask = "00/00/00";
            this.txtDataAdm.Name = "txtDataAdm";
            this.txtDataAdm.Size = new System.Drawing.Size(100, 20);
            this.txtDataAdm.TabIndex = 6;
            // 
            // txtDataDem
            // 
            this.txtDataDem.Location = new System.Drawing.Point(405, 220);
            this.txtDataDem.Mask = "00/00/00";
            this.txtDataDem.Name = "txtDataDem";
            this.txtDataDem.Size = new System.Drawing.Size(100, 20);
            this.txtDataDem.TabIndex = 7;
            // 
            // epErro
            // 
            this.epErro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epErro.ContainerControl = this;
            // 
            // frmCadastrarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.Controls.Add(this.txtDataDem);
            this.Controls.Add(this.txtDataAdm);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDataDem);
            this.Controls.Add(this.lblDataAdm);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmCadastrarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir Funcionários";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton btnGravar;
        public System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDataAdm;
        private System.Windows.Forms.Label lblDataDem;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtDataAdm;
        private System.Windows.Forms.MaskedTextBox txtDataDem;
        private System.Windows.Forms.ErrorProvider epErro;
    }
}