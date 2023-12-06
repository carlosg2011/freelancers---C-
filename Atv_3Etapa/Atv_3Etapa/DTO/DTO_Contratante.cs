using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_3Etapa.DTO
{
    class DTO_Contratante
    {
       
                private int id_contratante;
                public string nome, tel, email;

                public string Email
                {
                    get
                    {
                        return email;
                    }

                    set
                    {
                        email = value;
                    }
                }

                public int id_contrata
                {
                    get
                    {
                        return id_contratante;
                    }

                    set
                    {
                        id_contratante = value;
                    }
                }

                public string Nome
                {
                    get
                    {
                        return nome;
                    }

                    set
                    {
                        nome = value;
                    }
                }

                public string Tel
                {
                    get
                    {
                        return tel;
                    }

                    set
                    {
                        tel = value;
                    }
                }
            }

        
    }


