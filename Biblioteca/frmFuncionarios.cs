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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        public void DesabilitaBotoes(object sender, EventArgs e)
        {
            btnAlterarExcluir.Enabled = false;
            btnCadastrar.Enabled = false;
            btnConsultar.Enabled = false;
            btnSair.Enabled = false;
            btnVoltar.Enabled = false;
        }

        public void HabilitaBotoes(object sender, EventArgs e)
        {
            btnAlterarExcluir.Enabled = true;
            btnCadastrar.Enabled = true;
            btnConsultar.Enabled = true;
            btnSair.Enabled = true;
            btnVoltar.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //O objeto está sendo criado fora do método para que o mesmo
        //possa estar ativo na memória enquanto o form estiver aberto.
        //Se estiver dentro do método será criado quando o método entrar
        //em execução e morrerá quando terminar sua execução, ou seja,
        //toda vez que clicar no botão irá criar um novo objeto
        frmCadastrarFuncionarios objfrmCadastrarFuncionarios = new
        frmCadastrarFuncionarios();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Se objeto não estiver criado, então crio novamente.
            //Isso é necessário, pois ao fechar o form filho ele deixa
            //de existir, aí se eu clicar novamente no botão Cadastrar do
            //form pai não irá funcionar mais.
            if (objfrmCadastrarFuncionarios.IsDisposed)
            {
                objfrmCadastrarFuncionarios = new frmCadastrarFuncionarios();
            }
            //Informo a aplicação que este objeto é o form filho do frmFuncionaios
            objfrmCadastrarFuncionarios.MdiParent = this;
            //chamo o método que desativa os botoes do formulário pai
            this.DesabilitaBotoes(sender, e);
            //vinculo ao botão cancelar do formulário filho o método para
            //ativar os botões do formulário pai
            objfrmCadastrarFuncionarios.btnCancelar.Click += new
           EventHandler(this.HabilitaBotoes);
            //Vinculo a execução do método HabilitaBotoes no ao fechar
            //do objeto Cadastrar Funcionarios (tela)
            objfrmCadastrarFuncionarios.FormClosing += this.HabilitaBotoes;
            //Verifica se o formulário filho já está aberto. Se estiver
            //não permito abrir novamente.
            if (objfrmCadastrarFuncionarios.Visible == false)
            {
                objfrmCadastrarFuncionarios.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto!", "Biblioteca",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        frmConsultaFuncionarios objfrmConsultarFuncionarios = new
frmConsultaFuncionarios();
        private void btnConsultar_Click(object sender, EventArgs e)
{
 if (objfrmConsultarFuncionarios.IsDisposed)
 {
 objfrmConsultarFuncionarios = new frmConsultaFuncionarios();
 }
 objfrmConsultarFuncionarios.MdiParent = this;
 this.DesabilitaBotoes(sender, e);
 objfrmConsultarFuncionarios.btnVoltar.Click += new
EventHandler(this.HabilitaBotoes);
 objfrmConsultarFuncionarios.FormClosing += this.HabilitaBotoes;
 if (objfrmConsultarFuncionarios.Visible == false) {
 objfrmConsultarFuncionarios.Show();
 }
 else {
 MessageBox.Show("O formulário já está aberto!", "Biblioteca",
 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 }
}

        private void btnAlterarExcluir_Click(object sender, EventArgs e)
        {
            frmAlterarExcluirFuncionarios objfrmAlterarExcluirFuncionarios = new
           frmAlterarExcluirFuncionarios();
            objfrmAlterarExcluirFuncionarios.MdiParent = this;
            this.DesabilitaBotoes(sender, e);
            objfrmAlterarExcluirFuncionarios.btnVoltar.Click += new
           EventHandler(this.HabilitaBotoes);

            objfrmAlterarExcluirFuncionarios.FormClosing += this.HabilitaBotoes;
            objfrmAlterarExcluirFuncionarios.Show();
        }
    }
}
