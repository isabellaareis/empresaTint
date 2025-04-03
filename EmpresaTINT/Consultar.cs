using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTINT
{
    public partial class Consultar : Form
    {
        DAOcs consul;
        public Consultar()
        {
            consul = new DAOcs();
            InitializeComponent();
            configurarDataGrid();//configura a estrutura da coluna e linhas
            nomeColunas();//nomeando as colunas
            adicionardados();//adicionando os dados para vizualizar
        }

        private void TINT01_Click(object sender, EventArgs e)
        {

        }//fim do titulo consultar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        public void nomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Endereço";
        }//fim nome colunas

        public void configurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//nao pode adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//nao pode apagar linhas
            dataGridView1.AllowUserToResizeColumns = false;//nao pode redirecionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//nao pode redirecionar linhas

            dataGridView1.ColumnCount = 4;//total de colunas que tem
        }//fim do configurarr data grid

        public void adicionardados()
        {
            consul.preeencherVetor();//preencher os vetores com dados do banco
            for(int i= 0; i < consul.quantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.nome[i], consul.telefone[i], consul.endereco[i]);
            }//fim do for

        }//fim do adicionar dados

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do data grid view

       
    }
}
