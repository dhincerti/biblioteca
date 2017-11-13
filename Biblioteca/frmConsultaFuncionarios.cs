using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.BibliotecaDSTableAdapters;

namespace Biblioteca
{
    public partial class frmConsultaFuncionarios : Form
    {
        public frmConsultaFuncionarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            try
            {
                //Instancio o DataTable e TableAdapter de Livros
                BibliotecaDS.FuncionariosDataTable objFuncionariosDataTable =
                new BibliotecaDS.FuncionariosDataTable();
                FuncionariosTableAdapter objFuncionariosTableAdapter =
                new FuncionariosTableAdapter();
                //Verifico qual RadioButton o usuário clicou e se o txtProcurar
                //não está vazio para chamar o respectivo método
                if (rdbNome.Checked && !String.IsNullOrEmpty(txtProcurar.Text))
                    //Preencho o TableAdapter com o método FillByNome, passando o
                    //DataTable e o txtProcurar como parâmetros
                    objFuncionariosTableAdapter.FillByNome(objFuncionariosDataTable,
                    "%" + txtProcurar.Text + "%");
                else if (rdbEstado.Checked && !String.IsNullOrEmpty(txtProcurar.Text))
                    //Preencho o TableAdapter com o método FillByEstado, passando
                    //o DataTable e o txtConsulta como parâmetros
                    objFuncionariosTableAdapter.FillByEstado(objFuncionariosDataTable,
                    txtProcurar.Text);
                else if (rdbCargo.Checked && !String.IsNullOrEmpty(txtProcurar.Text))
                    //Preencho o TableAdapter com o método FillByCargo, passando
                    //o DataTable e o txtConsulta como parâmetros
                    objFuncionariosTableAdapter.FillByCargo(objFuncionariosDataTable,
                    "%" + txtProcurar.Text + "%");
                //Limpo os dados do meu ListView
                lstDados.Items.Clear();
                //Uso o laço foreach para percorrer as linhas do
                //FuncionarioDataTable e carregá-las em meu ListView
                foreach (DataRow objDataRow in objFuncionariosDataTable.Rows)
                {
                    //Instancio a classe ListViewItem e vou adicionando o item
                    //e subitens
                    ListViewItem objListViewItem = new ListViewItem();
                    objListViewItem.Text = objDataRow[0].ToString();
                    objListViewItem.SubItems.Add(objDataRow[1].ToString());
                    objListViewItem.SubItems.Add(objDataRow[2].ToString());
                    objListViewItem.SubItems.Add(objDataRow[3].ToString());
                    objListViewItem.SubItems.Add(objDataRow[4].ToString());
                    objListViewItem.SubItems.Add(objDataRow[5].ToString());
                    objListViewItem.SubItems.Add(objDataRow[6].ToString());
                    //No final adiciono os itens em meu ListView, passando como
                    //parâmetro o objListViewItem carregado
                    lstDados.Items.Add(objListViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
