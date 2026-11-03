using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SistemaCadastro
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost; port=3307; user id=root; password=1234; database=banco_siscadastro");
        public string mensagem;
        public bool insereBanda(Banda novaBanda)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                   new MySqlCommand("sp_insereBanda", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome", novaBanda.Nome);
                cmd.Parameters.AddWithValue("integrantes", novaBanda.Integrantes);
                cmd.Parameters.AddWithValue("ranking", novaBanda.Ranking);
                cmd.Parameters.AddWithValue("genero", novaBanda.Genero);
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }


        }// fim do insereBanda 


    }
}