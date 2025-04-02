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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAOcs conexao = new DAOcs();
        }//metodo construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }//fim do form load

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim titulo pg 1

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }//fim do btn cadastrar

        private void atualizar_Click(object sender, EventArgs e)
        {
            Atualizar atu = new Atualizar();
            atu.ShowDialog();
        }//fim btn atualizar

        private void consultar_Click(object sender, EventArgs e)
        {
            Consultar con = new Consultar();
            con.ShowDialog();
        }//fim btn consultar

        private void excluir_Click(object sender, EventArgs e)
        {
            excluir exc = new excluir();
            exc.ShowDialog();
        }//fim btn excluir


    }//fim da classe
}//fim do projeto
