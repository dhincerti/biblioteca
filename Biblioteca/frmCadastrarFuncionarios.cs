using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmCadastrarFuncionarios : Form
    {
        public frmCadastrarFuncionarios()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            bool camposValidos = false;
            try
            {
                SqlConnection objConexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Biblioteca.mdf;Integrated Security=True;Connect Timeout=30");
                string strConn = @"INSERT INTO FUNCIONARIOS (Nome_Funcionario,
Endereco_Funcionario, Cidade_Funcionario, Estado_Funcionario,
Telefone_Funcionario, Cargo_Funcionario, Data_Admissao_Funcionario,
Data_Demissao_Funcionario) VALUES (@Nome, @Endereco, @Cidade,
@Estado, @Telefone, @Cargo, @DataAdm, @DataDem)";
                SqlCommand objCommand = new SqlCommand(strConn, objConexao);
                #region Validações dos Campos
                //Nome do funcionário
                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", txtNome.Text);
                    camposValidos = true;
                    epErro.SetError(txtNome, null);
                }
                else
                {
                    epErro.SetError(txtNome, "O campo Nome é obrigatório");
                    camposValidos = false;
                }
                //Endereço do Funcionáio
                if (!String.IsNullOrEmpty(txtEnd.Text))
                {
                    objCommand.Parameters.AddWithValue("@Endereco", txtEnd.Text);
                    camposValidos = true;
                    epErro.SetError(txtEnd, null);
                }
                else
                {
                    epErro.SetError(txtEnd, "O campo Endereço é obrigatório");
                    camposValidos = false;
                }
                //Cidade do Funcionário
                if (!String.IsNullOrEmpty(txtCid.Text))
                {
                    objCommand.Parameters.AddWithValue("@Cidade", txtCid.Text);
                    camposValidos = true;
                    epErro.SetError(txtCid, null);
                }
                else
                {
                    epErro.SetError(txtCid, "O campo Cidade é obrigatório");
                    camposValidos = false;
                }
                //Estado do Funcionário
                if (!String.IsNullOrEmpty(cboEstado.Text))
                {
                    objCommand.Parameters.AddWithValue("@Estado", cboEstado.Text);
                    camposValidos = true;
                    epErro.SetError(cboEstado, null);
                }
                else
                {
                    epErro.SetError(cboEstado, "O campo Estado é obrigatório");
                    camposValidos = false;
                }
                //Cargo do Funcionário
                if (!String.IsNullOrEmpty(txtCargo.Text))
                {
                    objCommand.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                    camposValidos = true;
                    epErro.SetError(txtCargo, null);
                }
                else
                {
                    epErro.SetError(txtCargo, "O campo Cargo é obrigatório");
                    camposValidos = false;
                }
                //Data de Admissão do Funcionário
                if (IsDate(txtDataAdm.Text))
                {
                    objCommand.Parameters.AddWithValue("@DataAdm", txtDataAdm.Text);
                    camposValidos = true;
                    epErro.SetError(txtDataAdm, null);
                }
                else
                {
                    epErro.SetError(txtDataAdm, "O campo Data de Admissão é obrigatório");
                    camposValidos = false;
                }//Data de Demissão do Funcionário
                if (IsDate(txtDataDem.Text))
                {
                    objCommand.Parameters.AddWithValue("@DataDem", txtDataDem.Text);
                    camposValidos = true;
                    epErro.SetError(txtDataDem, null);
                }
                else
                    //DBNull.Value faz com que o parametro seja nulo. Se não fizer
                    //assim, ele irá considerar a máscara de entrada e tentara
                    //gravá-lo. Como não é date dará erro.
                    objCommand.Parameters.AddWithValue("@DataDem", DBNull.Value);
                //Telefone do Funcionário
                objCommand.Parameters.AddWithValue("@Telefone", txtTel.Text);
                #endregion
                if (camposValidos)
                {
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                    MessageBox.Show("Registro inserido com sucesso!",
                   "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    txtNome.Focus();
                    btnVoltar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ops, ocorreram erros!\n\n Preencha os campos e tente novamente", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtCid.Text = "";
            cboEstado.Text = "";
            txtTel.Text = "";
            txtCargo.Text = "";
            txtDataAdm.Text = "";
            txtDataDem.Text = "";

        }
        //Estamos criando esta função por ela não existir no csharp.
        //Esta função recebe um valor do tipo string.
        //Se o valor recebido pela funçao for data então retorna true senão false.
        private bool IsDate(string inputDate)
        {

            DateTime Temp;
            if (DateTime.TryParse(inputDate, out Temp) == true) return true; else return false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
