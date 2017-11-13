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
    public partial class frmClientes : Form
    {
        public frmClientes()
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

        frmConsultaCliente objfrmConsultaClientes = new frmConsultaCliente();
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (objfrmConsultaClientes.IsDisposed)
            {
                objfrmConsultaClientes = new frmConsultaCliente();
            }

            objfrmConsultaClientes.MdiParent = this;
            this.DesabilitaBotoes(sender, e);
            objfrmConsultaClientes.btnVoltar.Click += new
           EventHandler(this.HabilitaBotoes);
            objfrmConsultaClientes.FormClosing += this.HabilitaBotoes;
            if (objfrmConsultaClientes.Visible == false)
            {
                objfrmConsultaClientes.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto!", "Biblioteca",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //O objeto está sendo criado fora do método para que o mesmo possa estar
        //ativo na memória enquanto o form estiver aberto. Se estiver dentro do
        //método será criado quando o método entrar em execução e morrerá quando
        //terminar sua execução, ou seja, toda vez que clicar no botão irá criar
        //um novo objeto
        frmCadastrarClientes objfrmCadastrarClientes = new frmCadastrarClientes();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //Se objeto não estiver criado, então crio novamente. Isso é necessário,
            //pois ao fechar o form filho ele deixa de exister, aí se eu clicar
            //novamente no botão Cadastrar do form pai não irá funcionar mais.
            if (objfrmCadastrarClientes.IsDisposed)
            {
                objfrmCadastrarClientes = new frmCadastrarClientes();
            }

            //Informo a aplicação que este objeto é o form filho do frmClientes
            objfrmCadastrarClientes.MdiParent = this;
            //chamo o método que desativa os botoes do formulário pai
            this.DesabilitaBotoes(sender, e);
            //vinculo ao botão cancelar do formulário filho o método para ativar
            //os botões do formulário pai
            objfrmCadastrarClientes.btnCancelar.Click += new
           EventHandler(this.HabilitaBotoes);
            //Vinculo a execução do método HabilitaBotoes no ao fechar do objeto
            //Cadastrar Clientes (tela)
            objfrmCadastrarClientes.FormClosing += this.HabilitaBotoes;
            //Verifica se o formulário filho já está aberto. Se estiver não permito
            //abrir novamente.
            if (objfrmCadastrarClientes.Visible == false)
            {
                objfrmCadastrarClientes.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto!", "Biblioteca",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAlterarExcluir_Click(object sender, EventArgs e)
        {
            frmAlterarExcluirClientes objfrmAlterarExcluirClientes = new
           frmAlterarExcluirClientes();

            objfrmAlterarExcluirClientes.MdiParent = this;
            this.DesabilitaBotoes(sender, e);

            objfrmAlterarExcluirClientes.btnVoltar.Click += new
           EventHandler(this.HabilitaBotoes);

            objfrmAlterarExcluirClientes.FormClosing += this.HabilitaBotoes;
            objfrmAlterarExcluirClientes.Show();
        }
    }
}
