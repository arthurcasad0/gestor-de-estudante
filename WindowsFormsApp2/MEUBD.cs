using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    internal class MEUBD
    {
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=t5_sga_db");

        public MySqlConnection getConexao
        {
            get { return conexao; } 
        }

        //Método para ABRIR/INICIALIZAR an conexão
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }



        //Método para FECHAR/ENCERAR an conexão
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }MEUBD banco de dados 
    }
}
   