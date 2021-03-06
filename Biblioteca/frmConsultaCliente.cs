﻿using System;
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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consutar()
        {
            try
            {
                //Instancio o DataTable e TableAdapter de Clientes
                BibliotecaDS.ClientesDataTable objClientesDataTable = new
                 BibliotecaDS.ClientesDataTable();

                ClientesTableAdapter objClientesTableAdapter = new
               ClientesTableAdapter();
                //Verifico qual RadioButton o usuário checou e se o txtProcurar
                //não está vazio para chamar o respectivo método
                if (rdbNome.Checked && !String.IsNullOrEmpty(txtProcurar.Text))
                    //Preencho o TableAdapter com o método FillByNome,
                    //passando o DataTable e o txtProcurar como parâmetros
                    objClientesTableAdapter.FillByNome(objClientesDataTable,
                    "%" + txtProcurar.Text + "%");

                else if (rdbCidade.Checked && !String.IsNullOrEmpty(txtProcurar.Text))
                    //Preencho o TableAdapter com o método FillByCidade,
                    //passando o DataTable e o txtConsulta como parâmetros
                    objClientesTableAdapter.FillByCidade(objClientesDataTable,
                    "%" + txtProcurar.Text + "%");
                else if (rdbStatus.Checked && txtProcurar.Text == "a"
                || rdbStatus.Checked && txtProcurar.Text == "A"
                || rdbStatus.Checked && txtProcurar.Text == "i"
                || rdbStatus.Checked && txtProcurar.Text == "I")

                    //Preencho o TableAdapter com o método FillByEstatus,
                    //passando o DataTable e o txtConsulta como parâmetros
                    objClientesTableAdapter.FillByStatus(objClientesDataTable,
                    txtProcurar.Text);

                //Limpo os dados do meu ListView
                lstDados.Items.Clear();
                //Uso o laço foreach para percorrer as linhas do ClientesDataTable
                //e carregá-las em meu ListView
                foreach (DataRow objDataRow in objClientesDataTable.Rows)
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
                    if (objDataRow[6].ToString() == "A")
                    {
                        objListViewItem.SubItems.Add("Ativo");
                    }
                    else
                    {
                        objListViewItem.SubItems.Add("Inativo");
                    }
                    //No final adiciono os itens em meu ListView, passando
                    //como parâmetro o objListViewItem carregado
                    lstDados.Items.Add(objListViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consutar();
        }
    }
}
