using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.Entities
{
    public class EmpresaPessoaEntity
    {
        public EmpresaEntity codEmpresa { get; set; }
        public PessoaEntity codPessoa { get; set; }
        public double Expectativa { get; set; }

        public EmpresaPessoaEntity()
        {

        }
    }
}