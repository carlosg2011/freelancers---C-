using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Atv_3Etapa.DTO;

namespace Atv_3Etapa
{
    class BLL_Freelancer
    {
        Conexao bd = new Conexao();

        public void InserirFreela(DTO_Freela freela)
        {

            try
            {
                string comando = "INSERT INTO tbl_freelancer VALUES (NULL,'" + freela.Nome + "','" + freela.Tel + "','" + freela.Email + "');";

                bd.ExecutarComandos(comando);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        public void AlterarUsuario(DTO_Freela freela)
        {
            try
            {
                string comando = $"UPDATE tbl_freelancer SET nome = '{freela.Nome}', email = '{freela.Email}', telefone = '{freela.Tel}' where id_freelancer = {freela.Id_freela}";

                bd.ExecutarComandos(comando);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        

        public void ExcluirUsuario(int id)
        {
            try
            {
                string comando = "DELETE FROM tbl_freelancer WHERE id_freelancer = " + id + ";";
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
                string comando = "SELECT * FROM tbl_freelancer;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

