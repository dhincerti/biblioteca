using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmAlterarLivros : Form
    {
        public frmAlterarLivros()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
                string strConn = @"UPDATE LIVROS SET Nome_Livro = @Nome, Autor_Livro =
@Autor, Ano_Livro = @Ano, Genero_Livro = @Genero, Editora_Livro = @Editora,
Paginas_Livro = @Paginas, Status_Livro = @Status WHERE Id_Livro = " +
               Convert.ToUInt32(txtCodigo.Text);
                SqlCommand objCommand = new SqlCommand(strConn, objConexao);
                #region Validações dos Campos
                //Nome do Livro
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
                //Autor
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
                //Ano
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
                //Genero
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
                //Editora
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
                //Status
                if (rdbDisponivel.Checked)
                {
                    objCommand.Parameters.AddWithValue("@Status", "D");
                    camposValidos = true;

                }
                else
                {
                    objCommand.Parameters.AddWithValue("@Status", "I");
                    camposValidos = true;
                }
                //Paginas
                if (!String.IsNullOrEmpty(txtPaginas.Text))
                {
                    objCommand.Parameters.AddWithValue("@Paginas", txtPaginas.Text);
                    camposValidos = true;
                }
                #endregion
                if (camposValidos)
                {
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                    MessageBox.Show("Livro alterado com sucesso!", "Mensagem",
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
        }
    }
}
