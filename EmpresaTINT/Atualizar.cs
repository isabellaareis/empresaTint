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
    public partial class Atualizar : Form
    {
        DAOcs atu;
        public Atualizar()
        {
            atu = new DAOcs();
            InitializeComponent();
            textBox1.ReadOnly = false;
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void TINT01_Click(object sender, EventArgs e)
        {

        }//titulo atualizar

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do btn voltar

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim da label código

        private void label2_Click(object sender, EventArgs e)
        {

        }//fim da label nome

        private void label3_Click(object sender, EventArgs e)
        {

        }//fim da label telefone

        private void label4_Click(object sender, EventArgs e)
        {

        }//fim da label endereco

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do codigo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim do nome

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim do telefone

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }//fim do atualizar

        private void button1_Click(object sender, EventArgs e)
        { 
            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox3.Text;
            string telefone = textBox2.Text;
            string endereco = textBox4.Text;

            atu.Atualizar(codigo, "nome", nome);
            atu.Atualizar(codigo, "telefone", telefone);
            atu.Atualizar(codigo, "endereco", endereco);
            MessageBox.Show("Dados atualizado com sucesso!");
            this.Close();
        }//fim do btn atualizar

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ""){
                textBox3.Text = "Informe o código";
                textBox2.Text = "Informe o código";
                textBox4.Text = "Informe o código";
            }
            else
            {
                int codigo = Convert.ToInt32(textBox1.Text);//coletando

                textBox3.Text = atu.RetornarNome(codigo);//preenchendo o campo nome
                textBox2.Text = atu.RetornarTelefone(codigo);//preenchendo o campo telefone
                textBox4.Text = atu.RetornarEndereco(codigo);//preenchendo o campo endereco

                textBox1.ReadOnly = true;
                textBox3.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }

           
        }//fim do btn buscar
    }
}

