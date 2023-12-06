using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Atv_3Etapa.DTO;

namespace Atv_3Etapa.BLL
{
    class BLL_Servico
    {

        Conexao bd = new Conexao();

        public void InserirServico(DTO_Servico serve)
        {

            try
            {
                string comando = "INSERT INTO tbl_servico VALUES (NULL,'" + serve.Titulo + "','" + serve.Descricao + "','" + serve.Valor + "');";

                bd.ExecutarComandos(comando);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarUsuario(DTO_Servico serve)
        {
            try
            {
                string comando = $"UPDATE tbl_servico SET nome = '{serve.Titulo}', email = '{serve.Descricao}', telefone = '{serve.Valor}' where id_freelancer = {serve.Id_servico}";

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
                string comando = "DELETE FROM tbl_servico WHERE id_servico = " + id + ";";
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
                string comando = "SELECT * FROM tbl_servico;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
