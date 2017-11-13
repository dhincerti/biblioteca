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
    public partial class frmCadastrarLivros : Form
    {
        public frmCadastrarLivros()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
                string strConn = @"INSERT INTO LIVROS (Nome_Livro, Autor_Livro, Ano_Livro,
Genero_Livro, Editora_Livro, Paginas_Livro, Status_Livro) VALUES (@NomeLivro,
@Autor, @Ano, @Genero, @Editora, @Paginas, @Status)";
                SqlCommand objCommand = new SqlCommand(strConn, objConexao);
                #region Validações dos Campos
                if (rdbDisponivel.Checked)
                {
                    objCommand.Parameters.AddWithValue("@Status", "D");
                    camposValidos = true;
                }
                else
                {
                    objCommand.Parameters.AddWithValue("@Status", "I");
                    camposValidos = true;
                } if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    objCommand.Parameters.AddWithValue("@NomeLivro", txtNome.Text);
                    camposValidos = true;
                    epErro.SetError(txtNome, null);
                }
                else
                {
                    epErro.SetError(txtNome, "O campo Nome é obrigatório");
                    camposValidos = false;
                }
                if (!String.IsNullOrEmpty(txtAutor.Text))
                {
                    objCommand.Parameters.AddWithValue("@Autor", txtAutor.Text);
                    camposValidos = true;
                    epErro.SetError(txtAutor, null);
                }
                else
                {
                    epErro.SetError(txtAutor, "O campo Autor é obrigatório");
                    camposValidos = false;
                }

                if (!String.IsNullOrEmpty(txtAno.Text))
                {
                    objCommand.Parameters.AddWithValue("@Ano", txtAno.Text);
                    camposValidos = true;
                    epErro.SetError(txtAno, null);
                }
                else
                {
                    epErro.SetError(txtAno, "O campo Ano é obrigatório");
                    camposValidos = false;
                }
                if (!String.IsNullOrEmpty(txtGenero.Text))
                {
                    objCommand.Parameters.AddWithValue("@Genero", txtGenero.Text);
                    camposValidos = true;
                    epErro.SetError(txtGenero, null);
                }
                else
                {
                    epErro.SetError(txtGenero, "O campo Gênero é obrigatório");
                    camposValidos = false;
                }
                if (!String.IsNullOrEmpty(txtEditora.Text))
                {
                    objCommand.Parameters.AddWithValue("@Editora", txtEditora.Text);
                    camposValidos = true;
                    epErro.SetError(txtEditora, null);
                }
                else
                {
                    epErro.SetError(txtEditora, "O campo Editora é obrigatório");
                    camposValidos = false;
                }


                objCommand.Parameters.AddWithValue("@Paginas", txtPaginas.Value);
                #endregion
                if (camposValidos)
                {
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                    MessageBox.Show("Registro inserido com sucesso!", "Mensagem",
                     MessageBoxButtons.OK, MessageBoxIcon.Information); LimparCampos();
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
            txtAutor.Text = "";
            txtAno.Text = "";
            txtGenero.Text = "";
            txtEditora.Text = "";
            rdbDisponivel.Checked = true;
            rdbIndisponivel.Checked = false;
            txtPaginas.Value = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
