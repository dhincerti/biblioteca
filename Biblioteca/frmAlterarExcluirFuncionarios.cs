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
using System.Data;

namespace Biblioteca
{
    public partial class frmAlterarExcluirFuncionarios : Form
    {
        int codigo;
        string nome, endereco, cidade, estado, telefone, cargo, dataAdm, dataDem;

        public frmAlterarExcluirFuncionarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterarExcluirFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDS.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.bibliotecaDS.Funcionarios);

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDados_CellMouseClick(object sender,
DataGridViewCellMouseEventArgs e)
        {
            //Se a célula que o usuário clicou for a do botão Editar atribuo
            //para as variáveis publicas o valor de cada célula do Grid,
            //referente ao respectivo registro
            if (dgvDados.CurrentCell.Value.ToString() == ">")
            {
                //Passo o ID do registro que será útil em meu UPDATE no outro form
                codigo = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].FormattedValue);
                nome = dgvDados.CurrentRow.Cells[1].FormattedValue.ToString();
                endereco = dgvDados.CurrentRow.Cells[2].FormattedValue.ToString();
                cidade = dgvDados.CurrentRow.Cells[3].FormattedValue.ToString();
                estado = dgvDados.CurrentRow.Cells[4].FormattedValue.ToString();
                telefone = dgvDados.CurrentRow.Cells[5].FormattedValue.ToString();
                cargo = dgvDados.CurrentRow.Cells[6].FormattedValue.ToString();
                dataAdm = dgvDados.CurrentRow.Cells[7].FormattedValue.ToString();
                dataDem = dgvDados.CurrentRow.Cells[8].FormattedValue.ToString();
                //Chamo o método Editar, passando as variáveis como parâmetros
                EditarRegistro(codigo, nome, endereco, cidade, estado, telefone,
                cargo, dataAdm, dataDem);
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

        private void EditarRegistro(int codigo, string nome, string endereco, string
cidade, string estado, string telefone, string cargo, string dataAdm, string
daraDem)
        {
            //Instancio o frmAlterar e atribuo ao valor de suas variáveis o
            //valor das variáveis pertencentes a assinatura deste método e abro
            //o form, por meio do método ShowDialog
            frmAlterarFuncionarios objFrmAlterarFucnionarios = new frmAlterarFuncionarios();
            objFrmAlterarFucnionarios.txtCodigo.Text = Convert.ToString(codigo);
            objFrmAlterarFucnionarios.txtNome.Text = nome;
            objFrmAlterarFucnionarios.txtEnd.Text = endereco;
            objFrmAlterarFucnionarios.txtCid.Text = cidade;
            objFrmAlterarFucnionarios.cboEstado.Text = estado;
            objFrmAlterarFucnionarios.txtTelefone.Text = telefone;
            objFrmAlterarFucnionarios.txtCargo.Text = cargo;
            objFrmAlterarFucnionarios.txtDataAdm.Text = dataAdm;
            objFrmAlterarFucnionarios.txtDataDem.Text = dataDem;
            objFrmAlterarFucnionarios.ShowDialog();
            this.funcionariosTableAdapter.Fill(bibliotecaDS.Funcionarios);
        } 

        private void ExcluirRegistro(int codigo)
        {
            //Se o usuário confirmar a exclusão, crio a conexão com o banco e
            //excluo o respectivo registro
            if (MessageBox.Show("Tem certeza que deseja excluir o registro?",
            "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                try
                {
                    SqlConnection objConexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Biblioteca.mdf;Integrated Security=True;Connect Timeout=30");
                    string strConn = @"DELETE FROM Funcionarios WHERE ID_FUNCIONARIO = @Codigo";
                    SqlCommand objCommand = new SqlCommand(strConn, objConexao);
                    objCommand.Parameters.AddWithValue("@Codigo", codigo);
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                    MessageBox.Show("Registro excluído com sucesso!", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.funcionariosTableAdapter.Fill(bibliotecaDS.Funcionarios);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 
    }
}
