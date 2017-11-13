using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void DesabilitaBotoes(object sender, EventArgs e)
        {
            btnAlterarExcluir.Enabled = false;
            btnCadastrar.Enabled = false;
            btnConsultar.Enabled = false;
            btnSair.Enabled = false;
            btnVoltar.Enabled = false;
        }

        private void HabilitaBotoes(object sender, EventArgs e)
        {
            btnAlterarExcluir.Enabled = true;
            btnCadastrar.Enabled = true;
            btnConsultar.Enabled = true;
            btnSair.Enabled = true;
            btnVoltar.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        frmCadastrarLivros objfrmCadastrarLivros = new frmCadastrarLivros();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (objfrmCadastrarLivros.IsDisposed)
            {
                objfrmCadastrarLivros = new frmCadastrarLivros();
            }
            objfrmCadastrarLivros.MdiParent = this;
            this.DesabilitaBotoes(sender, e);
            objfrmCadastrarLivros.btnCancelar.Click += new
           EventHandler(this.HabilitaBotoes);
            objfrmCadastrarLivros.FormClosing += this.HabilitaBotoes;
            if (objfrmCadastrarLivros.Visible == false)
            {
                objfrmCadastrarLivros.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto!", "Biblioteca",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        frmConsultaLivros objfrmConsultarLivros = new frmConsultaLivros();
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (objfrmConsultarLivros.IsDisposed)
            {
                objfrmConsultarLivros = new frmConsultaLivros();
            }
            objfrmConsultarLivros.MdiParent = this;
            this.DesabilitaBotoes(sender, e);
            objfrmConsultarLivros.btnVoltar.Click += new EventHandler(this.HabilitaBotoes);
            objfrmConsultarLivros.FormClosing += this.HabilitaBotoes;
            if (objfrmConsultarLivros.Visible == false)
            {
                objfrmConsultarLivros.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto!", "Biblioteca",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAlterarExcluir_Click(object sender, EventArgs e)
        {
            frmAlterarExcluirLivros objfrmAlterarExcluirLivros = new
           frmAlterarExcluirLivros();
            objfrmAlterarExcluirLivros.MdiParent = this;
            this.DesabilitaBotoes(sender, e);
            objfrmAlterarExcluirLivros.btnVoltar.Click += new
           EventHandler(this.HabilitaBotoes);

            objfrmAlterarExcluirLivros.FormClosing += this.HabilitaBotoes;
            objfrmAlterarExcluirLivros.Show();
        }
    }
}
