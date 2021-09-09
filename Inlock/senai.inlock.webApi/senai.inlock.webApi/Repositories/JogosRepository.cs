using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Repositories
{
    public class JogosRepository : IJogosReposirtory
    {
        private string stringConexao = "Data Source=NOTE0113I2\\SQLEXPRESS; initial catalog=inlock_games_TARDE ; user Id=SA; pwd=Senai@132";

        public void AtualizarIdCorpo(JogosDomain jogoATT)
        {
            if (jogoATT.nomeJogo != null)
            {
                using (SqlConnection con = new SqlConnection(stringConexao))
                {
                    string queryUpdateBody = "UPDATE JOGOS SET nomeJogo = @nomeJogo, descrição = @descrição , dataLançamento = @data, valor = @valor WHERE idJogo = @idJogo";

                    using (SqlCommand cmd = new SqlCommand(queryUpdateBody, con))
                    {
                        cmd.Parameters.AddWithValue("@nomeGenero", jogoATT.nomeJogo);
                        cmd.Parameters.AddWithValue("@descrição", jogoATT.descrição);
                        cmd.Parameters.AddWithValue("@data", jogoATT.dataLançamento);
                        cmd.Parameters.AddWithValue("@valor", jogoATT.Valor);

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public void AtualizarIUrl(JogosDomain jogoATT)
        {
            if (jogoATT.nomeJogo != null)
            {
                using (SqlConnection con = new SqlConnection(stringConexao))
                {
                    string queryUpdateBody = "UPDATE JOGOS SET nomeJogo = @nomeJogo, descrição = @descrição , dataLançamento = @data, valor = @valor WHERE idJogo = @idJogo";

                    using (SqlCommand cmd = new SqlCommand(queryUpdateBody, con))
                    {
                        cmd.Parameters.AddWithValue("@nomeGenero", jogoATT.nomeJogo);
                        cmd.Parameters.AddWithValue("@descrição", jogoATT.descrição);
                        cmd.Parameters.AddWithValue("@data", jogoATT.dataLançamento);
                        cmd.Parameters.AddWithValue("@valor", jogoATT.Valor);

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public JogosDomain BuscarPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectById = @"SELECT nomeJogo as Jogo, descrição, dataLançamento as Data de Lançamento, valor, nomeEstudio as Estudio FROM JOGOS
                                            LEFT JOIN ESTUDIO
                                            ON JOGOS.idEstudio = ESTUDIO.idEstudio
                                            WHERE idJogo = @idJogo
                                            GO";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@idJogo", id);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        JogosDomain jogoBuscado = new JogosDomain
                        {
                            idJogo = Convert.ToInt32(rdr["idJogo"]),

                            nomeJogo = rdr["nomeJogo"].ToString(),

                            descrição = rdr["descrição"].ToString(),
                            dataLançamento = Convert.ToDateTime(rdr["dataLançamento"]),
                            Valor = Convert.ToDecimal(rdr["valor"]),

                            nomeEstudio = rdr["nomeEstudio"].ToString()
                        };

                        return jogoBuscado;
                    }

                    return null;
                }
            }
        }

        public void Cadastrar(JogosDomain novoJogo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryInsert = "INSERT INTO JOGOS (nomeJogo, descrição, dataLançamento,valor,idEstudio) VALUES (@nomeJogo, @descrição, @dataLançamento, @valor, @idEstudio)";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@nomeJogo", novoJogo.nomeJogo);
                    cmd.Parameters.AddWithValue("@descrisção", novoJogo.descrição);
                    cmd.Parameters.AddWithValue("@dataLançamento", novoJogo.dataLançamento);
                    cmd.Parameters.AddWithValue("@valor", novoJogo.Valor);
                    cmd.Parameters.AddWithValue("@idEstudio", novoJogo.idEstudio);

                    //Executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
              
                string queryDelete = "DELETE FROM JOGOS WHERE idJogo = @idJogo";

                
                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    
                    cmd.Parameters.AddWithValue("@idJogo", id);

                    
                    con.Open();

                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<JogosDomain> ListarTodos()
        {
            List<JogosDomain> listajogos = new List<JogosDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idGenero, nomeGenero FROM GENERO";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        JogosDomain jogo = new JogosDomain()
                        {
                            idJogo = Convert.ToInt32(rdr["idJogo"]),

                            nomeJogo = rdr["nomeJogo"].ToString(),

                            descrição = rdr["descrição"].ToString(),
                            dataLançamento = Convert.ToDateTime(rdr["dataLançamento"]),
                            Valor = Convert.ToDecimal(rdr["valor"]),

                            nomeEstudio = rdr["nomeEstudio"].ToString())
                        };

                        listajogos.Add(jogo);
                    }
                }
            }

            return listajogos;
        }
    }
     }   
}
    }