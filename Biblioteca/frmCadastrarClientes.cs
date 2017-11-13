using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca
{
    public partial class frmCadastrarClientes : Form
    {
        public frmCadastrarClientes()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            //Crio uma variável booleana que irá verificar se os campos estão validados
            bool camposValidados = false;
            try
            {
                //Instancio a classe de conexão passando como parâmetro a string de
                //conexão ao DataBase Biblioteca
                SqlConnection objConexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Biblioteca.mdf;Integrated Security=True;Connect Timeout=30");
                //Armazeno em uma variável do tipo string minha instrução SQL
                //referente à inserção do registro concatenando os valores
                //parametrizados, referentes aos campos que serão preenchidos no form
                string strConn = @"INSERT INTO Clientes (Nome_Cliente, Endereco_Cliente,Cidade_Cliente, Estado_Cliente,Telefone_Cliente, Status_Cliente) VALUES(@Nome, @Endereco, @Cidade, @Estado, @Telefone, @Status)";
                //Uso o objeto instanciado passando como parâmetro a string
                //criada anteriomente e o objeto de conexão ao banco
                SqlCommand objCommand = new SqlCommand(strConn, objConexao);
                #region Validações dos Campos
                //Faço a verificação: se os campos do form estiverem
                //diferentes de nulos uso o método AddWithValue passando
                //como parâmetro o Value parametrizado do Insert acima.
                //Se os campos estiverem vazios, chamo o ErrorProvider
                //disparando o erro ao usuário nome
                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", txtNome.Text);
                    camposValidados = true;
                    epErro.SetError(txtNome, null);
                }
                else
                {
                    epErro.SetError(txtNome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }
                if (!String.IsNullOrEmpty(txtEnd.Text))
                {
                    objCommand.Parameters.AddWithValue("@Endereco", txtEnd.Text);
                    camposValidados = true;
                    epErro.SetError(txtEnd, null);
                }
                else
                {
                    epErro.SetError(txtEnd, "O campo Endereço é obrigatório!");
                    camposValidados = false;
                }
                if (!String.IsNullOrEmpty(txtCid.Text))
                {
                    objCommand.Parameters.AddWithValue("@Cidade", txtCid.Text);
                    camposValidados = true;
                    epErro.SetError(txtCid, null);
                }
                else
                {
                    epErro.SetError(txtCid, "O campo Cidade é obrigatório!");
                    camposValidados = false;
                }
                if (rdbAtivo.Checked)
                {
                    objCommand.Parameters.AddWithValue("@Status", "A");
                    camposValidados = true;
                }
                else
                {
                    objCommand.Parameters.AddWithValue("@Status", "I");
                    camposValidados = true;
                }
                if (!String.IsNullOrEmpty(txtTelefone.Text))
                {
                    objCommand.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                    camposValidados = true;
                }
                if (cboEstado.SelectedIndex > -1)
                {
                    objCommand.Parameters.AddWithValue("@Estado", cboEstado.SelectedItem);
                    camposValidados = true;
                    epErro.SetError(cboEstado, null);
                }
                else
                {
                    epErro.SetError(cboEstado, "O campo Estado é obrigatório!");
                    camposValidados = false;
                }
                #endregion
                //Verifico se o retorno de minha variável camposValidados é true
                if (camposValidados)
                {
                    //Abro a conexão
                    objConexao.Open();
                    //Uso o método ExecuteNonQuery para executar os comandos e
                    //realizar o Insert no banco
                    objCommand.ExecuteNonQuery();
                    //Fecho a conexão
                    objConexao.Close();
                    //Exibo a mensagem ao usuário de confirmação da inserção no banco
                    MessageBox.Show("Registro inserido com sucesso!", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Chamo o método para limpar os campos e dou o foco ao txtNome
                    LimparCampos();
                    txtNome.Focus();
                    //Habilito o botão Voltar para o usuário
                    btnVoltar.Enabled = true;
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
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtCid.Text = "";
            cboEstado.Text = "";
            txtTelefone.Text = "";
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
