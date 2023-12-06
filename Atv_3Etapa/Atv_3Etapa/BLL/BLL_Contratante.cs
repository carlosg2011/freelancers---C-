using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Atv_3Etapa.DTO;


namespace Atv_3Etapa.BLL
{
    class BLL_Contratante
    {

            Conexao bd = new Conexao();

            public void InserirContrata(DTO_Contratante contrata)
            {

                try
                {
                    string comando = "INSERT INTO tbl_contratante VALUES (NULL,'" + contrata.Nome + "','" + contrata.email + "','" + contrata.Tel + "');";

                    bd.ExecutarComandos(comando);
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public void AlterarUsuario(DTO_Contratante contrata)
            {
                try
                {
                    string comando = $"UPDATE tbl_contratante SET nome = '{contrata.Nome}', email = '{contrata.Email}', telefone = '{contrata.Tel}' where id_contratente = {contrata.id_contrata}";

                    bd.ExecutarComandos(comando);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public void ExcluirUsuario(int id)
            {
                try
                {
                    string comando = "DELETE FROM tbl_contratante WHERE id_contratente = " + id + ";";
                    bd.ExecutarComandos(comando);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public DataTable ListarUsuarios()
            {
                try
                {
                    string comando = "SELECT * FROM tbl_contratente;";
                    return bd.ExecutarConsulta(comando);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        

    }
}
