using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EmpresaTINT
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do código

        private void label4_Click(object sender, EventArgs e)
        {

        }//fim do titulo endereco

        private void label3_Click(object sender, EventArgs e)
        {

        }//fim do titulo telefone

        private void CadastrarTitle_Click(object sender, EventArgs e)
        {

        }//fim do titulo cadastrar

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim do nome

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim do telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim do endereco

        private void label2_Click(object sender, EventArgs e)
        {

        }//fim do titulo nome

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim do titulo código

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//btn voltar

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instanciando a classse DAO
            DAOcs inserir = new DAOcs();
            //coletando os dados dos textos
            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox3.Text;
            string telefone = textBox2.Text;
            string endereco = textBox4.Text;

            //chamando o metodo inserir
            MessageBox.Show(inserir.Inserir(codigo, nome, telefone, endereco));
            this.Close();//fechar a janela cadastrar

        }//fim do btn cadastrar
    }//fim da classe
}//fim do projeto
