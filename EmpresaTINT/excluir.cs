﻿using System;
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
    public partial class excluir : Form
    {
        DAOcs exc;
 
        public excluir()
        {
            exc = new DAOcs();
            InitializeComponent();
        }

        private void TINT01_Click(object sender, EventArgs e)
        {

        }//fim do titulo excluir

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim voltar

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim codigo

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo codigo

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(exc.Excluir(codigo));
            this.Close();
        }//fim btn excluir
    }
}
