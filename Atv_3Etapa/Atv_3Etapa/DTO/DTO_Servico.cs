using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_3Etapa.DTO
{
    class DTO_Servico
    {

        private int id_servico;
        private string titulo, descricao;
        private double valor;

        public string Id_servico
        {
            get
            {
                return Id_servico;
            }

            set
            {
                Id_servico = value;
            }
        }

        public string Titulo
        {
            get
            {
                return Titulo;
            }

            set
            {
                Titulo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return Descricao;
            }

            set
            {
                Descricao = value;
            }
        }

        public double Valor
        {
            get
            {
                return Valor;
            }

            set
            {
                Valor = value;
            }
        }

    }
}
