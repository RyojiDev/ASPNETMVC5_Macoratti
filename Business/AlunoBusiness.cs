using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AlunoBusiness
    {
        public string stringConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConSQLServer"].ConnectionString;
            return connectionString;
        }
        public IEnumerable<AlunoBO> getAlunos()
        {
            
            List<AlunoBO> alunos = new List<AlunoBO>();

            try
            {
                using(SqlConnection conn = new SqlConnection(stringConnection()))
                {
                    SqlCommand cmd = new SqlCommand("GetAlunos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        
                        AlunoBO aluno = new AlunoBO();
                        aluno.Id = Convert.ToInt32(dr["Id"]);
                        aluno.Nome = dr["Nome"].ToString();
                        aluno.Email = dr["Email"].ToString();
                        aluno.Idade = Convert.ToInt32(dr["Idade"]);
                        aluno.DataInscricao = Convert.ToDateTime(dr["DataInscricao"].ToString());
                        aluno.Sexo = dr["Sexo"].ToString();
                        aluno.Foto = dr["Foto"].ToString();
                        aluno.Texto = dr["Texto"].ToString();
                        alunos.Add(aluno);
                    }
                    

                }

                return alunos;

            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void IncluirAluno(AlunoBO aluno)
        {
            
            try
            {
               using(SqlConnection conn = new SqlConnection(stringConnection()))
                {
                    SqlCommand cmd = new SqlCommand("IncluirAluno", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramNome = new SqlParameter();
                    paramNome.ParameterName = "@Nome";
                    paramNome.Value = aluno.Nome;
                    cmd.Parameters.Add(paramNome);

                    SqlParameter paramEmail = new SqlParameter();
                    paramEmail.ParameterName = "@Email";
                    paramEmail.Value = aluno.Email;
                    cmd.Parameters.Add(paramEmail);

                    SqlParameter paramIdade = new SqlParameter();
                    paramIdade.ParameterName = "@Idade";
                    paramIdade.Value = aluno.Idade;
                    cmd.Parameters.Add(paramIdade);

                    SqlParameter paramDataInscricao = new SqlParameter();
                    paramDataInscricao.ParameterName = "@DataInscricao";
                    paramDataInscricao.Value = aluno.DataInscricao;
                    cmd.Parameters.Add(paramDataInscricao);

                    SqlParameter paramSexo = new SqlParameter();
                    paramSexo.ParameterName = "@Sexo";
                    paramSexo.Value = aluno.Sexo;
                    cmd.Parameters.Add(paramSexo);

                    SqlParameter paramFoto = new SqlParameter();
                    paramFoto.ParameterName = "@Foto";
                    paramFoto.Value = aluno.Foto;
                    cmd.Parameters.Add(paramFoto);

                    SqlParameter paramTexto = new SqlParameter();
                    paramTexto.ParameterName = "@Texto";
                    paramTexto.Value = aluno.Texto;
                    cmd.Parameters.Add(paramTexto);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void AtualizarAluno(AlunoBO aluno)
        {
            
            try { 
            using (SqlConnection conn = new SqlConnection(stringConnection()))
            {
                    SqlCommand cmd = new SqlCommand("AtualizarAluno",conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramId = new SqlParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = aluno.Id;
                    cmd.Parameters.Add(paramId);

                    SqlParameter paramNome = new SqlParameter();
                    paramNome.ParameterName = "@Nome";
                    paramNome.Value = aluno.Nome;
                    cmd.Parameters.Add(paramNome);

                    SqlParameter paramIdade = new SqlParameter();
                    paramIdade.ParameterName = "@Idade";
                    paramIdade.Value = aluno.Idade;
                    cmd.Parameters.Add(paramIdade);

                    SqlParameter paramDataInscricao = new SqlParameter();
                    paramDataInscricao.ParameterName = "@DataInscricao";
                    paramDataInscricao.Value = aluno.DataInscricao;
                    cmd.Parameters.Add(paramDataInscricao);

                    SqlParameter paramSexo = new SqlParameter();
                    paramSexo.ParameterName = "@Sexo";
                    paramSexo.Value = aluno.Sexo;
                    cmd.Parameters.Add(paramSexo);

                    SqlParameter paramEmail = new SqlParameter();
                    paramEmail.ParameterName = "@Email";
                    paramEmail.Value = aluno.Email;
                    cmd.Parameters.Add(paramEmail);

                    SqlParameter paramFoto = new SqlParameter();
                    paramFoto.ParameterName = "@Foto";
                    paramFoto.Value = aluno.Foto;
                    cmd.Parameters.Add(paramFoto);

                    SqlParameter paramTexto = new SqlParameter();
                    paramTexto.ParameterName = "@Texto";
                    paramTexto.Value = aluno.Texto;
                    cmd.Parameters.Add(paramTexto);

                    conn.Open();
                    cmd.ExecuteNonQuery();

            }

            }catch(Exception e)
            {
                throw new UpdateException(e.Message);
            }
        }

        public void DeletarAluno(int id)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(stringConnection()))
                {
                    SqlCommand cmd = new SqlCommand("DeletarAluno",conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramId = new SqlParameter();
                    paramId.ParameterName = "@id";
                    paramId.Value = id;
                    cmd.Parameters.Add(paramId);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
