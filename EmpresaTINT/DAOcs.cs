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
        public int contador;

        public DAOcs()
        {
            conexao = new MySqlConnection("server=localhost;Database=tintCSharp;Uid=root;password=");
            try
            {
                conexao.Open();//tentando conectar
               



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
            contador = 0;
            while (leitura.Read())
            {

                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++;//contador gira
                contador++;//conta quantos dados preenchem o vetor
            }//fim do while

            //encerrar processo de leitura
            leitura.Close();
        }//fim do método




        public int ConsultarPorCodigo(int cod)
        {
            preeencherVetor();//preenchendo o vetor com o sdados do banco

            i = 0;//instanciando o contador
            while (i < quantidadeDeDados())
            {
                if (codigo[i] == cod)
                {
                    return i;
                }
                i++;//contador gira
            }//fim do while
            return -1;
        }//fim do método

        public string RetornarNome(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if(posicao > -1)
            {
                return nome[posicao];
            }
            return "Código digitado não é válido";
        }//fim retornar nome

        public string RetornarTelefone(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return telefone[posicao];
            }
            return "Código digitado não é válido";
        }//fim retornar telefone

        public string RetornarEndereco(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return endereco[posicao];
            }
            return "Código digitado não é válido";
        }//fim retornar endereço

        public int quantidadeDeDados()
        {
            return contador;
        }//fim qntd de dados


        public string Atualizar(int codigo, string campo, string dado)
        {
            string query = $"update pessoa set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }//fim metodo atualizar

        public string Excluir(int codigo)
        {
            string query = $"delete from pessoa where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Deletado";
            return resultado;
        }

       
    }//fim da classe
}//fim do projeto
