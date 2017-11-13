using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Biblioteca
{
    public partial class frmAlterarClientes : Form
    {
        public frmAlterarClientes()
        {
            InitializeComponent();
        }

        private void frmAlterarClientes_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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
                string strConn = @"UPDATE CLIENTES SET Nome_Cliente = @Nome,
Endereco_Cliente = @Endereco, Cidade_Cliente = @Cidade, Estado_Cliente =
@Estado, Telefone_Cliente = @Telefone, Status_Cliente = @Status WHERE
Id_Cliente = " + Convert.ToUInt32(txtCodigo.Text);
                SqlCommand objCommand = new SqlCommand(strConn, objConexao);
                #region Validações dos Campos
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
                if (!String.IsNullOrEmpty(txtEnd.Text))
                {
                    objCommand.Parameters.AddWithValue("@Endereco", txtEnd.Text);
                    camposValidos = true;
                    epErro.SetError(txtEnd, null);
                }
                else
                {
                    epErro.SetError(txtEnd, "O campo endereço é obrigatório");
                    camposValidos = false;
                }
                if (!String.IsNullOrEmpty(txtCid.Text))
                {
                    objCommand.Parameters.AddWithValue("@Cidade", txtCid.Text);
                    camposValidos = true;
                    epErro.SetError(txtCid, null);
                }
                else
                {
                    epErro.SetError(txtCid, "O campo nome é obrigatório");
                    camposValidos = false;
                }
                if (rdbAtivo.Checked)
                {
                    objCommand.Parameters.AddWithValue("@Status", "A");
                    camposValidos = true;
                }
                else
                {
                    objCommand.Parameters.AddWithValue("@Status", "I");
                    camposValidos = true;
                }
                if (!String.IsNullOrEmpty(txtTelefone.Text))
                {
                    objCommand.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                    camposValidos = true;
                } if (cboEstado.SelectedIndex > -1)
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
                #endregion
                if (camposValidos)
                {
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();

                    MessageBox.Show("Registro alterado com sucesso!",
                   "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
