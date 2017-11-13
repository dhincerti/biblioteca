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
    public partial class frmAlterarExcluirLivros : Form
    {
        int codigo, ano, paginas;
        string nome, autor, genero, editora, status;

        public frmAlterarExcluirLivros()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterarExcluirLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDS.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bibliotecaDS.Livros);

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDados_CellMouseClick(object sender,
DataGridViewCellMouseEventArgs e)
        {
            //Se a célula que o usuário clicou for a do botão Editar atribuo
            //para as variáveis publicas o valor de cada célula do Grid, referente
            //ao respectivo registro
            if (dgvDados.CurrentCell.Value.ToString() == ">")
            {
                //Passo o ID do registro que será útil em meu UPDATE no outro form
                codigo = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].FormattedValue);
                nome = dgvDados.CurrentRow.Cells[1].FormattedValue.ToString();
                autor = dgvDados.CurrentRow.Cells[2].FormattedValue.ToString();
                ano = Convert.ToInt32(dgvDados.CurrentRow.Cells[3].FormattedValue.ToString());
                genero = dgvDados.CurrentRow.Cells[4].FormattedValue.ToString();
                editora = dgvDados.CurrentRow.Cells[5].FormattedValue.ToString();
                paginas =
               Convert.ToInt32(dgvDados.CurrentRow.Cells[6].FormattedValue.ToString());
                status = dgvDados.CurrentRow.Cells[7].FormattedValue.ToString();
                //Chamo o método Editar, passando as variáveis como parâmetros
                EditarRegistro(codigo, nome, autor, ano, genero, editora, paginas, status);
            }
            //Se a célula que o usuário clicou for a do botão Excluir chamo o
            //método Excluir, passando como parâmetro a linha selecionada + a
            //primeira célula, que contém meu ID com o valor formatado, convertido
            //para Int32
            if (dgvDados.CurrentCell.Value.ToString() == "X")
            {
                ExcluirRegistro(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].FormattedValue));
            }
        }
        private void EditarRegistro(int codigo, string nome, string autor, int ano,
string genero, string editora, int paginas, string status)
        {
            //Instancio o frmAlterar e atribuo ao valor de suas variáveis
            //o valor das variáveis pertencentes a assinatura deste método e
            //abro o form, por meio do método ShowDialog
            frmAlterarLivros objFrmAlterarLivros = new frmAlterarLivros();
            objFrmAlterarLivros.txtCodigo.Text = Convert.ToString(codigo);
            objFrmAlterarLivros.txtNome.Text = nome;
            objFrmAlterarLivros.txtAutor.Text = autor;
            objFrmAlterarLivros.txtAno.Text = Convert.ToString(ano);
            objFrmAlterarLivros.txtGenero.Text = genero;
            objFrmAlterarLivros.txtEditora.Text = editora;
            objFrmAlterarLivros.txtPaginas.Text = Convert.ToString(paginas);
            if (status == "D")
                objFrmAlterarLivros.rdbDisponivel.Checked = true;
            else
                objFrmAlterarLivros.rdbIndisponivel.Checked = true;
            objFrmAlterarLivros.ShowDialog();
            this.livrosTableAdapter.Fill(bibliotecaDS.Livros);
        }
        private void ExcluirRegistro(int codigo)
        {
            //Se o usuário confirmar a exclusão, crio a conexão com o banco
            //e excluo o respectivo registro
            if (MessageBox.Show("Tem certeza que deseja excluir o registro?",
             "Mensagem do Sistema", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection objConexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Biblioteca.mdf;Integrated Security=True;Connect Timeout=30");
                    string strConn = @"DELETE FROM Livros WHERE ID_Livro = @Codigo";
                    SqlCommand objCommand = new SqlCommand(strConn, objConexao);
                    objCommand.Parameters.AddWithValue("@Codigo", codigo);
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                    MessageBox.Show("Livro excluído com sucesso!", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.livrosTableAdapter.Fill(bibliotecaDS.Livros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
