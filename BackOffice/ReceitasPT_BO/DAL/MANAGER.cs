using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class MANAGER
    {
        /////////////////////
        #region declarações
        int ReceitaID;
        public List<USER> listadeUsers = null;
        #endregion
        /////////////////////
        #region Lista_de_Ingredientes
        public List<INGREDIENT> listadeIngredientes()
        {
            SqlConnection ligacao = new SqlConnection();
            List<INGREDIENT> listadeIngredientesretorno = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeIngredientesretorno = new List<INGREDIENT>();
                SqlCommand cmdListaIngrediente = new SqlCommand();
                cmdListaIngrediente.CommandText = "ListarIngrediente";
                cmdListaIngrediente.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaIngrediente.Connection = ligacao;
                SqlDataReader drListaTodosIngredientes = null;
                drListaTodosIngredientes = cmdListaIngrediente.ExecuteReader();
                if (drListaTodosIngredientes.HasRows)
                {
                    while (drListaTodosIngredientes.Read())
                    {
                        INGREDIENT novoIngrediente = new INGREDIENT();
                        novoIngrediente.IngredienteID = (int)drListaTodosIngredientes[0];
                        novoIngrediente.IngredienteNome = drListaTodosIngredientes[1].ToString();
                        listadeIngredientesretorno.Add(novoIngrediente);
                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Não executou o comando");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
            return listadeIngredientesretorno;
        }
        #endregion
        /////////////////////
        #region Lista_de_Categorias
        public List<CATEGORIA> listadecategorias()
        {
            SqlConnection ligacao = new SqlConnection();
            List<CATEGORIA> listadecategoriasretornada = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadecategoriasretornada = new List<CATEGORIA>();
                SqlCommand cmdListaCategoria = new SqlCommand();
                cmdListaCategoria.CommandText = "ListarCategoria";
                cmdListaCategoria.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaCategoria.Connection = ligacao;
                SqlDataReader drListaTodasCategorias = null;
                drListaTodasCategorias = cmdListaCategoria.ExecuteReader();
                if (drListaTodasCategorias.HasRows)
                {
                    while (drListaTodasCategorias.Read())
                    {
                        CATEGORIA novaCategoria = new CATEGORIA();
                        novaCategoria.CategoriaID = (int)drListaTodasCategorias[0];
                        novaCategoria.CategoriaNome = drListaTodasCategorias[1].ToString();
                        listadecategoriasretornada.Add(novaCategoria);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao.State == System.Data.ConnectionState.Open)
                {
                    ligacao.Close();
                }
            }
            return listadecategoriasretornada;
        }
        #endregion
        /////////////////////
        #region Lista_de_Dificuldades

        public List<DIFICULDADE> listadedificuldades()
        {
            SqlConnection ligacao = new SqlConnection();
            List<DIFICULDADE> listadeDificuldadesretornada = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeDificuldadesretornada = new List<DIFICULDADE>();
                SqlCommand cmdListaDificuldade = new SqlCommand();
                cmdListaDificuldade.CommandText = "ListarDificuldade";
                cmdListaDificuldade.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaDificuldade.Connection = ligacao;
                SqlDataReader drListaTodasDificuldades = null;
                drListaTodasDificuldades = cmdListaDificuldade.ExecuteReader();
                if (drListaTodasDificuldades.HasRows)
                {
                    while (drListaTodasDificuldades.Read())
                    {
                        DIFICULDADE novaDificuldade = new DIFICULDADE();
                        novaDificuldade.DificuldadeID = (int)drListaTodasDificuldades[0];
                        novaDificuldade.DificuldadeNome = drListaTodasDificuldades[1].ToString();
                        listadeDificuldadesretornada.Add(novaDificuldade);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao.State == System.Data.ConnectionState.Open)
                {
                    ligacao.Close();
                }
            }
            return listadeDificuldadesretornada;
        }
        #endregion
        /////////////////////
        #region Lista_De_Unidades
        public List<UNIDADE> listadeUnidades()
        {
            SqlConnection ligacao = new SqlConnection();
            List<UNIDADE> listadeUnidadesretornada = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeUnidadesretornada = new List<UNIDADE>();
                SqlCommand cmdListaUnidade = new SqlCommand();
                cmdListaUnidade.CommandText = "ListarUnidade";
                cmdListaUnidade.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaUnidade.Connection = ligacao;
                SqlDataReader drListaTodasUnidades = null;
                drListaTodasUnidades = cmdListaUnidade.ExecuteReader();
                if (drListaTodasUnidades.HasRows)
                {
                    while (drListaTodasUnidades.Read())
                    {
                        UNIDADE novaUnidade = new UNIDADE();
                        novaUnidade.UnidadeID = (int)drListaTodasUnidades[0];
                        novaUnidade.UnidadeNome = drListaTodasUnidades[1].ToString();
                        listadeUnidadesretornada.Add(novaUnidade);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao.State == System.Data.ConnectionState.Open)
                {
                    ligacao.Close();
                }
            }
            return listadeUnidadesretornada;
        }
        #endregion
        /////////////////////
        #region Submeter_Receita
        public void InserirReceita(RECEITA r)
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand IreceitaS1 = new SqlCommand("InserirReceitaStep1", ligacao);
                IreceitaS1.CommandType = System.Data.CommandType.StoredProcedure;
                IreceitaS1.Parameters.AddWithValue("@ReceitaNome", r.ReceitaNome);
                IreceitaS1.Parameters.AddWithValue("@UserID", r.UserID);
                IreceitaS1.Parameters.AddWithValue("@ReceitaDescricao", r.ReceitaDescricao);
                IreceitaS1.Parameters.AddWithValue("@Rating", r.Rating);
                IreceitaS1.Parameters.AddWithValue("@ReceitaEstado", r.ReceitaEstado);
                IreceitaS1.Parameters.AddWithValue("@ReceitaImagem", r.ReceitaImagem);
                IreceitaS1.Parameters.AddWithValue("@ReceitaDuracao", r.ReceitaDuracao);
                IreceitaS1.Parameters.AddWithValue("@CategoriaID", r.CategoriaID);
                IreceitaS1.Parameters.AddWithValue("@TOP5", r.TOP5);
                IreceitaS1.Parameters.AddWithValue("@DificuldadeID", r.DificuldadeID);
                ReceitaID = (int)IreceitaS1.ExecuteScalar();
                //IreceitaS1.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////
        #region Submeter_ReceitaIngredientes
        public bool InserirReceitaStep2(int IngredienteID, double IngredienteQtidade, int UnidadeID)
        {
            int ReceitaIDverificada = ReceitaID;
            SqlConnection ligacao = null;
            try
            {

                ligacao = new SqlConnection(Properties.Settings.Default.WebsiteReceitasConnectionString);
                SqlCommand cmdinserirlistinhadaboa = new SqlCommand("InserirReceitaS2", ligacao);
                cmdinserirlistinhadaboa.CommandType = System.Data.CommandType.StoredProcedure;
                cmdinserirlistinhadaboa.Parameters.AddWithValue("@ReceitaID", ReceitaIDverificada);
                cmdinserirlistinhadaboa.Parameters.AddWithValue("@IngredienteID", IngredienteID);
                cmdinserirlistinhadaboa.Parameters.AddWithValue("@IngredienteQtidade", IngredienteQtidade);
                cmdinserirlistinhadaboa.Parameters.AddWithValue("@UnidadeID", UnidadeID);
                cmdinserirlistinhadaboa.Connection = ligacao;
                ligacao.Open();
                if (cmdinserirlistinhadaboa.ExecuteNonQuery() != 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {

                        ligacao.Close();
                    }
                }
            }

        }
        #endregion
        /////////////////////
        #region Submeter_Ingrediente_BO
        public void InserirIngrediente(INGREDIENT i) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand Iingrediente = new SqlCommand("InserirIngredientes", ligacao);
                Iingrediente.CommandType = System.Data.CommandType.StoredProcedure;
                Iingrediente.Parameters.AddWithValue("@IngredienteNome", i.IngredienteNome);
                Iingrediente.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////        
        #region Lista_De_Users
        public List<USER> listadeUSERS()
        {
            SqlConnection ligacao = new SqlConnection();
            List<USER> listadeusersretorno = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeusersretorno = new List<USER>();
                SqlCommand cmdListaUser = new SqlCommand();
                cmdListaUser.CommandText = "ListarUser";
                cmdListaUser.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaUser.Connection = ligacao;
                SqlDataReader drListaTodosUsers = null;
                drListaTodosUsers = cmdListaUser.ExecuteReader();
                if (drListaTodosUsers.HasRows)
                {
                    while (drListaTodosUsers.Read())
                    {
                        USER novoUser = new USER();
                        novoUser.UserID = (int)drListaTodosUsers[0];
                        novoUser.UserAutorname = drListaTodosUsers[1].ToString();
                        listadeusersretorno.Add(novoUser);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
            return listadeusersretorno;
        }
        #endregion
        ///////////////////// 
        #region Lista_De_Users_Banidos
        public List<USER> listadeUSERSbanidos()
        {
            SqlConnection ligacao = new SqlConnection();
            List<USER> listadeusersbanidosretorno = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeusersbanidosretorno = new List<USER>();
                SqlCommand cmdListaUserban = new SqlCommand();
                cmdListaUserban.CommandText = "ListarUserBAN";
                cmdListaUserban.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaUserban.Connection = ligacao;
                SqlDataReader drListaTodosUsers = null;
                drListaTodosUsers = cmdListaUserban.ExecuteReader();
                if (drListaTodosUsers.HasRows)
                {
                    while (drListaTodosUsers.Read())
                    {
                        USER novoUser = new USER();
                        novoUser.UserID = (int)drListaTodosUsers[0];
                        novoUser.UserAutorname = drListaTodosUsers[1].ToString();
                        listadeusersbanidosretorno.Add(novoUser);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
            return listadeusersbanidosretorno;
        }
        #endregion
        /////////////////////
        #region DataSet_Receitas
        public DataSet GetData()
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlDataAdapter da = new SqlDataAdapter("ObterReceitas", ligacao);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
        }
        #endregion
        /////////////////////
        #region Receita_Escolhida_Ingre
        public DataSet GetDataING(int ReceitaID)
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlDataAdapter da = new SqlDataAdapter("ObterReceitaING", ligacao);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@ReceitaID", ReceitaID);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
        }
        #endregion
        /////////////////////
        #region Receita_Inserir_CMT
        public void inserirComentario(int ReceitaID, int userId, string ComentarioTXT)
        {
            SqlConnection ligacao = new SqlConnection();
            ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
            try
            {
                ligacao.Open();
                SqlCommand cmd = new SqlCommand("InserirComentárioReceita", ligacao);
                cmd.CommandType = CommandType.StoredProcedure;
                int state = 0;
                cmd.Parameters.AddWithValue("@ReceitaID", ReceitaID);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@ComentarioTXT", ComentarioTXT);
                cmd.Parameters.AddWithValue("@ComentarioState", state);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ligacao.Close();
            }
        }
        #endregion
        /////////////////////
        #region Receita_Inserir_Rating
        public void inserirVoto(int ReceitaID, int userId, int Rating)
        {
            SqlConnection ligacao = new SqlConnection();
            ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
            try
            {
                ligacao.Open();
                SqlCommand cmd = new SqlCommand("InserirVoto", ligacao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReceitaID", ReceitaID);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@Rating",Rating);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ligacao.Close();
            }
        }
        #endregion
        /////////////////////
        #region Receita_CM
        public DataSet GetDataCM(int ReceitaID)
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlDataAdapter da = new SqlDataAdapter("ObterReceitaCMT", ligacao);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@ReceitaID", ReceitaID);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
        }
        #endregion
        /////////////////////
        #region Receita_EscolhidaSBAR
        public DataSet GetDataSBAR(string treceita, string textsearch)
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                DataSet ds = new DataSet();

                if (treceita == "Ingrediente")
                {
                    SqlDataAdapter da = new SqlDataAdapter("ObterReceitaINGsbar", ligacao);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@IngredienteNome", textsearch);
                    da.Fill(ds);
                }
                else if (treceita == "Nome")
                {
                    SqlDataAdapter da = new SqlDataAdapter("ObterReceitanomesbar", ligacao);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ReceitaNome", textsearch);
                    da.Fill(ds);
                }
                else if (treceita == "Categoria")
                {
                    SqlDataAdapter da = new SqlDataAdapter("ObterReceitaCatsbar", ligacao);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ReceitaCat", textsearch);
                    da.Fill(ds);
                }
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
        }
        #endregion
        /////////////////////
        #region Submeter_User_Pesquisa
        public void InserirLastSearch(int userS, string userST, string userSTT)
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand IlastSearch = new SqlCommand("InserirLastSearch", ligacao);
                IlastSearch.CommandType = System.Data.CommandType.StoredProcedure;
                IlastSearch.Parameters.AddWithValue("@userID", userS);
                IlastSearch.Parameters.AddWithValue("@userPesquisa", userST);
                IlastSearch.Parameters.AddWithValue("@userPesquisaType", userSTT);
                IlastSearch.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        ///////////////////// 
        #region Lista_De_Pesquisas
        public List<PESQUISA> Ultimaspesquisas(int userId)
        {
            SqlConnection ligacao = new SqlConnection();
            List<PESQUISA> listadepesquisasretornada = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadepesquisasretornada = new List<PESQUISA>();
                SqlCommand cmdListaPesquisa = new SqlCommand();
                cmdListaPesquisa.CommandText = "ObterUltimaPesquisa";
                cmdListaPesquisa.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaPesquisa.Parameters.AddWithValue("@UserID", userId);
                cmdListaPesquisa.Connection = ligacao;
                SqlDataReader drListaTodasPesquisas = null;
                drListaTodasPesquisas = cmdListaPesquisa.ExecuteReader();
                if (drListaTodasPesquisas.HasRows)
                {
                    while (drListaTodasPesquisas.Read())
                    {
                        PESQUISA novaPesquisa = new PESQUISA();
                        novaPesquisa.UserID = (int)drListaTodasPesquisas[0];
                        novaPesquisa.UserPesquisa = drListaTodasPesquisas[1].ToString();
                        novaPesquisa.UserPesquisaType = drListaTodasPesquisas[2].ToString();
                        listadepesquisasretornada.Add(novaPesquisa);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao.State == System.Data.ConnectionState.Open)
                {
                    ligacao.Close();
                }
            }
            return listadepesquisasretornada;
        }
        #endregion
        /////////////////////
        #region Banir_User_BO
        public void BanirUser(USER User) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                string UserName = User.UserAutorname;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand Buser = new SqlCommand("BanirUser", ligacao);
                Buser.CommandType = System.Data.CommandType.StoredProcedure;
                Buser.Parameters.AddWithValue("@UserName", UserName);
                Buser.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////  
        #region Desbanir_User_BO
        public void DesbanirUser(USER User) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                string UserName = User.UserAutorname;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand Buser = new SqlCommand("DesbanirUser", ligacao);
                Buser.CommandType = System.Data.CommandType.StoredProcedure;
                Buser.Parameters.AddWithValue("@UserName", UserName);
                Buser.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////  
        #region DataTable_Receitas_BO
        public DataTable GetDataReceitaBO()
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlDataAdapter da = new SqlDataAdapter("ObterReceitasBOunA", ligacao);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
        }
        #endregion
        /////////////////////
        #region Lista_De_Receitas_BO_UA
        public List<RECEITA> listadeRECEITASUA()
        {
            SqlConnection ligacao = new SqlConnection();
            List<RECEITA> listadeReceitasUAretorno = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeReceitasUAretorno = new List<RECEITA>();
                SqlCommand cmdListaR_UA = new SqlCommand();
                cmdListaR_UA.CommandText = "ListarRECEITA_UA";
                cmdListaR_UA.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaR_UA.Connection = ligacao;
                SqlDataReader drListaTodasReceitas = null;
                drListaTodasReceitas = cmdListaR_UA.ExecuteReader();
                if (drListaTodasReceitas.HasRows)
                {
                    while (drListaTodasReceitas.Read())
                    {
                        RECEITA novaRUA = new RECEITA();
                        novaRUA.ReceitaID = (int)drListaTodasReceitas[0];
                        novaRUA.ReceitaNome = drListaTodasReceitas[1].ToString();
                        listadeReceitasUAretorno.Add(novaRUA);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
            return listadeReceitasUAretorno;
        }
        #endregion
        /////////////////////
        #region Lista_De_Receitas_BO_A
        public List<RECEITA> listadeRECEITASA()
        {
            SqlConnection ligacao = new SqlConnection();
            List<RECEITA> listadeReceitasAretornada = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeReceitasAretornada = new List<RECEITA>();
                SqlCommand cmdListaRA = new SqlCommand();
                cmdListaRA.CommandText = "ListarRECEITA_A";
                cmdListaRA.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaRA.Connection = ligacao;
                SqlDataReader drListaTodasReceitas = null;
                drListaTodasReceitas = cmdListaRA.ExecuteReader();
                if (drListaTodasReceitas.HasRows)
                {
                    while (drListaTodasReceitas.Read())
                    {
                        RECEITA novaRA = new RECEITA();
                        novaRA.ReceitaID = (int)drListaTodasReceitas[0];
                        novaRA.ReceitaNome = drListaTodasReceitas[1].ToString();
                        listadeReceitasAretornada.Add(novaRA);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
            return listadeReceitasAretornada;
        }
        #endregion
        /////////////////////
        #region Lista_De_Receitas_BO_A
        public List<RECEITA> listadeRECEITASB()
        {
            SqlConnection ligacao = new SqlConnection();
            List<RECEITA> listadeReceitasBretornada = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeReceitasBretornada = new List<RECEITA>();
                SqlCommand cmdListaRB = new SqlCommand();
                cmdListaRB.CommandText = "ListarRECEITA_B";
                cmdListaRB.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaRB.Connection = ligacao;
                SqlDataReader drListaTodasReceitas = null;
                drListaTodasReceitas = cmdListaRB.ExecuteReader();
                if (drListaTodasReceitas.HasRows)
                {
                    while (drListaTodasReceitas.Read())
                    {
                        RECEITA novaRB = new RECEITA();
                        novaRB.ReceitaID = (int)drListaTodasReceitas[0];
                        novaRB.ReceitaNome = drListaTodasReceitas[1].ToString();
                        listadeReceitasBretornada.Add(novaRB);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
            return listadeReceitasBretornada;
        }
        #endregion
        /////////////////////
        #region APROVAR_Receita_BO
        public void aprovarReceita(RECEITA receita) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                int ReceitaID = receita.ReceitaID;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand Buser = new SqlCommand("AprovarReceita", ligacao);
                Buser.CommandType = System.Data.CommandType.StoredProcedure;
                Buser.Parameters.AddWithValue("@ReceitaID", ReceitaID);
                Buser.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////  
        #region BANIR_Receita_BO
        public void banirReceita(RECEITA receita) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                int ReceitaID = receita.ReceitaID;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand Buser = new SqlCommand("BanirReceita", ligacao);
                Buser.CommandType = System.Data.CommandType.StoredProcedure;
                Buser.Parameters.AddWithValue("@ReceitaID", ReceitaID);
                Buser.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////
        #region DESBANIR_Receita_BO
        public void desbanirReceita(RECEITA receita) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                int ReceitaID = receita.ReceitaID;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand Buser = new SqlCommand("DesbanirReceita", ligacao);
                Buser.CommandType = System.Data.CommandType.StoredProcedure;
                Buser.Parameters.AddWithValue("@ReceitaID", ReceitaID);
                Buser.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////
        #region Lista_De_CM_BO_UA
        public List<COMMENT> listadeCMUA()
        {
            SqlConnection ligacao = new SqlConnection();
            List<COMMENT> listadeCMUAretornado = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeCMUAretornado = new List<COMMENT>();
                SqlCommand cmdListaCM_UA = new SqlCommand();
                cmdListaCM_UA.CommandText = "ListarCM_UA";
                cmdListaCM_UA.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaCM_UA.Connection = ligacao;
                SqlDataReader drListaTodosCM = null;
                drListaTodosCM = cmdListaCM_UA.ExecuteReader();
                if (drListaTodosCM.HasRows)
                {
                    while (drListaTodosCM.Read())
                    {
                        COMMENT novoCM_UA = new COMMENT();
                        novoCM_UA.ComentarioID = (int)drListaTodosCM[0];
                        novoCM_UA.ReceitaID = (int)drListaTodosCM[1];
                        novoCM_UA.UserID = (int)drListaTodosCM[2];
                        novoCM_UA.ComentarioTXT = drListaTodosCM[3].ToString();
                        novoCM_UA.ComentarioState = (int)drListaTodosCM[4];
                        listadeCMUAretornado.Add(novoCM_UA);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
            return listadeCMUAretornado;
        }
        #endregion
        /////////////////////
        #region Lista_De_CM_BO_A
        public List<COMMENT> listadeCMA()
        {
            SqlConnection ligacao = new SqlConnection();
            List<COMMENT> listadeCMAretornado = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeCMAretornado = new List<COMMENT>();
                SqlCommand cmdListaCM_A = new SqlCommand();
                cmdListaCM_A.CommandText = "ListarCM_A";
                cmdListaCM_A.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaCM_A.Connection = ligacao;
                SqlDataReader drListaTodosCM = null;
                drListaTodosCM = cmdListaCM_A.ExecuteReader();
                if (drListaTodosCM.HasRows)
                {
                    while (drListaTodosCM.Read())
                    {
                        COMMENT novoCM_A = new COMMENT();
                        novoCM_A.ComentarioID = (int)drListaTodosCM[0];
                        novoCM_A.ReceitaID = (int)drListaTodosCM[1];
                        novoCM_A.UserID = (int)drListaTodosCM[2];
                        novoCM_A.ComentarioTXT = drListaTodosCM[3].ToString();
                        novoCM_A.ComentarioState = (int)drListaTodosCM[4];
                        listadeCMAretornado.Add(novoCM_A);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
            return listadeCMAretornado;
        }
        #endregion
        /////////////////////
        #region Lista_De_CM_BO_A
        public List<COMMENT> listadeCMB()
        {
            SqlConnection ligacao = new SqlConnection();
            List<COMMENT> listadeCMBretornado = null;
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                listadeCMBretornado = new List<COMMENT>();
                SqlCommand cmdListaCM_B = new SqlCommand();
                cmdListaCM_B.CommandText = "ListarCM_B";
                cmdListaCM_B.CommandType = System.Data.CommandType.StoredProcedure;
                cmdListaCM_B.Connection = ligacao;
                SqlDataReader drListaTodosCM = null;
                drListaTodosCM = cmdListaCM_B.ExecuteReader();
                if (drListaTodosCM.HasRows)
                {
                    while (drListaTodosCM.Read())
                    {
                        COMMENT novoCM_B = new COMMENT();
                        novoCM_B.ComentarioID = (int)drListaTodosCM[0];
                        novoCM_B.ReceitaID = (int)drListaTodosCM[1];
                        novoCM_B.UserID = (int)drListaTodosCM[2];
                        novoCM_B.ComentarioTXT = drListaTodosCM[3].ToString();
                        novoCM_B.ComentarioState = (int)drListaTodosCM[4];
                        listadeCMBretornado.Add(novoCM_B);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
            return listadeCMBretornado;
        }
        #endregion
        /////////////////////
        #region AprovarComment_BO
        public void aprovarCOMMENT(COMMENT comment) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                int ComentarioID = comment.ComentarioID;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand Acomment = new SqlCommand("AprovarComment", ligacao);
                Acomment.CommandType = System.Data.CommandType.StoredProcedure;
                Acomment.Parameters.AddWithValue("@ComentarioID", ComentarioID);
                Acomment.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////
        #region banirComment_BO
        public void banirCOMMENT(COMMENT comment) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                int ComentarioID = comment.ComentarioID;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand Bcomment = new SqlCommand("banirComment", ligacao);
                Bcomment.CommandType = System.Data.CommandType.StoredProcedure;
                Bcomment.Parameters.AddWithValue("@ComentarioID", ComentarioID);
                Bcomment.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////
        #region unbanComment_BO
        public void unbanCOMMENT(COMMENT comment) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                int ComentarioID = comment.ComentarioID;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand UBcomment = new SqlCommand("unbanirComment", ligacao);
                UBcomment.CommandType = System.Data.CommandType.StoredProcedure;
                UBcomment.Parameters.AddWithValue("@ComentarioID", ComentarioID);
                UBcomment.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////
        #region T5_ADD_BO
        public void top5addR(RECEITA receita) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                int receitaID = receita.ReceitaID;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand t5ar = new SqlCommand("TOP5Y", ligacao);
                t5ar.CommandType = System.Data.CommandType.StoredProcedure;
                t5ar.Parameters.AddWithValue("@ReceitaID", receitaID);
                t5ar.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////
        #region T5_REM_BO
        public void top5remR(RECEITA receita) //TODO INGREDIENTES COM INSERT DUPLO
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                int receitaID = receita.ReceitaID;
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlCommand t5rr = new SqlCommand("TOP5N", ligacao);
                t5rr.CommandType = System.Data.CommandType.StoredProcedure;
                t5rr.Parameters.AddWithValue("@ReceitaID", receitaID);
                t5rr.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ligacao != null)
                {
                    ligacao.Close();
                }
            }
        }
        #endregion
        /////////////////////
        #region DataSet_Receitas_T5
        public DataSet GetDataT5()
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlDataAdapter da = new SqlDataAdapter("ObterReceitasT5", ligacao);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
        }
        #endregion
        /////////////////////
        #region Lista_De_Favoritos
        public DataSet GetDataFAV(int userID)
        {
            SqlConnection ligacao = new SqlConnection();
            try
            {
                ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
                ligacao.Open();
                SqlDataAdapter da = new SqlDataAdapter("ObterFavoritos", ligacao);
                da.SelectCommand.Parameters.AddWithValue("@UserID",userID);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (ligacao != null)
                {
                    if (ligacao.State == System.Data.ConnectionState.Open)
                    {
                        ligacao.Close();
                    }
                }
            }
        }
        #endregion
        /////////////////////
        #region Receita_Inserir_Rating
        public void inserirnosFav(int ReceitaID, int userId, int state)
        {
            SqlConnection ligacao = new SqlConnection();
            ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
            try
            {
                ligacao.Open();
                SqlCommand cmd = new SqlCommand("InserirFAV", ligacao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReceitaID", ReceitaID);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@FavoritoState", state);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ligacao.Close();
            }
        }
        #endregion
        /////////////////////
        #region remover_dos_fav
        public void removerdosFav(int ReceitaID, int userId)
        {
            SqlConnection ligacao = new SqlConnection();
            ligacao.ConnectionString = Properties.Settings.Default.WebsiteReceitasConnectionString;
            try
            {
                ligacao.Open();
                SqlCommand cmd = new SqlCommand("removeFAV", ligacao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReceitaID", ReceitaID);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ligacao.Close();
            }
        }
        #endregion
        /////////////////////
    }
}

