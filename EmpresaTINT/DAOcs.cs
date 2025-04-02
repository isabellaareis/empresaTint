using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EmpresaTINT
{
     class DAOcs
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;

        public DAOcs()
        {
            conexao = new MySqlConnection("server=localhost;Database=tintCSharp;Uid=root;password=");
            try
            {
                conexao.Open();//tentando conectar
                MessageBox.Show("Conectado!!!");



            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n\n" + erro );
            }
        }//fim do construtor

        public string Inserir(int codigo, string nome, string telefone, string endereco)
        {

            string inserir = $"Insert into pessoa(codigo, nome, telefone, endereco) values('{codigo}', '{nome}', '{telefone}', '{endereco}' )";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";

            return resultado;
        }//fim do metodo inserir

        public void preeencherVetor()
        {

            string query = "select * from pessoa";

            //instanciar vetores
            this.codigo   = new int[100];
            this.nome     = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];

            //preparando comando para o banco

            MySqlCommand Sql = new MySqlCommand(query, conexao);
            //chamar o leitor do banco de dados
            MySqlDataReader leitura = Sql.ExecuteReader();

            i = 0;//instanciando o contador
            while (leitura.Read())
            {

                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++;//contador gira
            }//fim do while

            //encerrar processo de leitura
            leitura.Close();
        }//fim do método

       
    }//fim da classe
}//fim do projeto
