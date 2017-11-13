using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class frmAlterarFuncionarios : Form
    {
        public frmAlterarFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            AlterarDados();
        }

        private void AlterarDados()
        {
            bool camposValidos = false;
            try
            {
                SqlConnection objConexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Biblioteca.mdf;Integrated Security=True;Connect Timeout=30");
                string strConn = @"UPDATE FUNCIONARIOS SET Nome_Funcionario = @Nome,
 Endereco_Funcionario = @Endereco, Cidade_Funcionario = @Cidade,
 Estado_Funcionario = @Estado, Telefone_Funcionario = @Telefone,
 Cargo_Funcionario = @Cargo, Data_Admissao_Funcionario = @DataAdm,
 Data_Demissao_Funcionario = @DataDem WHERE Id_Funcionario = " +
                Convert.ToUInt32(txtCodigo.Text);
                SqlCommand objCommand = new SqlCommand(strConn, objConexao);
                #region Validações dos Campos
                //Nome do Fubncinario
                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", txtNome.Text);
                    camposValidos = true;
                    epErro.SetError(txtNome, null);
                }
                else
                {
                    epErro.SetError(txtNome, "O campo nome é obrigatório");
                    camposValidos = false;
                }
                //Endereco
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
                //Cidade
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
                if (cboEstado.SelectedIndex > -1)
                {
                    objCommand.Parameters.AddWithValue("@Estado", cboEstado.SelectedItem);
                    camposValidos = true;
                    epErro.SetError(cboEstado, null);
                }
                else
                {
                    epErro.SetError(cboEstado, "O campo Estado é obrigatório!");
                    camposValidos = false;
                }
                //Telefone
                if (!String.IsNullOrEmpty(txtTelefone.Text))
                {
                    objCommand.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                    camposValidos = true;
                }

                //Cargo
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
                }
                //Data de Demissão do Funcionário
                if (IsDate(txtDataDem.Text))
                {
                    objCommand.Parameters.AddWithValue("@DataDem", txtDataDem.Text);
                    camposValidos = true;
                    epErro.SetError(txtDataDem, null);
                }
                else
                    //DBNull.Value faz com que o parametro seja nulo. Se não fizer
                    //assim ele considera a máscara de entrada e tentará gravá-lo.
                    //Como não é date dará erro.
                    objCommand.Parameters.AddWithValue("@DataDem", DBNull.Value);
                #endregion
                if (camposValidos)
                {
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                    MessageBox.Show("Funcionário alterado com sucesso!", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //Estamos criando esta função por ela não existir no csharp.
        //Esta função recebe um valor do tipo string.
        //Se o valor recebido pela funçao for data então retorna true
        //senão false.
        private bool IsDate(string inputDate)
        {
            DateTime Temp;
            if (DateTime.TryParse(inputDate, out Temp) == true) return true;
            else return false;
        }
    }
}
